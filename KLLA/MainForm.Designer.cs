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
            lblTitle = new Label();
            lblTitleSub = new Label();
            btnPractice = new Button();
            btnDictionary = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Gill Sans MT Ext Condensed Bold", 80F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(232, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(364, 192);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "KLLA";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleSub
            // 
            lblTitleSub.Font = new Font("Gill Sans MT Ext Condensed Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleSub.ForeColor = Color.RoyalBlue;
            lblTitleSub.Location = new Point(85, 190);
            lblTitleSub.Name = "lblTitleSub";
            lblTitleSub.Size = new Size(655, 91);
            lblTitleSub.TabIndex = 1;
            lblTitleSub.Text = "K O R E A N  L A N G U A G E  L E A R N I N G  A P P";
            lblTitleSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPractice
            // 
            btnPractice.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPractice.Location = new Point(317, 284);
            btnPractice.Name = "btnPractice";
            btnPractice.Size = new Size(178, 52);
            btnPractice.TabIndex = 2;
            btnPractice.Text = "Practice";
            btnPractice.UseVisualStyleBackColor = true;
            btnPractice.Click += btnPractice_Click;
            // 
            // btnDictionary
            // 
            btnDictionary.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDictionary.Location = new Point(317, 360);
            btnDictionary.Name = "btnDictionary";
            btnDictionary.Size = new Size(178, 52);
            btnDictionary.TabIndex = 3;
            btnDictionary.Text = "Dictionary";
            btnDictionary.UseVisualStyleBackColor = true;
            btnDictionary.Click += btnDictionary_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(317, 436);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(178, 52);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 536);
            Controls.Add(btnExit);
            Controls.Add(btnDictionary);
            Controls.Add(btnPractice);
            Controls.Add(lblTitleSub);
            Controls.Add(lblTitle);
            Name = "MainForm";
            Text = "KLLA";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblTitleSub;
        private Button btnPractice;
        private Button btnDictionary;
        private Button btnExit;
    }
}