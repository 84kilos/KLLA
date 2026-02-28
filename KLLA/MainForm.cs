using System;
using System.Drawing;
using System.Windows.Forms;

namespace KLLA
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();

            // ============= WIRE CUSTOM WINDOW BORDER BUTTONS AND PANEL =============
            WireWindowButtons(btnClose, btnMin, btnMax);
            EnableDraggableHeader(panelHeader);

            // ============= APPLY ROUNDED CORNERS WHEN FORM IS SHOWN =============
            this.Shown += (s, e) =>
            {
                ApplyRoundedRegion(this, 30); 
                ApplyRoundedRegion(btnPractice, 30);
                ApplyRoundedRegion(btnDictionary, 30);
                ApplyRoundedRegion(btnExit, 30);
                ApplyRoundedRegion(btnMin, 15);
                ApplyRoundedRegion(btnMax, 15);
                ApplyRoundedRegion(btnClose, 15);
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ============= SET PRETTY TITLE COLORS =============
            lblTitleK.ForeColor = ColorTranslator.FromHtml("#A12259");
            lblTitleL.ForeColor = ColorTranslator.FromHtml("#854D90");
            lblTitleL2.ForeColor = ColorTranslator.FromHtml("#6978C7");
            lblTitleA.ForeColor = ColorTranslator.FromHtml("#4DA3FF");
            lblTitleSub.ForeColor = AccentBlue;
        }

        // ============= BUTTON CLICK EVENTS =============
        private void btnPractice_Click(object sender, EventArgs e)
        {
            var practiceForm = new PracticeForm(this);
            practiceForm.Show();
            this.Hide();
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            var dictionaryForm = new DictionaryForm(this);
            dictionaryForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}