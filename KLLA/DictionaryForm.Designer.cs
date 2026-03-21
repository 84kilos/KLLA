namespace KLLA
{
    partial class DictionaryForm
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
            tbSearch = new TextBox();
            gbDictionary = new GroupBox();
            btnPlay3 = new Button();
            btnPlay2 = new Button();
            btnPlay1 = new Button();
            btnPlay0 = new Button();
            lblWord0 = new Label();
            lblWord1 = new Label();
            lblWord2 = new Label();
            lblWord3 = new Label();
            lblTitleEng = new Label();
            lblTitleKor1 = new Label();
            lblTitleKor2 = new Label();
            btnNext = new Button();
            btnBack = new Button();
            panelHeader.SuspendLayout();
            gbDictionary.SuspendLayout();
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
            panelHeader.TabIndex = 7;
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
            btnReturn.TabIndex = 3;
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
            // tbSearch
            // 
            tbSearch.BackColor = SystemColors.ScrollBar;
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.ForeColor = Color.White;
            tbSearch.Location = new Point(71, 161);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(650, 32);
            tbSearch.TabIndex = 10;
            tbSearch.Text = "Search...";
            tbSearch.TextAlign = HorizontalAlignment.Center;
            tbSearch.MouseClick += tbSearch_MouseClick;
            tbSearch.TextChanged += tbSearch_TextChanged;
            tbSearch.Leave += tbSearch_Leave;
            // 
            // gbDictionary
            // 
            gbDictionary.BackColor = Color.Transparent;
            gbDictionary.Controls.Add(btnPlay3);
            gbDictionary.Controls.Add(btnPlay2);
            gbDictionary.Controls.Add(btnPlay1);
            gbDictionary.Controls.Add(btnPlay0);
            gbDictionary.Controls.Add(lblWord0);
            gbDictionary.Controls.Add(lblWord1);
            gbDictionary.Controls.Add(lblWord2);
            gbDictionary.Controls.Add(lblWord3);
            gbDictionary.FlatStyle = FlatStyle.Flat;
            gbDictionary.Location = new Point(29, 212);
            gbDictionary.Name = "gbDictionary";
            gbDictionary.Size = new Size(727, 533);
            gbDictionary.TabIndex = 9;
            gbDictionary.TabStop = false;
            // 
            // btnPlay3
            // 
            btnPlay3.BackColor = Color.WhiteSmoke;
            btnPlay3.FlatAppearance.BorderSize = 0;
            btnPlay3.FlatStyle = FlatStyle.Flat;
            btnPlay3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay3.ForeColor = Color.Black;
            btnPlay3.Location = new Point(6, 439);
            btnPlay3.Name = "btnPlay3";
            btnPlay3.Size = new Size(59, 48);
            btnPlay3.TabIndex = 20;
            btnPlay3.Text = "⏵";
            btnPlay3.UseVisualStyleBackColor = false;
            // 
            // btnPlay2
            // 
            btnPlay2.BackColor = Color.WhiteSmoke;
            btnPlay2.FlatAppearance.BorderSize = 0;
            btnPlay2.FlatStyle = FlatStyle.Flat;
            btnPlay2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay2.ForeColor = Color.Black;
            btnPlay2.Location = new Point(6, 310);
            btnPlay2.Name = "btnPlay2";
            btnPlay2.Size = new Size(59, 48);
            btnPlay2.TabIndex = 19;
            btnPlay2.Text = "⏵";
            btnPlay2.UseVisualStyleBackColor = false;
            // 
            // btnPlay1
            // 
            btnPlay1.BackColor = Color.WhiteSmoke;
            btnPlay1.FlatAppearance.BorderSize = 0;
            btnPlay1.FlatStyle = FlatStyle.Flat;
            btnPlay1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay1.ForeColor = Color.Black;
            btnPlay1.Location = new Point(6, 181);
            btnPlay1.Name = "btnPlay1";
            btnPlay1.Size = new Size(59, 48);
            btnPlay1.TabIndex = 18;
            btnPlay1.Text = "⏵";
            btnPlay1.UseVisualStyleBackColor = false;
            // 
            // btnPlay0
            // 
            btnPlay0.BackColor = Color.WhiteSmoke;
            btnPlay0.FlatAppearance.BorderSize = 0;
            btnPlay0.FlatStyle = FlatStyle.Flat;
            btnPlay0.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay0.ForeColor = Color.Black;
            btnPlay0.Location = new Point(6, 52);
            btnPlay0.Name = "btnPlay0";
            btnPlay0.Size = new Size(59, 48);
            btnPlay0.TabIndex = 17;
            btnPlay0.Text = "⏵";
            btnPlay0.UseVisualStyleBackColor = false;
            // 
            // lblWord0
            // 
            lblWord0.BackColor = Color.WhiteSmoke;
            lblWord0.Location = new Point(71, 27);
            lblWord0.Name = "lblWord0";
            lblWord0.Size = new Size(621, 100);
            lblWord0.TabIndex = 6;
            lblWord0.Text = "Loading...";
            lblWord0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWord1
            // 
            lblWord1.BackColor = Color.WhiteSmoke;
            lblWord1.Location = new Point(71, 156);
            lblWord1.Name = "lblWord1";
            lblWord1.Size = new Size(621, 100);
            lblWord1.TabIndex = 5;
            lblWord1.Text = "Loading...";
            lblWord1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWord2
            // 
            lblWord2.BackColor = Color.WhiteSmoke;
            lblWord2.Location = new Point(71, 285);
            lblWord2.Name = "lblWord2";
            lblWord2.Size = new Size(621, 100);
            lblWord2.TabIndex = 4;
            lblWord2.Text = "Loading...";
            lblWord2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWord3
            // 
            lblWord3.BackColor = Color.WhiteSmoke;
            lblWord3.Location = new Point(71, 414);
            lblWord3.Name = "lblWord3";
            lblWord3.Size = new Size(621, 100);
            lblWord3.TabIndex = 3;
            lblWord3.Text = "Loading...";
            lblWord3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleEng
            // 
            lblTitleEng.AutoSize = true;
            lblTitleEng.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleEng.ForeColor = Color.Black;
            lblTitleEng.Location = new Point(50, 51);
            lblTitleEng.Name = "lblTitleEng";
            lblTitleEng.Size = new Size(361, 96);
            lblTitleEng.TabIndex = 13;
            lblTitleEng.Text = "Dictionary";
            lblTitleEng.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleKor1
            // 
            lblTitleKor1.AutoSize = true;
            lblTitleKor1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleKor1.ForeColor = Color.Blue;
            lblTitleKor1.Location = new Point(392, 51);
            lblTitleKor1.Name = "lblTitleKor1";
            lblTitleKor1.Size = new Size(82, 96);
            lblTitleKor1.TabIndex = 14;
            lblTitleKor1.Text = "d";
            lblTitleKor1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleKor2
            // 
            lblTitleKor2.AutoSize = true;
            lblTitleKor2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleKor2.ForeColor = Color.Blue;
            lblTitleKor2.Location = new Point(480, 51);
            lblTitleKor2.Name = "lblTitleKor2";
            lblTitleKor2.Size = new Size(82, 96);
            lblTitleKor2.TabIndex = 15;
            lblTitleKor2.Text = "d";
            lblTitleKor2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.WhiteSmoke;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(397, 770);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(59, 48);
            btnNext.TabIndex = 3;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(332, 770);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(59, 48);
            btnBack.TabIndex = 16;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // DictionaryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(786, 844);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(lblTitleKor2);
            Controls.Add(lblTitleKor1);
            Controls.Add(lblTitleEng);
            Controls.Add(tbSearch);
            Controls.Add(gbDictionary);
            Controls.Add(panelHeader);
            Name = "DictionaryForm";
            Text = "Korean Dictionary";
            Load += DictionaryForm_Load;
            panelHeader.ResumeLayout(false);
            gbDictionary.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Button btnClose;
        private Button btnMax;
        private Button btnMin;
        private TextBox tbSearch;
        private GroupBox gbDictionary;
        private Label lblTitleEng;
        private Label lblTitleKor1;
        private Label lblTitleKor2;
        private Label lblWord0;
        private Label lblWord1;
        private Label lblWord2;
        private Label lblWord3;
        private Button btnNext;
        private Button btnBack;
        private Button btnPlay0;
        private Button btnPlay2;
        private Button btnPlay1;
        private Button btnPlay3;
        private Button btnReturn;
    }
}