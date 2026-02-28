using System;
using System.Windows.Forms;

namespace KLLA
{
    public partial class PracticeForm : BaseForm
    {
        private readonly Form mainForm;

        public PracticeForm(Form mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            // Wire standard window buttons
            WireWindowButtons(btnClose, btnMin, btnMax);

            // Make header draggable
            EnableDraggableHeader(panelHeader);

            // btnClose returns to main form
            btnClose.Click += (_, _) =>
            {
                mainForm.Show();
                this.Close();
            };

            // Apply rounded corners to form and main buttons when shown
            this.Shown += (s, e) =>
            {
                ApplyRoundedRegion(this, 20);
                ApplyRoundedRegion(btnClose, 15);
                ApplyRoundedRegion(btnMin, 15);
                ApplyRoundedRegion(btnMax, 15);
            };
        }

        // Placeholder for future load logic
        private void PracticeForm_Load(object sender, EventArgs e)
        {
            // Add initialization code here
        }
    }
}