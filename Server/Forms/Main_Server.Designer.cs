
namespace Server.Forms
{
    partial class Main_Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstError = new System.Windows.Forms.ListBox();
            this.CbIP = new System.Windows.Forms.ComboBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblUserMessages = new System.Windows.Forms.Label();
            this.lstUMessage = new System.Windows.Forms.ListBox();
            this.LblIP = new System.Windows.Forms.Label();
            this.TbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbPass = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Error Log";
            // 
            // lstError
            // 
            this.lstError.FormattingEnabled = true;
            this.lstError.Location = new System.Drawing.Point(298, 66);
            this.lstError.Name = "lstError";
            this.lstError.Size = new System.Drawing.Size(280, 186);
            this.lstError.TabIndex = 25;
            // 
            // CbIP
            // 
            this.CbIP.FormattingEnabled = true;
            this.CbIP.Location = new System.Drawing.Point(12, 27);
            this.CbIP.Name = "CbIP";
            this.CbIP.Size = new System.Drawing.Size(138, 21);
            this.CbIP.TabIndex = 22;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(156, 25);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(138, 23);
            this.BtnStart.TabIndex = 23;
            this.BtnStart.Text = "Open Connection";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblUserMessages
            // 
            this.LblUserMessages.AutoSize = true;
            this.LblUserMessages.Location = new System.Drawing.Point(9, 51);
            this.LblUserMessages.Name = "LblUserMessages";
            this.LblUserMessages.Size = new System.Drawing.Size(80, 13);
            this.LblUserMessages.TabIndex = 29;
            this.LblUserMessages.Text = "User Messages";
            // 
            // lstUMessage
            // 
            this.lstUMessage.FormattingEnabled = true;
            this.lstUMessage.Location = new System.Drawing.Point(12, 66);
            this.lstUMessage.Name = "lstUMessage";
            this.lstUMessage.Size = new System.Drawing.Size(280, 186);
            this.lstUMessage.TabIndex = 24;
            // 
            // LblIP
            // 
            this.LblIP.AutoSize = true;
            this.LblIP.Location = new System.Drawing.Point(12, 11);
            this.LblIP.Name = "LblIP";
            this.LblIP.Size = new System.Drawing.Size(58, 13);
            this.LblIP.TabIndex = 28;
            this.LblIP.Text = "IP Address";
            // 
            // TbUserName
            // 
            this.TbUserName.Location = new System.Drawing.Point(300, 28);
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(100, 20);
            this.TbUserName.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Password";
            // 
            // TbPass
            // 
            this.TbPass.Location = new System.Drawing.Point(406, 28);
            this.TbPass.Name = "TbPass";
            this.TbPass.Size = new System.Drawing.Size(100, 20);
            this.TbPass.TabIndex = 33;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(512, 25);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 35;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // Main_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 282);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstError);
            this.Controls.Add(this.CbIP);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblUserMessages);
            this.Controls.Add(this.lstUMessage);
            this.Controls.Add(this.LblIP);
            this.Name = "Main_Server";
            this.Text = "Main_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstError;
        private System.Windows.Forms.ComboBox CbIP;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblUserMessages;
        private System.Windows.Forms.ListBox lstUMessage;
        private System.Windows.Forms.Label LblIP;
        private System.Windows.Forms.TextBox TbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbPass;
        private System.Windows.Forms.Button BtnLogin;
    }
}