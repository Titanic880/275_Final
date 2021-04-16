
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
            this.BtnCreate = new System.Windows.Forms.Button();
            this.lstQuiz = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.BtnDisconnect = new System.Windows.Forms.Button();
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
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(12, 162);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(120, 37);
            this.BtnCreate.TabIndex = 18;
            this.BtnCreate.Text = "Create Quiz!";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // lstQuiz
            // 
            this.lstQuiz.FormattingEnabled = true;
            this.lstQuiz.Location = new System.Drawing.Point(12, 239);
            this.lstQuiz.Name = "lstQuiz";
            this.lstQuiz.Size = new System.Drawing.Size(120, 173);
            this.lstQuiz.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Avaliable Tests";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(12, 415);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(120, 23);
            this.BtnStart.TabIndex = 21;
            this.BtnStart.Text = "Start!";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(138, 239);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(120, 199);
            this.lstUsers.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Connected Users";
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Location = new System.Drawing.Point(146, 58);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(88, 13);
            this.lblWrong.TabIndex = 24;
            this.lblWrong.Text = "Wrong Answers: ";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(138, 162);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(120, 37);
            this.BtnDisconnect.TabIndex = 25;
            this.BtnDisconnect.Text = "Disconnect from Session";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Visible = false;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstQuiz);
            this.Controls.Add(this.BtnCreate);
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
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.ListBox lstQuiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Button BtnDisconnect;
    }
}