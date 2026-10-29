namespace LAB3_2_
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
            label1 = new Label();
            lblResult = new Label();
            btnCheckPass = new Button();
            btnLetterGrade = new Button();
            btnAverage = new Button();
            txtScore = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 101);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(302, 158);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(66, 20);
            lblResult.TabIndex = 1;
            lblResult.Text = "lblResult";
            // 
            // btnCheckPass
            // 
            btnCheckPass.Location = new Point(29, 273);
            btnCheckPass.Name = "btnCheckPass";
            btnCheckPass.Size = new Size(134, 78);
            btnCheckPass.TabIndex = 2;
            btnCheckPass.Text = "btnCheckPass";
            btnCheckPass.UseVisualStyleBackColor = true;
            btnCheckPass.Click += btnCheckPass_Click;
            // 
            // btnLetterGrade
            // 
            btnLetterGrade.Location = new Point(216, 273);
            btnLetterGrade.Name = "btnLetterGrade";
            btnLetterGrade.Size = new Size(124, 78);
            btnLetterGrade.TabIndex = 3;
            btnLetterGrade.Text = "btnLetterGrade";
            btnLetterGrade.UseVisualStyleBackColor = true;
            btnLetterGrade.Click += btnLetterGrade_Click;
            // 
            // btnAverage
            // 
            btnAverage.Location = new Point(402, 273);
            btnAverage.Name = "btnAverage";
            btnAverage.Size = new Size(105, 68);
            btnAverage.TabIndex = 4;
            btnAverage.Text = "btnAverage";
            btnAverage.UseVisualStyleBackColor = true;
            btnAverage.Click += btnAverage_Click;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(29, 151);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(203, 27);
            txtScore.TabIndex = 5;
            txtScore.TextChanged += txtScore_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtScore);
            Controls.Add(btnAverage);
            Controls.Add(btnLetterGrade);
            Controls.Add(btnCheckPass);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResult;
        private Button btnCheckPass;
        private Button btnLetterGrade;
        private Button btnAverage;
        private TextBox txtScore;
    }
}
