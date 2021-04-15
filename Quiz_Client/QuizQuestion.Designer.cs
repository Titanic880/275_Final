
namespace Quiz_Client
{
    partial class QuizQuestion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.BtnQ4 = new System.Windows.Forms.Button();
            this.BtnQ3 = new System.Windows.Forms.Button();
            this.BtnQ2 = new System.Windows.Forms.Button();
            this.BtnQ1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(19, 14);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 9;
            this.lblQuestion.Text = "Question";
            // 
            // BtnQ4
            // 
            this.BtnQ4.Enabled = false;
            this.BtnQ4.Location = new System.Drawing.Point(134, 176);
            this.BtnQ4.Name = "BtnQ4";
            this.BtnQ4.Size = new System.Drawing.Size(128, 128);
            this.BtnQ4.TabIndex = 8;
            this.BtnQ4.Text = "button3";
            this.BtnQ4.UseVisualStyleBackColor = true;
            this.BtnQ4.Click += new System.EventHandler(this.BtnQ4_Click);
            // 
            // BtnQ3
            // 
            this.BtnQ3.Enabled = false;
            this.BtnQ3.Location = new System.Drawing.Point(0, 176);
            this.BtnQ3.Name = "BtnQ3";
            this.BtnQ3.Size = new System.Drawing.Size(128, 128);
            this.BtnQ3.TabIndex = 7;
            this.BtnQ3.Text = "button4";
            this.BtnQ3.UseVisualStyleBackColor = true;
            this.BtnQ3.Click += new System.EventHandler(this.BtnQ3_Click);
            // 
            // BtnQ2
            // 
            this.BtnQ2.Location = new System.Drawing.Point(134, 42);
            this.BtnQ2.Name = "BtnQ2";
            this.BtnQ2.Size = new System.Drawing.Size(128, 128);
            this.BtnQ2.TabIndex = 6;
            this.BtnQ2.Text = "button2";
            this.BtnQ2.UseVisualStyleBackColor = true;
            this.BtnQ2.Click += new System.EventHandler(this.BtnQ2_Click);
            // 
            // BtnQ1
            // 
            this.BtnQ1.Location = new System.Drawing.Point(0, 42);
            this.BtnQ1.Name = "BtnQ1";
            this.BtnQ1.Size = new System.Drawing.Size(128, 128);
            this.BtnQ1.TabIndex = 5;
            this.BtnQ1.Text = "button1";
            this.BtnQ1.UseVisualStyleBackColor = true;
            this.BtnQ1.Click += new System.EventHandler(this.BtnQ1_Click);
            // 
            // QuizQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.BtnQ4);
            this.Controls.Add(this.BtnQ3);
            this.Controls.Add(this.BtnQ2);
            this.Controls.Add(this.BtnQ1);
            this.Name = "QuizQuestion";
            this.Size = new System.Drawing.Size(262, 304);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button BtnQ4;
        private System.Windows.Forms.Button BtnQ3;
        private System.Windows.Forms.Button BtnQ2;
        private System.Windows.Forms.Button BtnQ1;
    }
}
