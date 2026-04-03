using Microsoft.CognitiveServices.Speech;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using static KLLA.Form1;

namespace KLLA
{
    public partial class DefModeForm : BaseForm
    {
        private readonly Form practiceForm;

        //database interaction
        private Random rand = new Random();
        private KllaDB db = new KllaDB();
        KoreanVocabulary currentWord;
        List<KoreanVocabulary> words;
        List<string> choices = new List<string>();


        //global stats for finish screen
        int questionsCounter = 0;
        int questionsRight = 0;
        int longestStreak = 0;
        int currentStreak = 0;
        public DefModeForm(Form practiceForm)
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
            btnComplete.Click += (_, _) =>
            {
                practiceForm.Show();
                this.Close();
            };

            //Wire answer choice buttons to shared click handler
            btnChoice0.Click += btnChoice_Click;
            btnChoice1.Click += btnChoice_Click;
            btnChoice2.Click += btnChoice_Click;
            btnChoice3.Click += btnChoice_Click;
            btnChoice4.Click += btnChoice_Click;
            btnChoice5.Click += btnChoice_Click;

            // Apply rounded corners to form and main buttons when shown
            this.Shown += (s, e) =>
            {
                ApplyRoundedRegion(this, 20);
                ApplyRoundedRegion(btnClose, 15);
                ApplyRoundedRegion(btnReturn, 15);
                ApplyRoundedRegion(btnMin, 15);
                ApplyRoundedRegion(btnMax, 15);
                ApplyRoundedRegion(btnChoice0, 20);
                ApplyRoundedRegion(btnChoice1, 20);
                ApplyRoundedRegion(btnChoice2, 20);
                ApplyRoundedRegion(btnChoice3, 20);
                ApplyRoundedRegion(btnChoice4, 20);
                ApplyRoundedRegion(btnChoice5, 20);
                ApplyRoundedRegion(btnNext, 20);
                ApplyRoundedRegion(btnFinish, 20);
                ApplyRoundedRegion(btnComplete, 20);
                ApplyRoundedRegion(lblResultQuestions, 20);
                ApplyRoundedRegion(lblResultStreak, 20);
            };
        }

        private void BtnComplete_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void DefModeForm_Load(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            btnFinish.Visible = false;
            btnComplete.Visible = false;
            lblResultQuestions.Visible = false;
            lblResultStreak.Visible = false;

            try
            {
                // Connect to database and load word lists
                await db.Connect_Database();
                words = db.GetVocabOnly();

                lblLoading.Visible = false;
                //Populate the first page of listboxes
                LoadWord();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database load failed. Looks like our database is down.");
            }
        }

        //============ HELPER FUNCTION TO RESET VISUAL INDICATORS ============
        private void ResetChoices()
        {
            Button[] buttons = { btnChoice0, btnChoice1, btnChoice2, btnChoice3, btnChoice4, btnChoice5 };
            foreach (Button btn in buttons)
            {
                btn.Enabled = true;
            }

            btnNext.Visible = false;
            btnFinish.Visible = false;

            choices.Clear();

            btnChoice0.BackColor = Color.WhiteSmoke;
            btnChoice1.BackColor = Color.WhiteSmoke;
            btnChoice2.BackColor = Color.WhiteSmoke;
            btnChoice3.BackColor = Color.WhiteSmoke;
            btnChoice4.BackColor = Color.WhiteSmoke;
            btnChoice5.BackColor = Color.WhiteSmoke;

            btnChoice0.ForeColor = Color.Black;
            btnChoice1.ForeColor = Color.Black;
            btnChoice2.ForeColor = Color.Black;
            btnChoice3.ForeColor = Color.Black;
            btnChoice4.ForeColor = Color.Black;
            btnChoice5.ForeColor = Color.Black;
        }

        //============ HELPER FUNCTION TO EDIT BUTTON AESTHETICS FOR VISUAL FEEDBACK ============
        private void changeButton(Button btn, bool result)
        {
            if (result)
            {
                btn.ForeColor = AccentBlue;
                btn.BackColor = ColorTranslator.FromHtml("#DCEEFF");
            }
            else
            {
                btn.ForeColor = AccentRed;
                btn.BackColor = ColorTranslator.FromHtml("#FADADA");
            }
        }

