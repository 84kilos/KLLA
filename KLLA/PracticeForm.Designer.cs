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
            panelHeader.SuspendLayout();
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
            btnBegin.Location = new Point(321, 399);
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
            lblInstruction.Location = new Point(176, 476);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(454, 58);
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
            btnSen.Location = new Point(223, 290);
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
            btnDef.Location = new Point(223, 177);
            btnDef.Name = "btnDef";
            btnDef.Size = new Size(357, 87);
            btnDef.TabIndex = 25;
            btnDef.Text = "Definition Mode";
            btnDef.UseVisualStyleBackColor = false;
            btnDef.Click += btnDef_Click;
            // 
            // PracticeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(786, 575);
            Controls.Add(btnDef);
            Controls.Add(btnSen);
            Controls.Add(lblInstruction);
            Controls.Add(lblTitleKor);
            Controls.Add(btnBegin);
            Controls.Add(lblTitle);
            Controls.Add(panelHeader);
            Name = "PracticeForm";
            Text = "s";
            Load += PracticeForm_Load;
            panelHeader.ResumeLayout(false);
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
    }
}