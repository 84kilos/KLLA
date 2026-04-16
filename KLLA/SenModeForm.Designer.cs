namespace KLLA
{
    partial class SenModeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenModeForm));
            btnReturn = new Button();
            panelHeader = new Panel();
            btnClose = new Button();
            btnMax = new Button();
            btnMin = new Button();
            lblSentenceKor = new Label();
            btnFinish = new Button();
            btnNext = new Button();
            btnRecord = new Button();
            lblSentenceEng = new Label();
            gbStats = new GroupBox();
            lblCompleteness = new Label();
            lblFluency = new Label();
            lblAccuracy = new Label();
            lblPronunciation = new Label();
            lblSentencePron = new Label();
            panelHeader.SuspendLayout();
            gbStats.SuspendLayout();
            SuspendLayout();
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
            // panelHeader
            // 
            panelHeader.Controls.Add(btnReturn);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Controls.Add(btnMax);
            panelHeader.Controls.Add(btnMin);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 48);
            panelHeader.TabIndex = 9;
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
            // lblSentenceKor
            // 
            lblSentenceKor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSentenceKor.Location = new Point(0, 66);
            lblSentenceKor.Name = "lblSentenceKor";
            lblSentenceKor.Size = new Size(800, 78);
            lblSentenceKor.TabIndex = 11;
            lblSentenceKor.Text = "예시 단어";
            lblSentenceKor.TextAlign = ContentAlignment.MiddleCenter;
            lblSentenceKor.Click += lblSentenceKor_Click;
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.WhiteSmoke;
            btnFinish.FlatAppearance.BorderSize = 0;
            btnFinish.FlatStyle = FlatStyle.Flat;
            btnFinish.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinish.ForeColor = Color.Black;
            btnFinish.Location = new Point(69, 554);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(234, 57);
            btnFinish.TabIndex = 35;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.WhiteSmoke;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(503, 554);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(234, 57);
            btnNext.TabIndex = 34;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnRecord
            // 
            btnRecord.BackColor = Color.FromArgb(0, 192, 0);
            btnRecord.BackgroundImage = (Image)resources.GetObject("btnRecord.BackgroundImage");
            btnRecord.BackgroundImageLayout = ImageLayout.Stretch;
            btnRecord.FlatAppearance.BorderSize = 0;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecord.ForeColor = Color.Black;
            btnRecord.Location = new Point(278, 252);
            btnRecord.Name = "btnRecord";
            btnRecord.Padding = new Padding(10);
            btnRecord.Size = new Size(245, 246);
            btnRecord.TabIndex = 36;
            btnRecord.Text = "Next";
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // lblSentenceEng
            // 
            lblSentenceEng.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSentenceEng.ForeColor = SystemColors.WindowFrame;
            lblSentenceEng.Location = new Point(0, 128);
            lblSentenceEng.Name = "lblSentenceEng";
            lblSentenceEng.Size = new Size(800, 54);
            lblSentenceEng.TabIndex = 37;
            lblSentenceEng.Text = "English translation sentence";
            lblSentenceEng.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbStats
            // 
            gbStats.Controls.Add(lblCompleteness);
            gbStats.Controls.Add(lblFluency);
            gbStats.Controls.Add(lblAccuracy);
            gbStats.Location = new Point(24, 216);
            gbStats.Name = "gbStats";
            gbStats.Size = new Size(238, 304);
            gbStats.TabIndex = 38;
            gbStats.TabStop = false;
            // 
            // lblCompleteness
            // 
            lblCompleteness.BackColor = Color.WhiteSmoke;
            lblCompleteness.Font = new Font("Segoe UI", 11F);
            lblCompleteness.Location = new Point(6, 216);
            lblCompleteness.Name = "lblCompleteness";
            lblCompleteness.Size = new Size(226, 76);
            lblCompleteness.TabIndex = 2;
            lblCompleteness.Text = "Completeness: ";
            lblCompleteness.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFluency
            // 
            lblFluency.BackColor = Color.WhiteSmoke;
            lblFluency.Font = new Font("Segoe UI", 11F);
            lblFluency.Location = new Point(6, 121);
            lblFluency.Name = "lblFluency";
            lblFluency.Size = new Size(226, 76);
            lblFluency.TabIndex = 1;
            lblFluency.Text = "Fluency: ";
            lblFluency.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAccuracy
            // 
            lblAccuracy.BackColor = Color.WhiteSmoke;
            lblAccuracy.Font = new Font("Segoe UI", 11F);
            lblAccuracy.Location = new Point(6, 27);
            lblAccuracy.Name = "lblAccuracy";
            lblAccuracy.Size = new Size(226, 76);
            lblAccuracy.TabIndex = 0;
            lblAccuracy.Text = "Accuracy: ";
            lblAccuracy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPronunciation
            // 
            lblPronunciation.BackColor = Color.WhiteSmoke;
            lblPronunciation.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPronunciation.Location = new Point(548, 302);
            lblPronunciation.Name = "lblPronunciation";
            lblPronunciation.Size = new Size(226, 147);
            lblPronunciation.TabIndex = 39;
            lblPronunciation.Text = "100%";
            lblPronunciation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSentencePron
            // 
            lblSentencePron.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSentencePron.ForeColor = SystemColors.WindowFrame;
            lblSentencePron.Location = new Point(0, 169);
            lblSentencePron.Name = "lblSentencePron";
            lblSentencePron.Size = new Size(800, 54);
            lblSentencePron.TabIndex = 40;
            lblSentencePron.Text = "gab peosammida or something";
            lblSentencePron.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SenModeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 634);
            Controls.Add(lblSentencePron);
            Controls.Add(lblPronunciation);
            Controls.Add(gbStats);
            Controls.Add(lblSentenceKor);
            Controls.Add(lblSentenceEng);
            Controls.Add(btnRecord);
            Controls.Add(btnFinish);
            Controls.Add(btnNext);
            Controls.Add(panelHeader);
            Name = "SenModeForm";
            Text = "SenModeForm";
            Load += SenModeForm_Load;
            panelHeader.ResumeLayout(false);
            gbStats.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnReturn;
        private Panel panelHeader;
        private Button btnClose;
        private Button btnMax;
        private Button btnMin;
        private Label lblSentenceKor;
        private Button btnFinish;
        private Button btnNext;
        private Button btnRecord;
        private Label lblSentenceEng;
        private GroupBox gbStats;
        private Label lblAccuracy;
        private Label lblCompleteness;
        private Label lblFluency;
        private Label lblPronunciation;
        private Label lblSentencePron;
    }
}