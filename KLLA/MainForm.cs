using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KLLA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = ColorTranslator.FromHtml("#F5F6FA");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblTitle.ForeColor = ColorTranslator.FromHtml("#C60C30");
            lblTitleSub.ForeColor = ColorTranslator.FromHtml("#003478");
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            var practiceForm = new Form1();
            practiceForm.Show();

            //hides main page (optional)
            //this.Hide();
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            var DictionaryForm = new DictionaryForm();
            DictionaryForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
