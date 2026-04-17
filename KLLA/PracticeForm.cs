using System;
using System.Windows.Forms;

namespace KLLA
{
    public partial class PracticeForm : BaseForm
    {
        private readonly Form mainForm;

        int mode = -1;
        string theme = "";

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

            // Wire theme buttons to shared click handlers
            btnTheme0.Click += btnTheme_Click;
            btnTheme1.Click += btnTheme_Click;
            btnTheme2.Click += btnTheme_Click;
            btnTheme3.Click += btnTheme_Click;
            btnTheme4.Click += btnTheme_Click;

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
                ApplyRoundedRegion(btnTheme0, 20);
                ApplyRoundedRegion(btnTheme1, 20);
                ApplyRoundedRegion(btnTheme2, 20);
                ApplyRoundedRegion(btnTheme3, 20);
                ApplyRoundedRegion(btnTheme4, 20);
                ApplyRoundedRegion(lblInstruction, 20);
                ApplyRoundedRegion(btnBegin, 20);
            };
        }

        // Placeholder for future load logic
        private void PracticeForm_Load(object sender, EventArgs e)
        {

            gbTheme.Visible = false;
            lblTitleKor.ForeColor = RTBGradient2;
            
        }

        // Shared click handler for exclusive theme buttons
        private void btnTheme_Click(object sender, EventArgs e)
        {
            Button[] buttons = { btnTheme0, btnTheme1, btnTheme2, btnTheme3, btnTheme4};
            foreach (Button btn in buttons)
            {
                if (btn == sender)
                {
                    btn.BackColor = RTBGradient2;
                    btn.ForeColor = Color.White;
                    theme = btn.Text.ToLower();
                }
                else
                {
                    btn.BackColor = Color.WhiteSmoke;
                    btn.ForeColor = Color.Black;
                }
            }

        }

        // Two functions to handle the mode clicks
        private void btnDef_Click(object sender, EventArgs e)
        {
            gbTheme.Visible = false;

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
            gbTheme.Visible = true;

            btnSen.BackColor = RTBGradient2;
            btnSen.ForeColor = Color.White;
            btnDef.BackColor = Color.WhiteSmoke;
            btnDef.ForeColor = Color.Black;
            lblInstruction.Text = "You will be given a full Korean sentence and it's English translation. Try your best to speak Korean!";
            lblInstruction.ForeColor = RTBGradient2;
            lblInstruction.BackColor = ColorTranslator.FromHtml("#ccbecf");
            mode = 1;
        }

        // Begin button click to handle which form to open
        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                var DefMode = new DefModeForm(this);
                DefMode.Show();
                this.Hide();
            }
            else if (mode == 1)
            {
                if (string.IsNullOrEmpty(theme))
                {
                    lblInstruction.Text = "Please select a theme first!";
                    lblInstruction.ForeColor = AccentRed;
                    lblInstruction.BackColor = ColorTranslator.FromHtml("#FADADA");
                    return;
                }
                var SenMode = new SenModeForm(this, theme);
                SenMode.Show();
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