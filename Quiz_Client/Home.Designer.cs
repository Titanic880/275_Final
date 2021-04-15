
namespace Quiz_Client
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
            this.BtnHost = new System.Windows.Forms.Button();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.prgTimeLeft = new System.Windows.Forms.ProgressBar();
            this.lblSession = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSessionConnect = new System.Windows.Forms.Button();
            this.TbSession = new System.Windows.Forms.TextBox();
            this.Quiz_Question = new Quiz_Client.QuizQuestion();
            this.lstQuiz = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnHost
            // 
            this.BtnHost.Location = new System.Drawing.Point(12, 119);
            this.BtnHost.Name = "BtnHost";
            this.BtnHost.Size = new System.Drawing.Size(120, 37);
            this.BtnHost.TabIndex = 16;
            this.BtnHost.Text = "Start a session";
            this.BtnHost.UseVisualStyleBackColor = true;
            this.BtnHost.Click += new System.EventHandler(this.BtnHost_Click);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(144, 45);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(90, 13);
            this.lblCorrect.TabIndex = 15;
            this.lblCorrect.Text = "Correct Answers: ";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(629, 386);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(54, 13);
            this.lblTimeLeft.TabIndex = 14;
            this.lblTimeLeft.Text = "Time Left:";
            // 
            // prgTimeLeft
            // 
            this.prgTimeLeft.Location = new System.Drawing.Point(526, 402);
            this.prgTimeLeft.Name = "prgTimeLeft";
            this.prgTimeLeft.Size = new System.Drawing.Size(262, 23);
            this.prgTimeLeft.TabIndex = 13;
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(144, 26);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(61, 13);
            this.lblSession.TabIndex = 12;
            this.lblSession.Text = "Session ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Session ID";
            // 
            // BtnSessionConnect
            // 
            this.BtnSessionConnect.Location = new System.Drawing.Point(12, 71);
            this.BtnSessionConnect.Name = "BtnSessionConnect";
            this.BtnSessionConnect.Size = new System.Drawing.Size(120, 42);
            this.BtnSessionConnect.TabIndex = 10;
            this.BtnSessionConnect.Text = "Connect to Session";
            this.BtnSessionConnect.UseVisualStyleBackColor = true;
            this.BtnSessionConnect.Click += new System.EventHandler(this.BtnSessionConnect_Click);
            // 
            // TbSession
            // 
            this.TbSession.Location = new System.Drawing.Point(12, 45);
            this.TbSession.Name = "TbSession";
            this.TbSession.Size = new System.Drawing.Size(120, 20);
            this.TbSession.TabIndex = 9;
            // 
            // Quiz_Question
            // 
            this.Quiz_Question.Location = new System.Drawing.Point(526, 12);
            this.Quiz_Question.Name = "Quiz_Question";
            this.Quiz_Question.Size = new System.Drawing.Size(262, 304);
            this.Quiz_Question.TabIndex = 17;
            // 
            // lstQuiz
            // 
            this.lstQuiz.FormattingEnabled = true;
            this.lstQuiz.Location = new System.Drawing.Point(12, 162);
            this.lstQuiz.Name = "lstQuiz";
            this.lstQuiz.Size = new System.Drawing.Size(120, 277);
            this.lstQuiz.TabIndex = 18;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstQuiz);
            this.Controls.Add(this.Quiz_Question);
            this.Controls.Add(this.BtnHost);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.prgTimeLeft);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSessionConnect);
            this.Controls.Add(this.TbSession);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHost;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.ProgressBar prgTimeLeft;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSessionConnect;
        private System.Windows.Forms.TextBox TbSession;
        private QuizQuestion Quiz_Question;
        private System.Windows.Forms.ListBox lstQuiz;
    }
}