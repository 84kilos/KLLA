using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;



namespace KLLA
{
    public partial class MainForm : Form
    {
        //========== COLORS ===========
        string koreaRed = "#C60C30";
        string koreaBlue =  "#003478";
        string accentRed = "#D64545";
        string accentBlue = "#1F4FD8";
        string darkBlue = "#031c45";
        string darkGray = "#2B2B2B";
        string offWhite = "#F5F6FA";


        public MainForm()
        {
            InitializeComponent();

            //=========== REMOVE DEFAULT FORM BORDER AND REPLACE WITH CUSTOM ==========
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = ColorTranslator.FromHtml(darkBlue);

            btnClose.Click += (_, _) => this.Close();

            btnMin.Click += (_, _) =>
                this.WindowState = FormWindowState.Minimized;

            btnMax.Click += (_, _) =>
            {
                this.WindowState =
                    this.WindowState == FormWindowState.Maximized
                    ? FormWindowState.Normal
                    : FormWindowState.Maximized;
            };

            //=========== MINIMALIST BUTTON DESIGNS FOR PRACTICE, DICTIONARY, AND EXIT =============
            btnPractice.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(koreaBlue);
            btnPractice.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(accentBlue);
            btnDictionary.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(koreaBlue);
            btnDictionary.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(accentBlue);
            btnExit.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(koreaBlue);
            btnExit.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(accentBlue);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //============ CUSTOM HEX COLOR AESTHETIC =================
            lblTitleK.ForeColor = ColorTranslator.FromHtml("#9E1A45");
            lblTitleL.ForeColor = ColorTranslator.FromHtml("#76295A");
            lblTitleL2.ForeColor = ColorTranslator.FromHtml("#4E376F");
            lblTitleA.ForeColor = ColorTranslator.FromHtml("#264684");
            lblTitleSub.ForeColor = ColorTranslator.FromHtml(accentBlue);
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            var practiceForm = new Form1(this);
            practiceForm.Show();
            this.Hide();
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            var DictionaryForm = new DictionaryForm(this);
            DictionaryForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //============= DRAGGABLE WINDOW FUNCTIONALITY =============

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(
            IntPtr hWnd, int msg, int wParam, int lParam
        );

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

    }
}
