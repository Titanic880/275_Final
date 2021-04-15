
namespace Quiz_Client
{
    partial class Session_Control
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
            this.BtnSelect = new System.Windows.Forms.Button();
            this.lstQuiz = new System.Windows.Forms.ListBox();
            this.lblQuizs = new System.Windows.Forms.Label();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(12, 221);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(120, 23);
            this.BtnSelect.TabIndex = 0;
            this.BtnSelect.Text = "Select Quiz";
            this.BtnSelect.UseVisualStyleBackColor = true;
            // 
            // lstQuiz
            // 
            this.lstQuiz.FormattingEnabled = true;
            this.lstQuiz.Location = new System.Drawing.Point(12, 42);
            this.lstQuiz.Name = "lstQuiz";
            this.lstQuiz.Size = new System.Drawing.Size(120, 173);
            this.lstQuiz.TabIndex = 2;
            // 
            // lblQuizs
            // 
            this.lblQuizs.AutoSize = true;
            this.lblQuizs.Location = new System.Drawing.Point(9, 26);
            this.lblQuizs.Name = "lblQuizs";
            this.lblQuizs.Size = new System.Drawing.Size(70, 13);
            this.lblQuizs.TabIndex = 3;
            this.lblQuizs.Text = "List of Quizes";
            // 
            // lstQuestions
            // 
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.Location = new System.Drawing.Point(138, 42);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(120, 173);
            this.lstQuestions.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "List of Questions";
            // 
            // Session_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.lblQuizs);
            this.Controls.Add(this.lstQuiz);
            this.Controls.Add(this.BtnSelect);
            this.Name = "Session_Control";
            this.Text = "Session_Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.ListBox lstQuiz;
        private System.Windows.Forms.Label lblQuizs;
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.Label label1;
    }
}