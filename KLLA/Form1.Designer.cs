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
            SuspendLayout();
            // 
            // learnWordB
            // 
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
            learnWordLBL.Location = new Point(59, 27);
            learnWordLBL.Name = "learnWordLBL";
            learnWordLBL.Size = new Size(106, 25);
            learnWordLBL.TabIndex = 2;
            learnWordLBL.Text = "KOR WORD";
            // 
            // learnDefLBL
            // 
            learnDefLBL.AutoSize = true;
            learnDefLBL.Location = new Point(59, 66);
            learnDefLBL.Name = "learnDefLBL";
            learnDefLBL.Size = new Size(73, 25);
            learnDefLBL.TabIndex = 3;
            learnDefLBL.Text = "Eng def";
            // 
            // learnPronounceLBL
            // 
            learnPronounceLBL.AutoSize = true;
            learnPronounceLBL.Location = new Point(258, 27);
            learnPronounceLBL.Name = "learnPronounceLBL";
            learnPronounceLBL.Size = new Size(121, 25);
            learnPronounceLBL.TabIndex = 4;
            learnPronounceLBL.Text = "Pronunciation";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 556);
            Controls.Add(learnPronounceLBL);
            Controls.Add(learnDefLBL);
            Controls.Add(learnWordLBL);
            Controls.Add(learnMicCB);
            Controls.Add(learnWordB);
            Name = "Form1";
            Text = "KLLA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button learnWordB;
        private CheckBox learnMicCB;
        private Label learnWordLBL;
        private Label learnDefLBL;
        private Label learnPronounceLBL;
    }
}
