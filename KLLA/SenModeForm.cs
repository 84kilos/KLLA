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

        Color gradeColor1Front = ColorTranslator.FromHtml("#6C8FE8");
        Color gradeColor1Back = ColorTranslator.FromHtml("#E1E9FA");
        Color gradeColor2Front = ColorTranslator.FromHtml("#8A7ACF");
        Color gradeColor2Back = ColorTranslator.FromHtml("#E9E4F4");
        Color gradeColor3Front = ColorTranslator.FromHtml("#B8638A");
        Color gradeColor3Back = ColorTranslator.FromHtml("#F3DDE4");

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

            lblSentenceEng.Visible = false;
            lblSentencePron.Visible = false;
            gbStats.Visible = false;
            lblPronunciation.Visible = false;
            lblSentenceKor.Visible = false;
            btnRecord.Visible = false;

            btnFinish.Visible = false;
            btnNext.Visible = false;

            gbResults.Visible = false;
            lblResPronunciation.Visible = false;
            lblQuestionCounter.Visible = false;
            btnClose2.Visible = false;


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
                ApplyRoundedRegion(lblResPronunciation, 25);
                ApplyRoundedRegion(lblResAccuracy, 25);
                ApplyRoundedRegion(lblResFluency, 25);
                ApplyRoundedRegion(lblResCompleteness, 25);
                ApplyRoundedRegion(lblQuestionCounter, 25);
                ApplyRoundedRegion(btnClose2, 25);
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

            lblResMessage.Visible = false;
            lblSentenceKor.Visible = true;
            btnRecord.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentSentenceIndex++;
            if (currentSentenceIndex >= Sentences.Count)
            {
                this.btnFinish_Click(sender, e);
            }
            else
            {
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

        }

        private async void btnRecord_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                questionsCounter++;
                StartRecording();
                btnRecord.BackgroundImage = Image.FromFile("images/mic.png");
                isRecording = true;
                btnRecord.BackColor = AccentBlue;
            }
            else
            {
                StopRecording();
                isRecording = false;
                btnRecord.BackgroundImage = Image.FromFile("images/load.png");
                var result = await AssessPronunciation(Sentences[currentSentenceIndex].Sentence);
                btnRecord.BackColor = ColorTranslator.FromHtml("#DCEEFF");
                btnRecord.BackgroundImage = Image.FromFile("images/micEmpty.png");
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
            pronConfig.EnableProsodyAssessment();
            pronConfig.ApplyTo(recognizer);

            var result = await recognizer.RecognizeOnceAsync();

            var pronResult = PronunciationAssessmentResult.FromResult(result);
            double pronScore = pronResult.AccuracyScore * 0.4
                + pronResult.ProsodyScore * 0.2
                + pronResult.FluencyScore * 0.2
                + pronResult.CompletenessScore * 0.2;

            totalPronunciation += pronResult.PronunciationScore;
            totalAccuracy += pronResult.AccuracyScore;
            totalFluency += pronResult.FluencyScore;
            totalCompleteness += pronResult.CompletenessScore;

            lblPronunciation.Text = $"{(int)pronScore}%";
            lblPronunciation.Tag = (int)pronScore;
            lblAccuracy.Text = $"Accuracy: {(int)pronResult.AccuracyScore}%";
            lblAccuracy.Tag = (int)pronResult.AccuracyScore;
            lblFluency.Text = $"Fluency: {(int)pronResult.FluencyScore}%";
            lblFluency.Tag = (int)pronResult.FluencyScore;
            lblCompleteness.Text = $"Completeness: {(int)pronResult.CompletenessScore}%";
            lblCompleteness.Tag = (int)pronResult.CompletenessScore;

            if (pronScore >= 90)
            {
                questionsRight++;
                currentStreak++;
                CorrectSound();
            }
            else if (pronScore >= 80)
            {
                questionsRight++;
                currentStreak++;
                CorrectSound();
            }
            else if (pronScore >= 70)
            {
                questionsRight++;
                currentStreak++;
                CorrectSound();
            }
            else if (pronScore >= 60)
            {
                currentStreak = 0;
                IncorrectSound();
            }
            else
            {
                currentStreak = 0;
                IncorrectSound();
            }
            if (currentStreak > longestStreak) longestStreak = currentStreak;

            List<Label> labels = new List<Label> { lblPronunciation, lblAccuracy, lblFluency, lblCompleteness };

            foreach (var label in labels)
            {
                int score = (int)label.Tag;
                if (score >= 90)
                {
                    label.ForeColor = AccentBlue;
                    label.BackColor = ColorTranslator.FromHtml("#DCEEFF");
                }
                else if (score >= 80)
                {
                    label.ForeColor = gradeColor1Front;
                    label.BackColor = gradeColor1Back;
                }
                else if (score >= 70)
                {
                    label.ForeColor = gradeColor2Front;
                    label.BackColor = gradeColor2Back;
                }
                else if (score >= 60)
                {
                    label.ForeColor = gradeColor3Front;
                    label.BackColor = gradeColor3Back;
                }
                else
                {
                    label.ForeColor = AccentRed;
                    label.BackColor = ColorTranslator.FromHtml("#FADADA");
                }
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
            if (!lblTapped)
            {
                lblSentenceEng.Visible = true;
                lblTapped = true;
            }
            else
            {
                lblSentencePron.Visible = true;
                await synthesizer.SpeakTextAsync(Sentences[currentSentenceIndex].Sentence);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            var grade = totalPronunciation / questionsCounter;
            lblQuestionCounter.Text = $"Questions: {questionsRight}/{questionsCounter}";
            lblResPronunciation.Text = $"{(int)grade}%";
            //lblResPronunciation.Tag = (int)totalPronunciation;
            lblResAccuracy.Text = $"Total Accuracy: {(int)(totalAccuracy / questionsCounter)}%";
            //lblResAccuracy.Tag = (int)totalAccuracy;
            lblResFluency.Text = $"Total Fluency: {(int)(totalFluency / questionsCounter)}%";
            //lblResFluency.Tag = (int)totalFluency;
            lblResCompleteness.Text = $"Total Completness: {(int)totalCompleteness / questionsCounter}%";
            //lblResCompleteness.Tag = (int)totalCompleteness;

            List<Label> labels = new List<Label> { lblResPronunciation, lblResAccuracy, lblResFluency, lblResCompleteness };

            foreach (var label in labels)
            {
                if (grade >= 90)
                {
                    lblResMessage.Text = "You're... too good...";
                    lblResMessage.ForeColor = AccentBlue;
                    label.ForeColor = AccentBlue;
                    label.BackColor = ColorTranslator.FromHtml("#DCEEFF");
                }
                else if (grade >= 80)
                {
                    lblResMessage.Text = "That's pretty good!";
                    lblResMessage.ForeColor = gradeColor1Front;
                    label.ForeColor = gradeColor1Front;
                    label.BackColor = gradeColor1Back;
                }
                else if (grade >= 70)
                {
                    lblResMessage.Text = "Not bad, just needs a little more practice!";
                    lblResMessage.ForeColor = gradeColor2Front;
                    label.ForeColor = gradeColor2Front;
                    label.BackColor = gradeColor2Back;
                }
                else if (grade >= 60)
                {
                    lblResMessage.Text = "Practice makes perfect!";
                    lblResMessage.ForeColor = gradeColor3Front;
                    label.ForeColor = gradeColor3Front;
                    label.BackColor = gradeColor3Back;
                }
                else
                {
                    lblResMessage.Text = "Let's do some more studying!";
                    lblResMessage.ForeColor = AccentRed;
                    label.ForeColor = AccentRed;
                    label.BackColor = ColorTranslator.FromHtml("#FADADA");
                }




                lblSentenceKor.Visible = false;
                lblSentenceEng.Visible = false;
                lblSentencePron.Visible = false;
                gbStats.Visible = false;
                btnRecord.Visible = false;
                lblPronunciation.Visible = false;
                btnFinish.Visible = false;
                btnNext.Visible = false;

                lblQuestionCounter.Visible = true;
                lblResPronunciation.Visible = true;
                lblResMessage.Visible = true;
                btnClose2.Visible = true;
                gbResults.Visible = true;
                lblResMessage.Visible = true;
            }
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            practiceForm.Show();
            this.Close();
        }
    }
}