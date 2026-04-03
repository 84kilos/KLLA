namespace KLLA
{
    partial class PracticeForm
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
            panelHeader = new Panel();
            btnReturn = new Button();
            btnClose = new Button();
            btnMax = new Button();
            btnMin = new Button();
            lblTitle = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnBegin = new Button();
            lblTitleKor = new Label();
            lblInstruction = new Label();
            btnSen = new Button();
            btnDef = new Button();
            gbTheme = new GroupBox();
            btnTheme4 = new Button();
            btnTheme3 = new Button();
            btnTheme2 = new Button();
            btnTheme1 = new Button();
            btnTheme0 = new Button();
            panelHeader.SuspendLayout();
            gbTheme.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(btnReturn);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Controls.Add(btnMax);
            panelHeader.Controls.Add(btnMin);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(786, 48);
            panelHeader.TabIndex = 8;
            // 
            // btnReturn
            // 
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.Black;
            btnReturn.Location = new Point(12, 11);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(47, 34);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "←";
            btnReturn.UseVisualStyleBackColor = true;
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
            btnMax.Location = new Point(674, 11);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(47, 34);
            btnMax.TabIndex = 1;
            btnMax.Text = "☐";
            btnMax.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.CausesValidation = false;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.ForeColor = Color.Black;
            btnMin.Location = new Point(621, 11);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(47, 34);
            btnMin.TabIndex = 0;
            btnMin.Text = "−";
            btnMin.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(167, 62);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(287, 96);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Practice";
            // 
            // btnBegin
            // 
            btnBegin.BackColor = Color.WhiteSmoke;
            btnBegin.FlatAppearance.BorderSize = 0;
            btnBegin.FlatStyle = FlatStyle.Flat;
            btnBegin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBegin.ForeColor = Color.Black;
            btnBegin.Location = new Point(313, 383);
            btnBegin.Name = "btnBegin";
            btnBegin.Size = new Size(155, 48);
            btnBegin.TabIndex = 18;
            btnBegin.Text = "Begin Practice";
            btnBegin.UseVisualStyleBackColor = false;
            btnBegin.Click += btnBegin_Click;
            btnBegin.MouseEnter += btnBegin_MouseEnter;
            btnBegin.MouseLeave += btnBegin_MouseLeave;
            // 
            // lblTitleKor
            // 
            lblTitleKor.AutoSize = true;
            lblTitleKor.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleKor.Location = new Point(437, 62);
            lblTitleKor.Name = "lblTitleKor";
            lblTitleKor.Size = new Size(184, 96);
            lblTitleKor.TabIndex = 20;
            lblTitleKor.Text = "관행";
            // 
            // lblInstruction
            // 
            lblInstruction.BackColor = Color.White;
            lblInstruction.Location = new Point(59, 443);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(662, 65);
            lblInstruction.TabIndex = 23;
            lblInstruction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSen
            // 
            btnSen.BackColor = Color.WhiteSmoke;
            btnSen.FlatAppearance.BorderSize = 0;
            btnSen.FlatStyle = FlatStyle.Flat;
            btnSen.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSen.ForeColor = Color.Black;
            btnSen.Location = new Point(215, 274);
            btnSen.Name = "btnSen";
            btnSen.Size = new Size(357, 87);
            btnSen.TabIndex = 24;
            btnSen.Text = "Sentence Mode";
            btnSen.UseVisualStyleBackColor = false;
            btnSen.Click += btnSen_Click;
            // 
            // btnDef
            // 
            btnDef.BackColor = Color.WhiteSmoke;
            btnDef.FlatAppearance.BorderSize = 0;
            btnDef.FlatStyle = FlatStyle.Flat;
            btnDef.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDef.ForeColor = Color.Black;
            btnDef.Location = new Point(215, 161);
            btnDef.Name = "btnDef";
            btnDef.Size = new Size(357, 87);
            btnDef.TabIndex = 25;
            btnDef.Text = "Definition Mode";
            btnDef.UseVisualStyleBackColor = false;
            btnDef.Click += btnDef_Click;
            // 
            // gbTheme
            // 
            gbTheme.Controls.Add(btnTheme4);
            gbTheme.Controls.Add(btnTheme3);
            gbTheme.Controls.Add(btnTheme2);
            gbTheme.Controls.Add(btnTheme1);
            gbTheme.Controls.Add(btnTheme0);
            gbTheme.Location = new Point(12, 514);
            gbTheme.Name = "gbTheme";
            gbTheme.Size = new Size(762, 89);
            gbTheme.TabIndex = 26;
            gbTheme.TabStop = false;
            // 
            // btnTheme4
            // 
            btnTheme4.BackColor = Color.WhiteSmoke;
            btnTheme4.FlatAppearance.BorderSize = 0;
            btnTheme4.FlatStyle = FlatStyle.Flat;
            btnTheme4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTheme4.ForeColor = Color.Black;
            btnTheme4.Location = new Point(605, 25);
            btnTheme4.Name = "btnTheme4";
            btnTheme4.Size = new Size(141, 48);
            btnTheme4.TabIndex = 31;
            btnTheme4.Text = "Directions";
            btnTheme4.UseVisualStyleBackColor = false;
            // 
            // btnTheme3
            // 
            btnTheme3.BackColor = Color.WhiteSmoke;
            btnTheme3.FlatAppearance.BorderSize = 0;
            btnTheme3.FlatStyle = FlatStyle.Flat;
            btnTheme3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTheme3.ForeColor = Color.Black;
            btnTheme3.Location = new Point(458, 25);
            btnTheme3.Name = "btnTheme3";
            btnTheme3.Size = new Size(141, 48);
            btnTheme3.TabIndex = 30;
            btnTheme3.Text = "Work";
            btnTheme3.UseVisualStyleBackColor = false;
            // 
            // btnTheme2
            // 
            btnTheme2.BackColor = Color.WhiteSmoke;
            btnTheme2.FlatAppearance.BorderSize = 0;
            btnTheme2.FlatStyle = FlatStyle.Flat;
            btnTheme2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTheme2.ForeColor = Color.Black;
            btnTheme2.Location = new Point(311, 25);
            btnTheme2.Name = "btnTheme2";
            btnTheme2.Size = new Size(141, 48);
            btnTheme2.TabIndex = 29;
            btnTheme2.Text = "Ordering";
            btnTheme2.UseVisualStyleBackColor = false;
            // 
            // btnTheme1
            // 
            btnTheme1.BackColor = Color.WhiteSmoke;
            btnTheme1.FlatAppearance.BorderSize = 0;
            btnTheme1.FlatStyle = FlatStyle.Flat;
            btnTheme1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTheme1.ForeColor = Color.Black;
            btnTheme1.Location = new Point(164, 25);
            btnTheme1.Name = "btnTheme1";
            btnTheme1.Size = new Size(141, 48);
            btnTheme1.TabIndex = 28;
            btnTheme1.Text = "Introductions";
            btnTheme1.UseVisualStyleBackColor = false;
            // 
            // btnTheme0
            // 
            btnTheme0.BackColor = Color.WhiteSmoke;
            btnTheme0.FlatAppearance.BorderSize = 0;
            btnTheme0.FlatStyle = FlatStyle.Flat;
            btnTheme0.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTheme0.ForeColor = Color.Black;
            btnTheme0.Location = new Point(17, 25);
            btnTheme0.Name = "btnTheme0";
            btnTheme0.Size = new Size(141, 48);
            btnTheme0.TabIndex = 27;
            btnTheme0.Text = "Common";
            btnTheme0.UseVisualStyleBackColor = false;
            // 
            // PracticeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(786, 615);
            Controls.Add(gbTheme);
            Controls.Add(btnDef);
            Controls.Add(btnSen);
            Controls.Add(lblInstruction);
            Controls.Add(lblTitleKor);
            Controls.Add(btnBegin);
            Controls.Add(lblTitle);
            Controls.Add(panelHeader);
            Name = "PracticeForm";
            Load += PracticeForm_Load;
            panelHeader.ResumeLayout(false);
            gbTheme.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Button btnClose;
        private Button btnMax;
        private Button btnMin;
        private Label lblTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnBegin;
        private Label lblTitleKor;
        private Button btnReturn;
        private Label lblInstruction;
        private Button btnSen;
        private Button btnDef;
        private GroupBox gbTheme;
        private Button btnTheme4;
        private Button btnTheme3;
        private Button btnTheme2;
        private Button btnTheme1;
        private Button btnTheme0;
    }
}