        //============ REUSABLE LOAD FUNCTION FOR ANSWER CHOICES ============
        private void LoadWord()
        {
            ResetChoices();

            //get random word for question
            currentWord = words[rand.Next(words.Count)];
            lblWordKor.Text = currentWord.KoreanWord;
            lblWordRom.Text = currentWord.Romanization;
            choices.Add(currentWord.EnglishTranslation);
            Button[] buttons = { btnChoice0, btnChoice1, btnChoice2, btnChoice3, btnChoice4, btnChoice5 };

            //populate choices list
            for (int i = 0; i < 5; i++)
            {
                string incorrectChoice;
                incorrectChoice = words[rand.Next(words.Count)].EnglishTranslation;
                while (choices.Contains(incorrectChoice))
                {
                    incorrectChoice = words[rand.Next(words.Count)].EnglishTranslation;
                }
                choices.Add(incorrectChoice);
            }

            //get listboxes to reference in loop
            foreach (Button btn in buttons)
            {
                int choiceIndex = rand.Next(choices.Count);
                btn.Text = choices[choiceIndex];
                choices.RemoveAt(choiceIndex);
            }
        }

        //============ SHARED ANSWER EVALUATION LOGIC FOR BUTTONS ============
        private void btnChoice_Click(object sender, EventArgs e)
        {
            Button[] buttons = { btnChoice0, btnChoice1, btnChoice2, btnChoice3, btnChoice4, btnChoice5 };
            Button clickedButton = sender as Button;
            questionsCounter++;

            if (clickedButton.Text == currentWord.EnglishTranslation)
            {
                CorrectSound();
                questionsRight++;
                changeButton(clickedButton, true);
                currentStreak++;
                if (currentStreak > longestStreak)
                {
                    longestStreak = currentStreak;
                }
            }
            else
            {
                IncorrectSound();
                changeButton(clickedButton, false);
                foreach (Button btn in buttons)
                {
                    if (btn.Text == currentWord.EnglishTranslation)
                    {
                        changeButton(btn, true);
                    }
                }
                currentStreak = 0;
            }

            foreach (Button btn in buttons)
            {
                btn.Enabled = false;
            }

            btnNext.Visible = true;
            btnFinish.Visible = true;
        }

        //============ TTS ON WORD CLICK ============
        private async void lblWordKor_Click(object sender, EventArgs e)
        {
            //TODO play sound
            //setup azure tts synthesizer
            var speechConfig = SpeechConfig.FromSubscription(AZURE_KEY, AZURE_REGION);
            using var synthesizer = new SpeechSynthesizer(speechConfig);
            speechConfig.SpeechSynthesisVoiceName = "ko-KR-SunHiNeural";

            var result = await synthesizer.SpeakTextAsync(currentWord.KoreanWord);

            if (result.Reason == ResultReason.Canceled)
            {
                var details = SpeechSynthesisCancellationDetails.FromResult(result);

                MessageBox.Show(
                    $"Reason: {details.Reason}\n" +
                    $"ErrorCode: {details.ErrorCode}\n" +
                    $"Details: {details.ErrorDetails}"
                );
            }
        }

        //============ NEXT QUESTION BTN ============
        private void btnNext_Click(object sender, EventArgs e)
        {
            LoadWord();
        }

        //============ HARDER QUESTION BTN (GETS HARDER QUESTION TODO) ============

        //============ FINISH BTN ============
        private void btnFinish_Click(object sender, EventArgs e)
        {
            float percentage = ((float)questionsRight / questionsCounter) * 100;
            lblWordKor.Text = $"{percentage:0.00}%";
            if (percentage == 100)
            {
                lblWordRom.Text = "Perfect score! You're a Korean vocabulary master!";
                lblWordKor.ForeColor = AccentBlue;
                lblWordRom.ForeColor = AccentBlue;
            }
            else if (percentage >= 80)
            {
                lblWordRom.Text = "Great job! You have a strong grasp of these words.";
                lblWordKor.ForeColor = AccentBlue;
            }
            else if (percentage >= 50)
            {
                lblWordRom.Text = "Not bad! Keep practicing to improve your score.";
                lblWordKor.ForeColor = RTBGradient3;
            }
            else
            {
                lblWordRom.Text = "Don't worry, keep practicing and you'll get there!";
                lblWordKor.ForeColor = RTBGradient2;
            }

            Button[] buttons = { btnChoice0, btnChoice1, btnChoice2, btnChoice3, btnChoice4, btnChoice5, btnFinish, btnNext };
            foreach (Button btn in buttons)
            {
                btn.Visible = false;
            }

            lblResultQuestions.Text = $"Question accuracy: {questionsRight}/{questionsCounter}";
            lblResultStreak.Text = $"Longest correct streak: {longestStreak}";

            lblResultQuestions.Visible = true;
            lblResultStreak.Visible = true;

            btnComplete.Visible = true;
        }
    }
}
