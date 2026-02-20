namespace KLLA
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitleK = new Label();
            lblTitleSub = new Label();
            btnPractice = new Button();
            btnDictionary = new Button();
            btnExit = new Button();
            panelHeader = new Panel();
            btnClose = new Button();
            btnMax = new Button();
            btnMin = new Button();
            lblTitleL = new Label();
            lblTitleL2 = new Label();
            lblTitleA = new Label();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleK
            // 
            lblTitleK.Font = new Font("Gill Sans MT Ext Condensed Bold", 80F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleK.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitleK.Location = new Point(282, 87);
            lblTitleK.Name = "lblTitleK";
            lblTitleK.Size = new Size(86, 192);
            lblTitleK.TabIndex = 0;
            lblTitleK.Text = "K";
            lblTitleK.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleSub
            // 
            lblTitleSub.Font = new Font("Gill Sans MT Ext Condensed Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleSub.ForeColor = Color.RoyalBlue;
            lblTitleSub.Location = new Point(85, 260);
            lblTitleSub.Name = "lblTitleSub";
            lblTitleSub.Size = new Size(655, 91);
            lblTitleSub.TabIndex = 1;
            lblTitleSub.Text = "K O R E A N  L A N G U A G E  L E A R N I N G  A P P";
            lblTitleSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPractice
            // 
            btnPractice.FlatAppearance.BorderSize = 0;
            btnPractice.FlatStyle = FlatStyle.Flat;
            btnPractice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPractice.ForeColor = Color.White;
            btnPractice.Location = new Point(317, 354);
            btnPractice.Name = "btnPractice";
            btnPractice.Size = new Size(178, 52);
            btnPractice.TabIndex = 2;
            btnPractice.Text = "Practice";
            btnPractice.UseVisualStyleBackColor = true;
            btnPractice.Click += btnPractice_Click;
            // 
            // btnDictionary
            // 
            btnDictionary.FlatAppearance.BorderSize = 0;
            btnDictionary.FlatStyle = FlatStyle.Flat;
            btnDictionary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDictionary.ForeColor = Color.White;
            btnDictionary.Location = new Point(317, 430);
            btnDictionary.Name = "btnDictionary";
            btnDictionary.Size = new Size(178, 52);
            btnDictionary.TabIndex = 3;
            btnDictionary.Text = "Dictionary";
            btnDictionary.UseVisualStyleBackColor = true;
            btnDictionary.Click += btnDictionary_Click;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(317, 506);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(178, 52);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
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
            panelHeader.TabIndex = 5;
            panelHeader.MouseDown += panelHeader_MouseDown;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
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
            btnMax.ForeColor = Color.White;
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
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(640, 11);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(47, 34);
            btnMin.TabIndex = 0;
            btnMin.Text = "−";
            btnMin.UseVisualStyleBackColor = true;
            // 
            // lblTitleL
            // 
            lblTitleL.Font = new Font("Gill Sans MT Ext Condensed Bold", 80F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleL.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitleL.Location = new Point(340, 87);
            lblTitleL.Name = "lblTitleL";
            lblTitleL.Size = new Size(86, 192);
            lblTitleL.TabIndex = 6;
            lblTitleL.Text = "L";
            lblTitleL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleL2
            // 
            lblTitleL2.Font = new Font("Gill Sans MT Ext Condensed Bold", 80F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleL2.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitleL2.Location = new Point(393, 87);
            lblTitleL2.Name = "lblTitleL2";
            lblTitleL2.Size = new Size(86, 192);
            lblTitleL2.TabIndex = 7;
            lblTitleL2.Text = "L";
            lblTitleL2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleA
            // 
            lblTitleA.Font = new Font("Gill Sans MT Ext Condensed Bold", 80F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleA.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitleA.Location = new Point(450, 87);
            lblTitleA.Name = "lblTitleA";
            lblTitleA.Size = new Size(86, 192);
            lblTitleA.TabIndex = 8;
            lblTitleA.Text = "A";
            lblTitleA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(786, 584);
            Controls.Add(lblTitleA);
            Controls.Add(lblTitleL2);
            Controls.Add(lblTitleL);
            Controls.Add(panelHeader);
            Controls.Add(btnExit);
            Controls.Add(btnDictionary);
            Controls.Add(btnPractice);
            Controls.Add(lblTitleSub);
            Controls.Add(lblTitleK);
            Name = "MainForm";
            Text = "KLLA";
            Load += MainForm_Load;
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitleK;
        private Label lblTitleSub;
        private Button btnPractice;
        private Button btnDictionary;
        private Button btnExit;
        private Panel panelHeader;
        private Button btnMin;
        private Button btnClose;
        private Button btnMax;
        private Label lblTitleL;
        private Label lblTitleL2;
        private Label lblTitleA;
    }
}