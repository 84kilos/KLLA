using Supabase;
using System;
using System.Windows.Forms;

namespace KLLA
{
    public partial class DictionaryForm : BaseForm
    {
        // ============= SUPABASE SETUP =============
        private readonly string url = "https://cdfkpfjeflljhutuwrun.supabase.co/";
        private readonly string key = "sb_publishable_gnJ_0UWf-bYZ8_1J6Xgqxg_yRfU4ucY";
        private Supabase.Client sb;

        private readonly Form mainForm;

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

            // ============= Initialize Supabase Client =============
            sb = new Supabase.Client(url, key);
            _ = sb.InitializeAsync();

            // ============= APPLY ROUNDED CORNERS WHEN FORM IS SHOWN =============
            this.Shown += (s, e) =>
            {
                ApplyRoundedRegion(this, 30);
                ApplyRoundedRegion(btnMin, 15);
                ApplyRoundedRegion(btnMax, 15);
                ApplyRoundedRegion(btnClose, 15);
            };
        }

        private async void DictionaryForm_Load(object sender, EventArgs e)
        {
            // Add any specific load logic here
            try
            {
                // Ensure Supabase client is initialized
                if (sb == null) return;

                // Fetch all words from Supabase
                var words = await sb.From<Word>()
                                    .Select("*")
                                    .Get();

                // Clear ListBox first
                listBox1.Items.Clear();

                // Add each word's Korean text to the ListBox
                foreach (var word in words.Models)
                {
                    listBox1.Items.Add(word.KoreanWord);
                }

                // Optional: store the full list in a field for later reference
                //allWords = words.Models.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load words: {ex.Message}");
            }
        }
    }
}