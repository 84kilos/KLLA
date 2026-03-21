using System;
using System.Windows.Forms;

namespace KLLA
{
    public partial class PracticeForm : BaseForm
    {
        private readonly Form mainForm;

        int mode = -1;

        public PracticeForm(Form mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            // Wire standard window buttons
            WireWindowButtons(btnClose, btnMin, btnMax);

            // Make header draggable
            EnableDraggableHeader(panelHeader);

            // ============= REWIRE CLOSE AND RETURN BUTTON TO RETURN TO MAIN =============
            btnClose.Click += (_, _) =>
            {
                mainForm.Show();
                this.Close();
            };
            btnReturn.Click += (_, _) =>
            {
                mainForm.Show();
                this.Close();
            };

            // Apply rounded corners to form and main buttons when shown
            this.Shown += (s, e) =>
            {
                ApplyRoundedRegion(this, 20);
                ApplyRoundedRegion(btnClose, 15);
                ApplyRoundedRegion(btnReturn, 15);
                ApplyRoundedRegion(btnMin, 15);
                ApplyRoundedRegion(btnMax, 15);
                ApplyRoundedRegion(btnDef, 20);
                ApplyRoundedRegion(btnSen, 20);
                ApplyRoundedRegion(lblInstruction, 20);
                ApplyRoundedRegion(btnBegin, 20);
            };
        }

        // Placeholder for future load logic
        private void PracticeForm_Load(object sender, EventArgs e)
        {
            lblTitleKor.ForeColor = RTBGradient2;
            // Add initialization code here
        }

        private void btnDef_Click(object sender, EventArgs e)
        {
            btnDef.BackColor = RTBGradient2;
            btnDef.ForeColor = Color.White;
            btnSen.BackColor = Color.WhiteSmoke;
            btnSen.ForeColor = Color.Black;
            lblInstruction.Text = "You will be given a Korean word and multiple English definitions. Try to choose the correct one!";
            lblInstruction.ForeColor = RTBGradient2;
            lblInstruction.BackColor = ColorTranslator.FromHtml("#ccbecf");
            mode = 0;
        }
        private void btnSen_Click(object sender, EventArgs e)
        {
            btnSen.BackColor = RTBGradient2;
            btnSen.ForeColor = Color.White;
            btnDef.BackColor = Color.WhiteSmoke;
            btnDef.ForeColor = Color.Black;
            lblInstruction.Text = "You will be given a full Korean sentence and it's English translation. Try your best to speak Korean!";
            lblInstruction.ForeColor = RTBGradient2;
            lblInstruction.BackColor = ColorTranslator.FromHtml("#ccbecf");
            mode = 1;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                var defPracticeForm = new DefModeForm(this);
                defPracticeForm.Show();
                this.Hide();
            }
            else if (mode == 1)
            {
                var defPracticeForm = new Form1(this);
                defPracticeForm.Show();
                this.Hide();
            }
            else
            {
                lblInstruction.Text = "Please select a mode first!";
                lblInstruction.ForeColor = AccentRed;
                lblInstruction.BackColor = ColorTranslator.FromHtml("#FADADA");
            }
        }


        // ============= HOVER EFFECTS FOR WORD LABELS =============
        private void btnBegin_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = RTBGradient2;
            ((Button)sender).ForeColor = Color.White;
        }

        private void btnBegin_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.WhiteSmoke;
            ((Button)sender).ForeColor = Color.Black;
        }

    }
}