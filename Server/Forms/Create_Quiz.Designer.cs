
namespace Server.Forms
{
    partial class Create_Quiz
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
            this.lstPub = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPubAdd = new System.Windows.Forms.Button();
            this.BtnPubView = new System.Windows.Forms.Button();
            this.BtnQuiz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstQuiz = new System.Windows.Forms.ListBox();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.BtnQ4 = new System.Windows.Forms.Button();
            this.BtnQ3 = new System.Windows.Forms.Button();
            this.BtnQ2 = new System.Windows.Forms.Button();
            this.BtnQ1 = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPub
            // 
            this.lstPub.FormattingEnabled = true;
            this.lstPub.Location = new System.Drawing.Point(138, 26);
            this.lstPub.Name = "lstPub";
            this.lstPub.Size = new System.Drawing.Size(120, 368);
            this.lstPub.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Public Questions";
            // 
            // BtnPubAdd
            // 
            this.BtnPubAdd.Location = new System.Drawing.Point(264, 26);
            this.BtnPubAdd.Name = "BtnPubAdd";
            this.BtnPubAdd.Size = new System.Drawing.Size(105, 23);
            this.BtnPubAdd.TabIndex = 4;
            this.BtnPubAdd.Text = "Add from List";
            this.BtnPubAdd.UseVisualStyleBackColor = true;
            this.BtnPubAdd.Click += new System.EventHandler(this.BtnPubAdd_Click);
            // 
            // BtnPubView
            // 
            this.BtnPubView.Location = new System.Drawing.Point(138, 400);
            this.BtnPubView.Name = "BtnPubView";
            this.BtnPubView.Size = new System.Drawing.Size(120, 23);
            this.BtnPubView.TabIndex = 6;
            this.BtnPubView.Text = "View Question";
            this.BtnPubView.UseVisualStyleBackColor = true;
            this.BtnPubView.Click += new System.EventHandler(this.BtnPubView_Click);
            // 
            // BtnQuiz
            // 
            this.BtnQuiz.Location = new System.Drawing.Point(375, 400);
            this.BtnQuiz.Name = "BtnQuiz";
            this.BtnQuiz.Size = new System.Drawing.Size(120, 23);
            this.BtnQuiz.TabIndex = 10;
            this.BtnQuiz.Text = "View Question";
            this.BtnQuiz.UseVisualStyleBackColor = true;
            this.BtnQuiz.Click += new System.EventHandler(this.BtnQuiz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Your Questions";
            // 
            // lstQuiz
            // 
            this.lstQuiz.FormattingEnabled = true;
            this.lstQuiz.Location = new System.Drawing.Point(375, 26);
            this.lstQuiz.Name = "lstQuiz";
            this.lstQuiz.Size = new System.Drawing.Size(120, 368);
            this.lstQuiz.TabIndex = 8;
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(264, 109);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(105, 23);
            this.BtnRemove.TabIndex = 12;
            this.BtnRemove.Text = "Remove from Quiz";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(546, 56);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 17;
            this.lblQuestion.Text = "Question";
            // 
            // BtnQ4
            // 
            this.BtnQ4.Enabled = false;
            this.BtnQ4.Location = new System.Drawing.Point(661, 218);
            this.BtnQ4.Name = "BtnQ4";
            this.BtnQ4.Size = new System.Drawing.Size(128, 128);
            this.BtnQ4.TabIndex = 16;
            this.BtnQ4.Text = "button3";
            this.BtnQ4.UseVisualStyleBackColor = true;
            // 
            // BtnQ3
            // 
            this.BtnQ3.Enabled = false;
            this.BtnQ3.Location = new System.Drawing.Point(527, 218);
            this.BtnQ3.Name = "BtnQ3";
            this.BtnQ3.Size = new System.Drawing.Size(128, 128);
            this.BtnQ3.TabIndex = 15;
            this.BtnQ3.Text = "button4";
            this.BtnQ3.UseVisualStyleBackColor = true;
            // 
            // BtnQ2
            // 
            this.BtnQ2.Location = new System.Drawing.Point(661, 84);
            this.BtnQ2.Name = "BtnQ2";
            this.BtnQ2.Size = new System.Drawing.Size(128, 128);
            this.BtnQ2.TabIndex = 14;
            this.BtnQ2.Text = "button2";
            this.BtnQ2.UseVisualStyleBackColor = true;
            // 
            // BtnQ1
            // 
            this.BtnQ1.Location = new System.Drawing.Point(527, 84);
            this.BtnQ1.Name = "BtnQ1";
            this.BtnQ1.Size = new System.Drawing.Size(128, 128);
            this.BtnQ1.TabIndex = 13;
            this.BtnQ1.Text = "button1";
            this.BtnQ1.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(264, 56);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(105, 47);
            this.BtnCreate.TabIndex = 18;
            this.BtnCreate.Text = "Create new Question";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnFinish
            // 
            this.BtnFinish.Location = new System.Drawing.Point(264, 138);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(105, 33);
            this.BtnFinish.TabIndex = 19;
            this.BtnFinish.Text = "Finish Quiz";
            this.BtnFinish.UseVisualStyleBackColor = true;
            this.BtnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // Create_Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.BtnFinish);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.BtnQ4);
            this.Controls.Add(this.BtnQ3);
            this.Controls.Add(this.BtnQ2);
            this.Controls.Add(this.BtnQ1);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnQuiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstQuiz);
            this.Controls.Add(this.BtnPubView);
            this.Controls.Add(this.BtnPubAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPub);
            this.Name = "Create_Quiz";
            this.Text = "Create_Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPubAdd;
        private System.Windows.Forms.Button BtnPubView;
        private System.Windows.Forms.Button BtnQuiz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstQuiz;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button BtnQ4;
        private System.Windows.Forms.Button BtnQ3;
        private System.Windows.Forms.Button BtnQ2;
        private System.Windows.Forms.Button BtnQ1;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnFinish;
    }
}