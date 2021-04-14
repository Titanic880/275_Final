﻿
namespace Client.Forms
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
            this.lblCustIP = new System.Windows.Forms.Label();
            this.TbCustomIP = new System.Windows.Forms.TextBox();
            this.BtnConnectCustom = new System.Windows.Forms.Button();
            this.BtnHostCon = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MTbPass = new System.Windows.Forms.MaskedTextBox();
            this.MTbUsername = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCustIP
            // 
            this.lblCustIP.AutoSize = true;
            this.lblCustIP.Location = new System.Drawing.Point(33, 90);
            this.lblCustIP.Name = "lblCustIP";
            this.lblCustIP.Size = new System.Drawing.Size(55, 13);
            this.lblCustIP.TabIndex = 8;
            this.lblCustIP.Text = "Custom IP";
            // 
            // TbCustomIP
            // 
            this.TbCustomIP.Location = new System.Drawing.Point(36, 106);
            this.TbCustomIP.Name = "TbCustomIP";
            this.TbCustomIP.Size = new System.Drawing.Size(125, 20);
            this.TbCustomIP.TabIndex = 7;
            // 
            // BtnConnectCustom
            // 
            this.BtnConnectCustom.Location = new System.Drawing.Point(36, 132);
            this.BtnConnectCustom.Name = "BtnConnectCustom";
            this.BtnConnectCustom.Size = new System.Drawing.Size(125, 35);
            this.BtnConnectCustom.TabIndex = 6;
            this.BtnConnectCustom.Text = "Custom Connect";
            this.BtnConnectCustom.UseVisualStyleBackColor = true;
            this.BtnConnectCustom.Click += new System.EventHandler(this.BtnConnectCustom_Click);
            // 
            // BtnHostCon
            // 
            this.BtnHostCon.Location = new System.Drawing.Point(36, 173);
            this.BtnHostCon.Name = "BtnHostCon";
            this.BtnHostCon.Size = new System.Drawing.Size(125, 35);
            this.BtnHostCon.TabIndex = 5;
            this.BtnHostCon.Text = "Connect to Host";
            this.BtnHostCon.UseVisualStyleBackColor = true;
            this.BtnHostCon.Click += new System.EventHandler(this.BtnHostCon_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(167, 132);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(125, 35);
            this.BtnLogin.TabIndex = 10;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(167, 173);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(125, 35);
            this.BtnRegister.TabIndex = 9;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password";
            // 
            // MTbPass
            // 
            this.MTbPass.Location = new System.Drawing.Point(167, 106);
            this.MTbPass.Name = "MTbPass";
            this.MTbPass.Size = new System.Drawing.Size(125, 20);
            this.MTbPass.TabIndex = 12;
            // 
            // MTbUsername
            // 
            this.MTbUsername.Location = new System.Drawing.Point(167, 67);
            this.MTbUsername.Name = "MTbUsername";
            this.MTbUsername.Size = new System.Drawing.Size(125, 20);
            this.MTbUsername.TabIndex = 11;
            // 
            // LaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 283);
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
            this.Text = "LaunchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustIP;
        private System.Windows.Forms.TextBox TbCustomIP;
        private System.Windows.Forms.Button BtnConnectCustom;
        private System.Windows.Forms.Button BtnHostCon;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MTbPass;
        private System.Windows.Forms.MaskedTextBox MTbUsername;
    }
}