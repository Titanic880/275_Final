
namespace Client.Forms
{
    partial class Home
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnSessionConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.QuizQuestion = new Client.Forms.Quizlet.Quiz4Question();
            this.lblSession = new System.Windows.Forms.Label();
            this.prgTimeLeft = new System.Windows.Forms.ProgressBar();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // BtnSessionConnect
            // 
            this.BtnSessionConnect.Location = new System.Drawing.Point(12, 54);
            this.BtnSessionConnect.Name = "BtnSessionConnect";
            this.BtnSessionConnect.Size = new System.Drawing.Size(100, 42);
            this.BtnSessionConnect.TabIndex = 1;
            this.BtnSessionConnect.Text = "Connect to Session";
            this.BtnSessionConnect.UseVisualStyleBackColor = true;
            this.BtnSessionConnect.Click += new System.EventHandler(this.BtnSessionConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Session ID";
            // 
            // QuizQuestion
            // 
            this.QuizQuestion.Location = new System.Drawing.Point(526, 12);
            this.QuizQuestion.Name = "QuizQuestion";
            this.QuizQuestion.Size = new System.Drawing.Size(262, 304);
            this.QuizQuestion.TabIndex = 3;
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(144, 9);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(61, 13);
            this.lblSession.TabIndex = 4;
            this.lblSession.Text = "Session ID:";
            // 
            // prgTimeLeft
            // 
            this.prgTimeLeft.Location = new System.Drawing.Point(526, 385);
            this.prgTimeLeft.Name = "prgTimeLeft";
            this.prgTimeLeft.Size = new System.Drawing.Size(262, 23);
            this.prgTimeLeft.TabIndex = 5;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(629, 369);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(54, 13);
            this.lblTimeLeft.TabIndex = 6;
            this.lblTimeLeft.Text = "Time Left:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(144, 28);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(90, 13);
            this.lblCorrect.TabIndex = 7;
            this.lblCorrect.Text = "Correct Answers: ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.prgTimeLeft);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.QuizQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSessionConnect);
            this.Controls.Add(this.textBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnSessionConnect;
        private System.Windows.Forms.Label label1;
        private Quizlet.Quiz4Question QuizQuestion;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.ProgressBar prgTimeLeft;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblCorrect;
    }
}