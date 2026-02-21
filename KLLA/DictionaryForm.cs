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
using Supabase;

namespace KLLA
{
    public partial class DictionaryForm : Form
    {
        //========== COLORS ===========
        string koreaRed = "#C60C30";
        string koreaBlue = "#003478";
        string accentRed = "#D64545";
        string accentBlue = "#1F4FD8";
        string darkBlue = "#031c45";
        string darkGray = "#2B2B2B";
        string offWhite = "#F5F6FA";

        public DictionaryForm(Form MainForm)
        {

            InitializeComponent();

            //=========== REMOVE DEFAULT FORM BORDER AND REPLACE WITH CUSTOM ==========
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = ColorTranslator.FromHtml(darkBlue);

            //------------ Unhide main form, close --------------
            btnClose.Click += (_, _) =>
            {
                MainForm.Show();
                this.Close();
            };
            //------------ Minimize button --------------
            btnMin.Click += (_, _) =>
                this.WindowState = FormWindowState.Minimized;
            //------------ Maximize/Normal Size --------------
            btnMax.Click += (_, _) =>
            {
                this.WindowState =
                    this.WindowState == FormWindowState.Maximized
                    ? FormWindowState.Normal
                    : FormWindowState.Maximized;
            };
        }

        private void DictionaryForm_Load(object sender, EventArgs e)
        {
            
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
