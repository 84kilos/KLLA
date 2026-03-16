using Supabase;
using System;
using System.Linq;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.CognitiveServices.Speech;

namespace KLLA
{
    public partial class DictionaryForm : BaseForm
    {
        // ============= SUPABASE SETUP =============
        private KllaDB db = new KllaDB();

        private readonly Form mainForm;

        List<KoreanVocabulary> words;
        List<KoreanVocabulary> filteredWords;
        int wordId = 0;
        int MAXPAGESIZE = 4;

        private const string AZURE_KEY = "AZLLB8UpSxw6iKhjpMIG3FP7BGPcxyArQ6P3wP1XNunBNUhHdEdKJQQJ99CBACYeBjFXJ3w3AAAYACOGISoR"; // [2]
        private const string AZURE_REGION = "eastus"; // [3]


        public DictionaryForm(Form mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            // ============= WIRE CUSTOM WINDOW BORDER BUTTONS AND PANEL =============
            WireWindowButtons(btnClose, btnMin, btnMax);
            EnableDraggableHeader(panelHeader);

            // ============= REWIRE CLOSE BUTTON TO RETURN TO MAIN =============
            btnClose.Click += (_, _) =>
            {
                mainForm.Show();
                this.Close();
            };

            // ============= WIRE HOVER EFFECTS FOR WORD LABELS =============
            Label[] labels = { lblWord0, lblWord1, lblWord2, lblWord3 };

            foreach (var lbl in labels)
            {
                lbl.MouseEnter += WordLabel_MouseEnter;
                lbl.MouseLeave += WordLabel_MouseLeave;
            }

            // ============= WIRE PLAY BUTTONS TO SHARED CLICK HANDLER =============
            btnPlay0.Click += btnPlay_Click;
            btnPlay1.Click += btnPlay_Click;
            btnPlay2.Click += btnPlay_Click;
            btnPlay3.Click += btnPlay_Click;

            // ============= APPLY ROUNDED CORNERS WHEN FORM IS SHOWN =============
            this.Shown += (s, e) =>
            {
                ApplyRoundedRegion(this, 30);
                ApplyRoundedRegion(btnMin, 15);
                ApplyRoundedRegion(btnMax, 15);
                ApplyRoundedRegion(btnClose, 15);
                ApplyRoundedRegion(tbSearch, 20);
                //ApplyRoundedRegion(gbDictionary, 20);
                ApplyRoundedRegion(lblWord0, 20);
                ApplyRoundedRegion(lblWord1, 20);
                ApplyRoundedRegion(lblWord2, 20);
                ApplyRoundedRegion(lblWord3, 20);
                ApplyRoundedRegion(btnPlay0, 20);
                ApplyRoundedRegion(btnPlay1, 20);
                ApplyRoundedRegion(btnPlay2, 20);
                ApplyRoundedRegion(btnPlay3, 20);
                ApplyRoundedRegion(btnBack, 20);
                ApplyRoundedRegion(btnNext, 20);

                //lblTitleEng.ForeColor = KoreaRed;
                lblTitleKor1.ForeColor = ColorTranslator.FromHtml("#6978C7");
                lblTitleKor1.Text = "사";
                lblTitleKor2.ForeColor = ColorTranslator.FromHtml("#6978C7");
                lblTitleKor2.Text = "전";

                tbSearch.BackColor = ColorTranslator.FromHtml("#6978C7");


            };
        }

        //============ REUSABLE LOAD FUNCTION FOR LISTBOXES ============
        private void LoadPage()
        {
            //get listboxes to reference in loop
            Label[] boxes = { lblWord0, lblWord1, lblWord2, lblWord3 };
            for (int i = 0; i < boxes.Length; i++)
            {
                int wordIndex = wordId + i;
                if (wordIndex < filteredWords.Count)
                {
                    var word = filteredWords[wordIndex];
                    boxes[i].Text = $"{word.KoreanWord}\n{word.Romanization}\n{word.EnglishTranslation}";
                }
                else
                {
                    boxes[i].Text = "";
                }
            }
        }

        // ============= LOAD DICTIONARY DATA ON FORM LOAD =============
        private async void DictionaryForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Connect to database and load word lists
                await db.Connect_Database();
                words = db.GetAllWords();
                filteredWords = words;

                //Populate the first page of listboxes
                LoadPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database load failed. Looks like our database is down.");
            }
        }

        // ============= SEARCH FUNCTIONALITY =============
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // filter words based on search query
            string query = tbSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(query))        //if query empty, no filter

            {
                filteredWords = words;
            }
            else                                    //else filter based on english translation
            {
                filteredWords = words
                    .Where(w => w.EnglishTranslation.ToLower().Contains(query))
                    .ToList();
            }
            // reset to first page
            wordId = 0;
            LoadPage();
        }

        // ============= TEXT-TO-SPEECH FUNCTIONALITY =============
        private async void btnPlay_Click(object sender, EventArgs e)
        {
            //setup azure tts synthesizer
            var speechConfig = SpeechConfig.FromSubscription(AZURE_KEY, AZURE_REGION);
            using var synthesizer = new SpeechSynthesizer(speechConfig);

            // determine which button was clicked and get corresponding Korean word
            Button btn = sender as Button;

            // arrays to reference labels and buttons by index
            Label[] labels = { lblWord0, lblWord1, lblWord2, lblWord3 };
            Button[] buttons = { btnPlay0, btnPlay1, btnPlay2, btnPlay3 };

            // find index of clicked button to get corresponding label
            int index = Array.IndexOf(buttons, btn);
            if (index >= 0)
            {
                string korWord = labels[index].Text.Split('\n')[0];
                await synthesizer.SpeakTextAsync(korWord);
            }
        }

        // ============= PAGINATION BUTTONS =============
        private void btnNext_Click(object sender, EventArgs e)
        {
            // calculate starting index of next page
            int newPageStart = wordId + MAXPAGESIZE;
            if (newPageStart >= filteredWords.Count)
                return;

            wordId = newPageStart;
            LoadPage();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // calculate starting index of previous page
            wordId -= MAXPAGESIZE;
            if (wordId < 0) wordId = 0;

            LoadPage();
        }

        // ============= HOVER EFFECTS FOR WORD LABELS =============
        private void WordLabel_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Gainsboro;
        }

        private void WordLabel_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.WhiteSmoke;
        }
    }
}