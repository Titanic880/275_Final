
namespace Client.Forms
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.BtnPubAdd = new System.Windows.Forms.Button();
            this.BtnPrivAdd = new System.Windows.Forms.Button();
            this.BtnPubView = new System.Windows.Forms.Button();
            this.BtnPrivView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 368);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Public Questions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Questions";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(138, 26);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 368);
            this.listBox2.TabIndex = 2;
            // 
            // BtnPubAdd
            // 
            this.BtnPubAdd.Location = new System.Drawing.Point(264, 26);
            this.BtnPubAdd.Name = "BtnPubAdd";
            this.BtnPubAdd.Size = new System.Drawing.Size(105, 23);
            this.BtnPubAdd.TabIndex = 4;
            this.BtnPubAdd.Text = "Add from public";
            this.BtnPubAdd.UseVisualStyleBackColor = true;
            // 
            // BtnPrivAdd
            // 
            this.BtnPrivAdd.Location = new System.Drawing.Point(264, 55);
            this.BtnPrivAdd.Name = "BtnPrivAdd";
            this.BtnPrivAdd.Size = new System.Drawing.Size(105, 23);
            this.BtnPrivAdd.TabIndex = 5;
            this.BtnPrivAdd.Text = "Add from private";
            this.BtnPrivAdd.UseVisualStyleBackColor = true;
            // 
            // BtnPubView
            // 
            this.BtnPubView.Location = new System.Drawing.Point(12, 400);
            this.BtnPubView.Name = "BtnPubView";
            this.BtnPubView.Size = new System.Drawing.Size(120, 23);
            this.BtnPubView.TabIndex = 6;
            this.BtnPubView.Text = "View Question";
            this.BtnPubView.UseVisualStyleBackColor = true;
            // 
            // BtnPrivView
            // 
            this.BtnPrivView.Location = new System.Drawing.Point(138, 400);
            this.BtnPrivView.Name = "BtnPrivView";
            this.BtnPrivView.Size = new System.Drawing.Size(120, 23);
            this.BtnPrivView.TabIndex = 7;
            this.BtnPrivView.Text = "View Question";
            this.BtnPrivView.UseVisualStyleBackColor = true;
            // 
            // Create_Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPrivView);
            this.Controls.Add(this.BtnPubView);
            this.Controls.Add(this.BtnPrivAdd);
            this.Controls.Add(this.BtnPubAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Create_Quiz";
            this.Text = "Create_Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button BtnPubAdd;
        private System.Windows.Forms.Button BtnPrivAdd;
        private System.Windows.Forms.Button BtnPubView;
        private System.Windows.Forms.Button BtnPrivView;
    }
}