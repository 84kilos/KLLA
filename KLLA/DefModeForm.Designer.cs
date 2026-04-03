namespace KLLA
{
    partial class DefModeForm
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
            btnReturn = new Button();
            panelHeader = new Panel();
            btnClose = new Button();
            btnMax = new Button();
            btnMin = new Button();
            lblWordKor = new Label();
            lblWordRom = new Label();
            gbAnswerChoice = new GroupBox();
            lblResultStreak = new Label();
            lblResultQuestions = new Label();
            btnChoice5 = new Button();
            btnChoice2 = new Button();
            btnChoice4 = new Button();
            btnChoice1 = new Button();
            btnChoice3 = new Button();
            btnChoice0 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnNext = new Button();
            btnFinish = new Button();
            btnComplete = new Button();
            lblLoading = new Label();
            panelHeader.SuspendLayout();
            gbAnswerChoice.SuspendLayout();
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
            // lblWordKor
            // 
            lblWordKor.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWordKor.Location = new Point(0, 67);
            lblWordKor.Name = "lblWordKor";
            lblWordKor.Size = new Size(800, 111);
            lblWordKor.TabIndex = 10;
            lblWordKor.Text = "예시 단어";
            lblWordKor.TextAlign = ContentAlignment.MiddleCenter;
            lblWordKor.Click += lblWordKor_Click;
            // 
            // lblWordRom
            // 
            lblWordRom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWordRom.Location = new Point(0, 178);
            lblWordRom.Name = "lblWordRom";
            lblWordRom.Size = new Size(800, 69);
            lblWordRom.TabIndex = 11;
            lblWordRom.Text = "an-yeong-ha-se-yo";
            lblWordRom.TextAlign = ContentAlignment.TopCenter;
            // 
            // gbAnswerChoice
            // 
            gbAnswerChoice.Controls.Add(lblLoading);
            gbAnswerChoice.Controls.Add(lblResultStreak);
            gbAnswerChoice.Controls.Add(lblResultQuestions);
            gbAnswerChoice.Controls.Add(btnChoice5);
            gbAnswerChoice.Controls.Add(btnChoice2);
            gbAnswerChoice.Controls.Add(btnChoice4);
            gbAnswerChoice.Controls.Add(btnChoice1);
            gbAnswerChoice.Controls.Add(btnChoice3);
            gbAnswerChoice.Controls.Add(btnChoice0);
            gbAnswerChoice.Location = new Point(26, 238);
            gbAnswerChoice.Name = "gbAnswerChoice";
            gbAnswerChoice.Size = new Size(748, 339);
            gbAnswerChoice.TabIndex = 12;
            gbAnswerChoice.TabStop = false;
            // 
            // lblResultStreak
            // 
            lblResultStreak.BackColor = Color.WhiteSmoke;
            lblResultStreak.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultStreak.Location = new Point(141, 192);
            lblResultStreak.Name = "lblResultStreak";
            lblResultStreak.Size = new Size(468, 69);
            lblResultStreak.TabIndex = 36;
            lblResultStreak.Text = "Longest Streak: 29";
            lblResultStreak.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResultQuestions
            // 
            lblResultQuestions.BackColor = Color.WhiteSmoke;
            lblResultQuestions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultQuestions.Location = new Point(141, 99);
            lblResultQuestions.Name = "lblResultQuestions";
            lblResultQuestions.Size = new Size(468, 69);
            lblResultQuestions.TabIndex = 35;
            lblResultQuestions.Text = "Questions Accuracy: 29/30";
            lblResultQuestions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnChoice5
            // 
            btnChoice5.BackColor = Color.WhiteSmoke;
            btnChoice5.FlatAppearance.BorderSize = 0;
            btnChoice5.FlatStyle = FlatStyle.Flat;
            btnChoice5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChoice5.ForeColor = Color.Black;
            btnChoice5.Location = new Point(389, 236);
            btnChoice5.Name = "btnChoice5";
            btnChoice5.Size = new Size(335, 87);
            btnChoice5.TabIndex = 30;
            btnChoice5.Text = "definition";
            btnChoice5.UseVisualStyleBackColor = false;
            // 
            // btnChoice2
            // 
            btnChoice2.BackColor = Color.WhiteSmoke;
            btnChoice2.FlatAppearance.BorderSize = 0;
            btnChoice2.FlatStyle = FlatStyle.Flat;
            btnChoice2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChoice2.ForeColor = Color.Black;
            btnChoice2.Location = new Point(25, 236);
            btnChoice2.Name = "btnChoice2";
            btnChoice2.Size = new Size(333, 87);
            btnChoice2.TabIndex = 29;
            btnChoice2.Text = "definition";
            btnChoice2.UseVisualStyleBackColor = false;
            // 
            // btnChoice4
            // 
            btnChoice4.BackColor = Color.WhiteSmoke;
            btnChoice4.FlatAppearance.BorderSize = 0;
            btnChoice4.FlatStyle = FlatStyle.Flat;
            btnChoice4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChoice4.ForeColor = Color.Black;
            btnChoice4.Location = new Point(389, 133);
            btnChoice4.Name = "btnChoice4";
            btnChoice4.Size = new Size(335, 87);
            btnChoice4.TabIndex = 28;
            btnChoice4.Text = "definition";
            btnChoice4.UseVisualStyleBackColor = false;
            // 
            // btnChoice1
            // 
            btnChoice1.BackColor = Color.WhiteSmoke;
            btnChoice1.FlatAppearance.BorderSize = 0;
            btnChoice1.FlatStyle = FlatStyle.Flat;
            btnChoice1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChoice1.ForeColor = Color.Black;
            btnChoice1.Location = new Point(25, 133);
            btnChoice1.Name = "btnChoice1";
            btnChoice1.Size = new Size(333, 87);
            btnChoice1.TabIndex = 27;
            btnChoice1.Text = "definition";
            btnChoice1.UseVisualStyleBackColor = false;
            // 
            // btnChoice3
            // 
            btnChoice3.BackColor = Color.WhiteSmoke;
            btnChoice3.FlatAppearance.BorderSize = 0;
            btnChoice3.FlatStyle = FlatStyle.Flat;
            btnChoice3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChoice3.ForeColor = Color.Black;
            btnChoice3.Location = new Point(389, 30);
            btnChoice3.Name = "btnChoice3";
            btnChoice3.Size = new Size(335, 87);
            btnChoice3.TabIndex = 26;
            btnChoice3.Text = "definition";
            btnChoice3.UseVisualStyleBackColor = false;
            // 
            // btnChoice0
            // 
            btnChoice0.BackColor = Color.WhiteSmoke;
            btnChoice0.FlatAppearance.BorderSize = 0;
            btnChoice0.FlatStyle = FlatStyle.Flat;
            btnChoice0.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChoice0.ForeColor = Color.Black;
            btnChoice0.Location = new Point(25, 30);
            btnChoice0.Name = "btnChoice0";
            btnChoice0.Size = new Size(333, 87);
            btnChoice0.TabIndex = 25;
            btnChoice0.Text = "definition";
            btnChoice0.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.WhiteSmoke;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(499, 600);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(234, 57);
            btnNext.TabIndex = 31;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.WhiteSmoke;
            btnFinish.FlatAppearance.BorderSize = 0;
            btnFinish.FlatStyle = FlatStyle.Flat;
            btnFinish.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinish.ForeColor = Color.Black;
            btnFinish.Location = new Point(65, 600);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(234, 57);
            btnFinish.TabIndex = 33;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += btnFinish_Click;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.WhiteSmoke;
            btnComplete.FlatAppearance.BorderSize = 0;
            btnComplete.FlatStyle = FlatStyle.Flat;
            btnComplete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComplete.ForeColor = Color.Black;
            btnComplete.Location = new Point(305, 594);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(188, 68);
            btnComplete.TabIndex = 34;
            btnComplete.Text = "Complete";
            btnComplete.UseVisualStyleBackColor = false;
            // 
            // lblLoading
            // 
            lblLoading.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoading.Location = new Point(-14, -187);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(776, 595);
            lblLoading.TabIndex = 35;
            lblLoading.Text = "로딩 중...";
            lblLoading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DefModeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 680);
            Controls.Add(lblWordRom);
            Controls.Add(btnComplete);
            Controls.Add(btnFinish);
            Controls.Add(btnNext);
            Controls.Add(gbAnswerChoice);
            Controls.Add(lblWordKor);
            Controls.Add(panelHeader);
            Name = "DefModeForm";
            Text = "DefMode";
            Load += DefModeForm_Load;
            panelHeader.ResumeLayout(false);
            gbAnswerChoice.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnReturn;
        private Panel panelHeader;
        private Button btnClose;
        private Button btnMax;
        private Button btnMin;
        private Label lblWordKor;
        private Label lblWordRom;
        private GroupBox gbAnswerChoice;
        private Button btnChoice5;
        private Button btnChoice2;
        private Button btnChoice4;
        private Button btnChoice1;
        private Button btnChoice3;
        private Button btnChoice0;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnNext;
        private Button btnFinish;
        private Button btnComplete;
        private Label lblResultQuestions;
        private Label lblResultStreak;
        private Label lblLoading;
    }
}