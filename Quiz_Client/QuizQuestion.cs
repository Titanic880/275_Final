using Standards_Final.Quizlet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Client
{
    public partial class QuizQuestion : UserControl
    {
        private readonly Random rand = new Random();
        /// <summary>
        /// Whether or not a correct answer was hit
        /// </summary>
        public bool Correct { get; private set; } = false;
        private Question q;

        public QuizQuestion() { InitializeComponent(); }

        public void LoadQuestion(Question question)
        {
            Correct = false;
            ButtonClick(true);
            q = question;
            string[] QRand = q.Vis_Answers.OrderBy(x => rand.Next()).ToArray();

            //Loads label
            lblQuestion.Text = q.Vis_Question;
            //Loads buttons with the answers
            BtnQ1.Text = QRand[0];
            BtnQ2.Text = QRand[1];

            //Checks if the answers exist
            if (QRand.Length >= 3)
            {
                BtnQ3.Text = QRand[2];
                BtnQ3.Enabled = true;
            }
            else
            {
                BtnQ3.Text = "";
                BtnQ3.Enabled = false;
            }
            if (QRand.Length == 4)
            {
                BtnQ4.Text = QRand[3];
                BtnQ4.Enabled = true;
            }
            else
            {
                BtnQ4.Text = "";
                BtnQ4.Enabled = false;
            }
            Enabled = true;
        }

        //
        private void ButtonClick(bool set = false)
        {
            BtnQ1.Enabled = set;
            BtnQ2.Enabled = set;
            BtnQ3.Enabled = set;
            BtnQ4.Enabled = set;
            if(!set)
                lblQuestion.Text = "Please wait for others to finish~~";
        }

        private void BtnQ1_Click(object sender, EventArgs e)
        {
            foreach (string a in q.Correct_Answers)
                if (BtnQ1.Text == a)
                {
                    Correct = true;
                    break;
                }
            ButtonClick();
        }


        private void BtnQ2_Click(object sender, EventArgs e)
        {
            foreach (string a in q.Correct_Answers)
                if (BtnQ2.Text == a)
                {
                    Correct = true;
                    break;
                }
            ButtonClick();
        }

        private void BtnQ3_Click(object sender, EventArgs e)
        {
            foreach (string a in q.Correct_Answers)
                if (BtnQ3.Text == a)
                {
                    Correct = true;
                    break;
                }
            ButtonClick();
        }
        private void BtnQ4_Click(object sender, EventArgs e)
        {
            foreach (string a in q.Correct_Answers)
                if (BtnQ4.Text == a)
                {
                    Correct = true;
                    break;
                }
            ButtonClick();
        }
    }
}
