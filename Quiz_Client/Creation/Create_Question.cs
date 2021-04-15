using System.Collections.Generic;
using Standards_Final.Quizlet;
using System.Windows.Forms;
using System;

namespace Quiz_Client.Creation
{
    public partial class Create_Question : Form
    {
        public Question Q { get; private set; }
        public Create_Question()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Checks for the basics of a question
            if (!string.IsNullOrWhiteSpace(TbQ.Text)
             || !string.IsNullOrWhiteSpace(TbA1.Text)
             || !string.IsNullOrWhiteSpace(TbA2.Text))
            {
                //Loads answers
                List<string> Answers = new List<string>();
                if (!string.IsNullOrWhiteSpace(TbA1.Text))
                    Answers.Add(TbA1.Text);
                if (!string.IsNullOrWhiteSpace(TbA2.Text))
                    Answers.Add(TbA2.Text);
                if (!string.IsNullOrWhiteSpace(TbA3.Text))
                    Answers.Add(TbA3.Text);
                if (!string.IsNullOrWhiteSpace(TbA4.Text))
                    Answers.Add(TbA4.Text);

                //Checks for Correct Answers
                List<string> C_Answers = new List<string>();
                if (CbA1.Checked)
                    C_Answers.Add(TbA1.Text);
                if (CbA2.Checked)
                    C_Answers.Add(TbA2.Text);
                if (CbA3.Checked && !string.IsNullOrWhiteSpace(TbA3.Text))
                    C_Answers.Add(TbA3.Text);
                if (CbA4.Checked && !string.IsNullOrWhiteSpace(TbA4.Text))
                    C_Answers.Add(TbA4.Text);

                //Checks for no correct answers
                if (C_Answers.Count > 0)
                {
                    int Timer = 60;
                    if (int.TryParse(TbQ.Text, out int res))
                        Timer = res;

                    Q = new Question(Active_User.Active_User_Object,
                                     TbQ.Text,
                                     Answers.ToArray(),
                                     C_Answers.ToArray(),
                                     DateTime.Now,
                                     Timer);

                    this.Close();
                }
                else
                    MessageBox.Show("There are no correct Answers!");
            }
            else
                MessageBox.Show("You are missing a Question/Answer!");
        }
    }
}
