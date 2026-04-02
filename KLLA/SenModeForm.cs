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
    public partial class SenModeForm : BaseForm
    {
        private readonly Form practiceForm;

        private Random rand = new Random();
        private KllaDB db = new KllaDB();

        public SenModeForm(Form practiceForm)
        {
            InitializeComponent();

            this.practiceForm = practiceForm;

            // Wire standard window buttons
            WireWindowButtons(btnClose, btnMin, btnMax);

            // Make header draggable
            EnableDraggableHeader(panelHeader);

            // ============= REWIRE CLOSE, RETURN, AND COMPLETE BUTTONS TO RETURN TO PRACTICE FORM =============
            btnClose.Click += (_, _) =>
            {
                practiceForm.Show();
                this.Close();
            };
            btnReturn.Click += (_, _) =>
            {
                practiceForm.Show();
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
            };
        }

        private void SenModeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
