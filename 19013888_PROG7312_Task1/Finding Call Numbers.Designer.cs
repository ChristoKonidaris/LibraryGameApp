namespace _19013888_PROG7312_Task1
{
    partial class FindingCallNumbers
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FindingCallNumbersBack = new System.Windows.Forms.Button();
            this.GenerateQuiz = new System.Windows.Forms.Button();
            this.QuizBox = new System.Windows.Forms.ListBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(466, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quiz";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 57);
            this.label1.TabIndex = 6;
            this.label1.Text = "Finding Call Numbers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FindingCallNumbersBack
            // 
            this.FindingCallNumbersBack.BackColor = System.Drawing.Color.SlateGray;
            this.FindingCallNumbersBack.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindingCallNumbersBack.Location = new System.Drawing.Point(886, 571);
            this.FindingCallNumbersBack.Name = "FindingCallNumbersBack";
            this.FindingCallNumbersBack.Size = new System.Drawing.Size(107, 33);
            this.FindingCallNumbersBack.TabIndex = 9;
            this.FindingCallNumbersBack.Text = "Back";
            this.FindingCallNumbersBack.UseVisualStyleBackColor = false;
            this.FindingCallNumbersBack.Click += new System.EventHandler(this.FindingCallNumbersBack_Click);
            // 
            // GenerateQuiz
            // 
            this.GenerateQuiz.BackColor = System.Drawing.Color.SlateGray;
            this.GenerateQuiz.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateQuiz.Location = new System.Drawing.Point(423, 468);
            this.GenerateQuiz.Name = "GenerateQuiz";
            this.GenerateQuiz.Size = new System.Drawing.Size(165, 33);
            this.GenerateQuiz.TabIndex = 10;
            this.GenerateQuiz.Text = "Generate Quiz";
            this.GenerateQuiz.UseVisualStyleBackColor = false;
            this.GenerateQuiz.Click += new System.EventHandler(this.GenerateQuiz_Click);
            // 
            // QuizBox
            // 
            this.QuizBox.FormattingEnabled = true;
            this.QuizBox.Location = new System.Drawing.Point(423, 217);
            this.QuizBox.Name = "QuizBox";
            this.QuizBox.Size = new System.Drawing.Size(165, 225);
            this.QuizBox.TabIndex = 11;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.SlateGray;
            this.Submit.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(423, 516);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(165, 33);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.BackColor = System.Drawing.Color.SlateGray;
            this.Question.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(427, 164);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(101, 31);
            this.Question.TabIndex = 13;
            this.Question.Text = "Question";
            // 
            // FindingCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_19013888_PROG7312_Task1.Properties.Resources.Library_background;
            this.ClientSize = new System.Drawing.Size(1005, 616);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.QuizBox);
            this.Controls.Add(this.GenerateQuiz);
            this.Controls.Add(this.FindingCallNumbersBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindingCallNumbers";
            this.Text = "Finding Call Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FindingCallNumbersBack;
        private System.Windows.Forms.Button GenerateQuiz;
        private System.Windows.Forms.ListBox QuizBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Question;
    }
}