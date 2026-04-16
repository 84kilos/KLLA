using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Microsoft.CognitiveServices.Speech.PronunciationAssessment;
using NAudio.Wave;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;


namespace KLLA
{
    public partial class SenModeForm : BaseForm
    {
        private readonly Form practiceForm;

        private Random rand = new Random();
        private KllaDB db = new KllaDB();
        List<KoreanSentence> Sentences;
        int currentSentenceIndex = 0;
        string currentTheme;
        bool lblTapped = false;
        bool isRecording = false;

        int questionsCounter = 0;
        int questionsRight = 0;
        int longestStreak = 0;
        int currentStreak = 0;

        WaveInEvent waveIn;
        WaveFileWriter writer;

        double totalPronunciation = 0;
        double totalAccuracy = 0;
        double totalFluency = 0;
        double totalCompleteness = 0;

        Color gradeColor1Front = ColorTranslator.FromHtml("#3B95E6");
        Color gradeColor1Back = ColorTranslator.FromHtml("#D4E9FF");
        Color gradeColor2Front = ColorTranslator.FromHtml("#2F86C9");
        Color gradeColor2Back = ColorTranslator.FromHtml("#CFE4FA");
        Color gradeColor3Front = ColorTranslator.FromHtml("#B85A6A");
        Color gradeColor3Back = ColorTranslator.FromHtml("#F3D4D9");

        public SenModeForm(Form practiceForm, string theme)
        {
            InitializeComponent();

            this.practiceForm = practiceForm;

            // Wire standard window buttons
            WireWindowButtons(btnClose, btnMin, btnMax);

            // Make header draggable
            EnableDraggableHeader(panelHeader);

            // ============= REWIRE CLOSE, RETURN, AND COMPLETE BUTTONS TO RETURN TO PRACTICE FORM =============
            btnClose.Click += (_, _) =>
            {
                practiceForm.Show();
                this.Close();
            };
            btnReturn.Click += (_, _) =>
            {
                practiceForm.Show();
                this.Close();
            };

            currentTheme = theme;

            btnRecord.BackColor = ColorTranslator.FromHtml("#DCEEFF");

            this.Shown += (s, e) =>
            {
                ApplyRoundedRegion(this, 20);
                ApplyRoundedRegion(btnClose, 15);
                ApplyRoundedRegion(btnReturn, 15);
                ApplyRoundedRegion(btnMin, 15);
                ApplyRoundedRegion(btnMax, 15);
                ApplyRoundedRegion(btnFinish, 15);
                ApplyRoundedRegion(btnNext, 15);
                ApplyRoundedRegion(lblPronunciation, 25);
                ApplyRoundedRegion(lblAccuracy, 25);
                ApplyRoundedRegion(lblFluency, 25);
                ApplyRoundedRegion(lblCompleteness, 25);
                ApplyRoundedRegion(btnRecord, 150);
            };
        }

        private async void SenModeForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Connect to database and load word lists
                await db.Connect_Database();
                Sentences = db.GetSentencesByTheme(currentTheme);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database load failed. Looks like our database is down.");
            }
            //Cool randomize list logic from stack overflow
            Sentences = Sentences.OrderBy(x => Random.Shared.Next()).ToList();
            lblSentenceKor.Text = Sentences[currentSentenceIndex].Sentence;
            lblSentenceEng.Text = Sentences[currentSentenceIndex].Translation;
            lblSentencePron.Text = Sentences[currentSentenceIndex].Pronunciation;
            lblSentenceEng.Visible = false;
            lblSentencePron.Visible = false;
            gbStats.Visible = false;
            lblPronunciation.Visible = false;

            btnFinish.Visible = false;
            btnNext.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentSentenceIndex++;
            if (currentSentenceIndex >= Sentences.Count)
            {
                MessageBox.Show("You've completed all sentences in this theme! Returning to theme selection.");
                practiceForm.Show();
                this.Close();
                return;
            }
            lblSentenceKor.Text = Sentences[currentSentenceIndex].Sentence;
            lblSentenceEng.Text = Sentences[currentSentenceIndex].Translation;
            lblSentencePron.Text = Sentences[currentSentenceIndex].Pronunciation;
            lblSentenceEng.Visible = false;
            lblSentencePron.Visible = false;
            lblTapped = false;
            gbStats.Visible = false;
            lblPronunciation.Visible = false;

