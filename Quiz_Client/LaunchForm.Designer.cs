
namespace Quiz_Client
{
    partial class LaunchForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbSession = new System.Windows.Forms.MaskedTextBox();
            this.TbNick = new System.Windows.Forms.MaskedTextBox();
            this.BtnAnon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MTbPass = new System.Windows.Forms.MaskedTextBox();
            this.MTbUsername = new System.Windows.Forms.MaskedTextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.lblCustIP = new System.Windows.Forms.Label();
            this.TbCustomIP = new System.Windows.Forms.TextBox();
            this.BtnConnectCustom = new System.Windows.Forms.Button();
            this.BtnHostCon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "NickName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Session ID";
            // 
            // TbSession
            // 
            this.TbSession.Enabled = false;
            this.TbSession.Location = new System.Drawing.Point(278, 107);
            this.TbSession.Name = "TbSession";
            this.TbSession.Size = new System.Drawing.Size(125, 20);
            this.TbSession.TabIndex = 33;
            // 
            // TbNick
            // 
            this.TbNick.Enabled = false;
            this.TbNick.Location = new System.Drawing.Point(278, 68);
            this.TbNick.Name = "TbNick";
            this.TbNick.Size = new System.Drawing.Size(125, 20);
            this.TbNick.TabIndex = 32;
            // 
            // BtnAnon
            // 
            this.BtnAnon.Enabled = false;
            this.BtnAnon.Location = new System.Drawing.Point(278, 133);
            this.BtnAnon.Name = "BtnAnon";
            this.BtnAnon.Size = new System.Drawing.Size(125, 35);
            this.BtnAnon.TabIndex = 31;
            this.BtnAnon.Text = "Connect Anon";
            this.BtnAnon.UseVisualStyleBackColor = true;
            this.BtnAnon.Click += new System.EventHandler(this.BtnAnon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Password";
            // 
            // MTbPass
            // 
            this.MTbPass.Enabled = false;
            this.MTbPass.Location = new System.Drawing.Point(147, 107);
            this.MTbPass.Name = "MTbPass";
            this.MTbPass.PasswordChar = '*';
            this.MTbPass.Size = new System.Drawing.Size(125, 20);
            this.MTbPass.TabIndex = 28;
            this.MTbPass.UseSystemPasswordChar = true;
            // 
            // MTbUsername
            // 
            this.MTbUsername.Enabled = false;
            this.MTbUsername.Location = new System.Drawing.Point(147, 68);
            this.MTbUsername.Name = "MTbUsername";
            this.MTbUsername.Size = new System.Drawing.Size(125, 20);
            this.MTbUsername.TabIndex = 27;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Enabled = false;
            this.BtnLogin.Location = new System.Drawing.Point(147, 133);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(125, 35);
            this.BtnLogin.TabIndex = 26;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Enabled = false;
            this.BtnRegister.Location = new System.Drawing.Point(147, 174);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(125, 35);
            this.BtnRegister.TabIndex = 25;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // lblCustIP
            // 
            this.lblCustIP.AutoSize = true;
            this.lblCustIP.Location = new System.Drawing.Point(13, 91);
            this.lblCustIP.Name = "lblCustIP";
            this.lblCustIP.Size = new System.Drawing.Size(55, 13);
            this.lblCustIP.TabIndex = 24;
            this.lblCustIP.Text = "Custom IP";
            // 
            // TbCustomIP
            // 
            this.TbCustomIP.Location = new System.Drawing.Point(16, 107);
            this.TbCustomIP.Name = "TbCustomIP";
            this.TbCustomIP.Size = new System.Drawing.Size(125, 20);
            this.TbCustomIP.TabIndex = 23;
            // 
            // BtnConnectCustom
            // 
            this.BtnConnectCustom.Location = new System.Drawing.Point(16, 133);
            this.BtnConnectCustom.Name = "BtnConnectCustom";
            this.BtnConnectCustom.Size = new System.Drawing.Size(125, 35);
            this.BtnConnectCustom.TabIndex = 22;
            this.BtnConnectCustom.Text = "Custom Connect";
            this.BtnConnectCustom.UseVisualStyleBackColor = true;
            this.BtnConnectCustom.Click += new System.EventHandler(this.BtnConnectCustom_Click);
            // 
            // BtnHostCon
            // 
            this.BtnHostCon.Location = new System.Drawing.Point(16, 174);
            this.BtnHostCon.Name = "BtnHostCon";
            this.BtnHostCon.Size = new System.Drawing.Size(125, 35);
            this.BtnHostCon.TabIndex = 21;
            this.BtnHostCon.Text = "Connect to Host";
            this.BtnHostCon.UseVisualStyleBackColor = true;
            this.BtnHostCon.Click += new System.EventHandler(this.BtnHostCon_Click);
            // 
            // LaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbSession);
            this.Controls.Add(this.TbNick);
            this.Controls.Add(this.BtnAnon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MTbPass);
            this.Controls.Add(this.MTbUsername);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.lblCustIP);
            this.Controls.Add(this.TbCustomIP);
            this.Controls.Add(this.BtnConnectCustom);
            this.Controls.Add(this.BtnHostCon);
            this.Name = "LaunchForm";
            this.Text = "Launch Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TbSession;
        private System.Windows.Forms.MaskedTextBox TbNick;
        private System.Windows.Forms.Button BtnAnon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MTbPass;
        private System.Windows.Forms.MaskedTextBox MTbUsername;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label lblCustIP;
        private System.Windows.Forms.TextBox TbCustomIP;
        private System.Windows.Forms.Button BtnConnectCustom;
        private System.Windows.Forms.Button BtnHostCon;
    }
}

