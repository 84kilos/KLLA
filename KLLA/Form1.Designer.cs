namespace KLLA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            learnWordB = new Button();
            learnMicCB = new CheckBox();
            learnWordLBL = new Label();
            learnDefLBL = new Label();
            learnPronounceLBL = new Label();
            panelHeader = new Panel();
            btnClose = new Button();
            btnMax = new Button();
            btnMin = new Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // learnWordB
            // 
            learnWordB.FlatStyle = FlatStyle.Flat;
            learnWordB.ForeColor = Color.Black;
            learnWordB.Location = new Point(214, 412);
            learnWordB.Name = "learnWordB";
            learnWordB.Size = new Size(112, 34);
            learnWordB.TabIndex = 0;
            learnWordB.Text = "Learn Word";
            learnWordB.UseVisualStyleBackColor = true;
            learnWordB.Click += learnWordB_Click;
            // 
            // learnMicCB
            // 
            learnMicCB.AutoSize = true;
            learnMicCB.ForeColor = Color.Black;
            learnMicCB.Location = new Point(214, 377);
            learnMicCB.Name = "learnMicCB";
            learnMicCB.Size = new Size(134, 29);
            learnMicCB.TabIndex = 1;
            learnMicCB.Text = "Microphone";
            learnMicCB.UseVisualStyleBackColor = true;
            learnMicCB.CheckedChanged += learnMicCB_CheckedChanged;
            // 
            // learnWordLBL
            // 
            learnWordLBL.AutoSize = true;
            learnWordLBL.ForeColor = Color.Black;
            learnWordLBL.Location = new Point(42, 149);
            learnWordLBL.Name = "learnWordLBL";
            learnWordLBL.Size = new Size(106, 25);
            learnWordLBL.TabIndex = 2;
            learnWordLBL.Text = "KOR WORD";
            // 
            // learnDefLBL
            // 
            learnDefLBL.AutoSize = true;
            learnDefLBL.ForeColor = Color.Black;
            learnDefLBL.Location = new Point(42, 188);
            learnDefLBL.Name = "learnDefLBL";
            learnDefLBL.Size = new Size(73, 25);
            learnDefLBL.TabIndex = 3;
            learnDefLBL.Text = "Eng def";
            // 
            // learnPronounceLBL
            // 
            learnPronounceLBL.AutoSize = true;
            learnPronounceLBL.ForeColor = Color.Black;
            learnPronounceLBL.Location = new Point(241, 149);
            learnPronounceLBL.Name = "learnPronounceLBL";
            learnPronounceLBL.Size = new Size(121, 25);
            learnPronounceLBL.TabIndex = 4;
            learnPronounceLBL.Text = "Pronunciation";
            learnPronounceLBL.Click += learnPronounceLBL_Click;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(btnClose);
            panelHeader.Controls.Add(btnMax);
            panelHeader.Controls.Add(btnMin);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(786, 48);
            panelHeader.TabIndex = 6;
            panelHeader.MouseDown += panelHeader_MouseDown;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(727, 11);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 34);
            btnClose.TabIndex = 2;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.ForeColor = Color.Black;
            btnMax.Location = new Point(683, 11);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(47, 34);
            btnMax.TabIndex = 1;
            btnMax.Text = "☐";
            btnMax.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.ForeColor = Color.Black;
            btnMin.Location = new Point(640, 11);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(47, 34);
            btnMin.TabIndex = 0;
            btnMin.Text = "−";
            btnMin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(786, 744);
            Controls.Add(panelHeader);
            Controls.Add(learnPronounceLBL);
            Controls.Add(learnDefLBL);
            Controls.Add(learnWordLBL);
            Controls.Add(learnMicCB);
            Controls.Add(learnWordB);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "KLLA";
            Load += Form1_Load;
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button learnWordB;
        private CheckBox learnMicCB;
        private Label learnWordLBL;
        private Label learnDefLBL;
        private Label learnPronounceLBL;
        private Panel panelHeader;
        private Button btnClose;
        private Button btnMax;
        private Button btnMin;
    }
}
