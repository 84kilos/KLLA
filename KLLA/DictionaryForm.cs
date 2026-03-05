using Supabase;
using System;
using System.Windows.Forms;

namespace KLLA
{
    public partial class DictionaryForm : BaseForm
    {
        // ============= SUPABASE SETUP =============
        private KllaDB db = new KllaDB();

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
            try
            {
                await db.Connect_Database();

                var words = db.GetAllWords();

                listBox1.Items.Clear();

                foreach (var word in words)
                {
                    if (!string.IsNullOrWhiteSpace(word.KoreanWord))
                        listBox1.Items.Add(word.KoreanWord);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database load failed: " + ex.Message);
            }
        }
    }
}