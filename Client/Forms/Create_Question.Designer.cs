﻿
namespace Client.Forms
{
    partial class Create_Question
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
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TbQ = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbA1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbA2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbA3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbA4 = new System.Windows.Forms.TextBox();
            this.CbA1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbA2 = new System.Windows.Forms.CheckBox();
            this.CbA4 = new System.Windows.Forms.CheckBox();
            this.CbA3 = new System.Windows.Forms.CheckBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblDur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(47, 321);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(144, 23);
            this.BtnSubmit.TabIndex = 0;
            this.BtnSubmit.Text = "Submit Question";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TbQ
            // 
            this.TbQ.Location = new System.Drawing.Point(47, 49);
            this.TbQ.Name = "TbQ";
            this.TbQ.Size = new System.Drawing.Size(144, 20);
            this.TbQ.TabIndex = 1;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(44, 33);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Answer 1";
            // 
            // TbA1
            // 
            this.TbA1.Location = new System.Drawing.Point(47, 86);
            this.TbA1.Name = "TbA1";
            this.TbA1.Size = new System.Drawing.Size(144, 20);
            this.TbA1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Answer 2";
            // 
            // TbA2
            // 
            this.TbA2.Location = new System.Drawing.Point(47, 124);
            this.TbA2.Name = "TbA2";
            this.TbA2.Size = new System.Drawing.Size(144, 20);
            this.TbA2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer 3 (Optional)";
            // 
            // TbA3
            // 
            this.TbA3.Location = new System.Drawing.Point(47, 161);
            this.TbA3.Name = "TbA3";
            this.TbA3.Size = new System.Drawing.Size(144, 20);
            this.TbA3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Answer 4 (Optional)";
            // 
            // TbA4
            // 
            this.TbA4.Location = new System.Drawing.Point(47, 198);
            this.TbA4.Name = "TbA4";
            this.TbA4.Size = new System.Drawing.Size(144, 20);
            this.TbA4.TabIndex = 9;
            // 
            // CbA1
            // 
            this.CbA1.AutoSize = true;
            this.CbA1.Location = new System.Drawing.Point(65, 275);
            this.CbA1.Name = "CbA1";
            this.CbA1.Size = new System.Drawing.Size(39, 17);
            this.CbA1.TabIndex = 11;
            this.CbA1.Text = "A1";
            this.CbA1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Correct Answers";
            // 
            // CbA2
            // 
            this.CbA2.AutoSize = true;
            this.CbA2.Location = new System.Drawing.Point(123, 275);
            this.CbA2.Name = "CbA2";
            this.CbA2.Size = new System.Drawing.Size(39, 17);
            this.CbA2.TabIndex = 13;
            this.CbA2.Text = "A2";
            this.CbA2.UseVisualStyleBackColor = true;
            // 
            // CbA4
            // 
            this.CbA4.AutoSize = true;
            this.CbA4.Location = new System.Drawing.Point(123, 298);
            this.CbA4.Name = "CbA4";
            this.CbA4.Size = new System.Drawing.Size(39, 17);
            this.CbA4.TabIndex = 15;
            this.CbA4.Text = "A4";
            this.CbA4.UseVisualStyleBackColor = true;
            // 
            // CbA3
            // 
            this.CbA3.AutoSize = true;
            this.CbA3.Location = new System.Drawing.Point(65, 298);
            this.CbA3.Name = "CbA3";
            this.CbA3.Size = new System.Drawing.Size(39, 17);
            this.CbA3.TabIndex = 14;
            this.CbA3.Text = "A3";
            this.CbA3.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(47, 237);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(37, 20);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.Text = "60";
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // lblDur
            // 
            this.lblDur.AutoSize = true;
            this.lblDur.Location = new System.Drawing.Point(44, 221);
            this.lblDur.Name = "lblDur";
            this.lblDur.Size = new System.Drawing.Size(143, 13);
            this.lblDur.TabIndex = 17;
            this.lblDur.Text = "Duration of Quiz (in seconds)";
            // 
            // Create_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 360);
            this.Controls.Add(this.lblDur);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.CbA4);
            this.Controls.Add(this.CbA3);
            this.Controls.Add(this.CbA2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbA1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbA4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbA3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbA2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbA1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.TbQ);
            this.Controls.Add(this.BtnSubmit);
            this.Name = "Create_Question";
            this.Text = "Create_Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.TextBox TbQ;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbA1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbA2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbA3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbA4;
        private System.Windows.Forms.CheckBox CbA1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CbA2;
        private System.Windows.Forms.CheckBox CbA4;
        private System.Windows.Forms.CheckBox CbA3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblDur;
    }
}