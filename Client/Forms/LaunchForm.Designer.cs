
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
            this.SuspendLayout();
            // 
            // lblCustIP
            // 
            this.lblCustIP.AutoSize = true;
            this.lblCustIP.Location = new System.Drawing.Point(41, 42);
            this.lblCustIP.Name = "lblCustIP";
            this.lblCustIP.Size = new System.Drawing.Size(55, 13);
            this.lblCustIP.TabIndex = 8;
            this.lblCustIP.Text = "Custom IP";
            // 
            // TbCustomIP
            // 
            this.TbCustomIP.Location = new System.Drawing.Point(44, 58);
            this.TbCustomIP.Name = "TbCustomIP";
            this.TbCustomIP.Size = new System.Drawing.Size(125, 20);
            this.TbCustomIP.TabIndex = 7;
            // 
            // BtnConnectCustom
            // 
            this.BtnConnectCustom.Location = new System.Drawing.Point(44, 84);
            this.BtnConnectCustom.Name = "BtnConnectCustom";
            this.BtnConnectCustom.Size = new System.Drawing.Size(125, 35);
            this.BtnConnectCustom.TabIndex = 6;
            this.BtnConnectCustom.Text = "Custom Connect";
            this.BtnConnectCustom.UseVisualStyleBackColor = true;
            this.BtnConnectCustom.Click += new System.EventHandler(this.BtnConnectCustom_Click);
            // 
            // BtnHostCon
            // 
            this.BtnHostCon.Location = new System.Drawing.Point(44, 125);
            this.BtnHostCon.Name = "BtnHostCon";
            this.BtnHostCon.Size = new System.Drawing.Size(125, 35);
            this.BtnHostCon.TabIndex = 5;
            this.BtnHostCon.Text = "Connect to Host";
            this.BtnHostCon.UseVisualStyleBackColor = true;
            this.BtnHostCon.Click += new System.EventHandler(this.BtnHostCon_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(44, 182);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(125, 35);
            this.BtnLogin.TabIndex = 10;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(44, 223);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(125, 35);
            this.BtnRegister.TabIndex = 9;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 283);
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
    }
}