            btnFinish.Visible = false;
            btnNext.Visible = false;
        }

        private async void btnRecord_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                questionsCounter++;
                StartRecording();
                isRecording = true;
                btnRecord.BackColor = AccentBlue;
            }
            else
            {
                StopRecording();
                isRecording = false;
                btnRecord.BackColor = ColorTranslator.FromHtml("#DCEEFF");
                var result = await AssessPronunciation(Sentences[currentSentenceIndex].Sentence);
                gbStats.Visible = true;
                lblPronunciation.Visible = true;

                btnFinish.Visible = true;
                btnNext.Visible = true;
            }
        }

        //============ GRADING FUNCTION ============
        async Task<PronunciationAssessmentResult> AssessPronunciation(string expectedSentence)
        {
            var config = SpeechConfig.FromSubscription(AZURE_KEY, AZURE_REGION);
            config.SpeechRecognitionLanguage = "ko-KR";

            using var audioInput = AudioConfig.FromWavFileInput("audio/input.wav");
            using var recognizer = new SpeechRecognizer(config, audioInput);

            var pronConfig = new PronunciationAssessmentConfig(expectedSentence, GradingSystem.HundredMark, Granularity.Phoneme, true);
            pronConfig.ApplyTo(recognizer);

            var result = await recognizer.RecognizeOnceAsync();

            var pronResult = PronunciationAssessmentResult.FromResult(result);
            totalPronunciation += pronResult.PronunciationScore;
            totalAccuracy += pronResult.AccuracyScore;
            totalFluency += pronResult.FluencyScore;
            totalCompleteness += pronResult.CompletenessScore;

            lblPronunciation.Text = $"{(int)pronResult.PronunciationScore}%";
            lblPronunciation.Tag = (int)pronResult.PronunciationScore;
            lblAccuracy.Text = $"Accuracy: {(int)pronResult.AccuracyScore}%";
            lblAccuracy.Tag = (int)pronResult.AccuracyScore;
            lblFluency.Text = $"Fluency: {(int)pronResult.FluencyScore:F1}%";
            lblFluency.Tag = (int)pronResult.FluencyScore;
            lblCompleteness.Text = $"Completeness: {(int)pronResult.CompletenessScore:F1}%";
            lblCompleteness.Tag = (int)pronResult.CompletenessScore;

            List<Label> labels = new List<Label> { lblPronunciation, lblAccuracy, lblFluency, lblCompleteness };

            foreach (var label in labels)
            {
                int score = (int)label.Tag;
                if (score >= 90)
                {
                    questionsRight++;
                    currentStreak++;
                    label.ForeColor = AccentBlue;
                    label.BackColor = ColorTranslator.FromHtml("#DCEEFF");
                }
                else if (score >= 80)
                {
                    questionsRight++;
                    currentStreak++;
                    label.ForeColor = gradeColor1Front;
                    label.BackColor = gradeColor1Back;
                }
                else if (score >= 70)
                {
                    questionsRight++;
                    currentStreak++;
                    label.ForeColor = gradeColor2Front;
                    label.BackColor = gradeColor2Back;
                }
                else if (score >= 60)
                {
                    currentStreak = 0;
                    label.ForeColor = gradeColor3Front;
                    label.BackColor = gradeColor3Back;
                }
                else
                {
                    currentStreak = 0;
                    label.ForeColor = AccentRed;
                    label.BackColor = ColorTranslator.FromHtml("#FADADA");
                }

                if (currentStreak > longestStreak) longestStreak = currentStreak;
            }

            return pronResult;
        }

        //============ RECORDING HELPER FUNCTIONS ============
        void StartRecording()
        {
            waveIn = new WaveInEvent();
            waveIn.WaveFormat = new WaveFormat(16000, 1); // Azure prefers 16kHz mono

            writer = new WaveFileWriter("audio/input.wav", waveIn.WaveFormat);

            waveIn.DataAvailable += (s, a) =>
            {
                writer.Write(a.Buffer, 0, a.BytesRecorded);
            };

            waveIn.RecordingStopped += (s, a) =>
            {
                writer.Dispose();
                waveIn.Dispose();
            };

            waveIn.StartRecording();
        }

        void StopRecording()
        {
            waveIn.StopRecording();
        }

        private async void lblSentenceKor_Click(object sender, EventArgs e)
        {
            var speechConfig = SpeechConfig.FromSubscription(AZURE_KEY, AZURE_REGION);
            using var synthesizer = new SpeechSynthesizer(speechConfig);
            if (!lblTapped) {
                lblSentenceEng.Visible = true;
                lblTapped = true;
            } else
            {
                lblSentencePron.Visible = true;
                await synthesizer.SpeakTextAsync(Sentences[currentSentenceIndex].Sentence);
            }
        }
    }
}