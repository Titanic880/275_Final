using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Standards_Final;
namespace Client.Forms
{
    public partial class Create_Quiz : Form
    {
        private readonly Random rand = new Random();
        public Create_Quiz()
        {
            InitializeComponent();
        }

        private void BtnPubView_Click(object sender, EventArgs e)
        {
            LoadQuiz((Standards_Final.Quizlet.Question)lstPub.SelectedItem);
        }

        private void BtnPrivView_Click(object sender, EventArgs e)
        {

        }

        private void BtnQuiz_Click(object sender, EventArgs e)
        {

        }

        private void LoadQuiz(Standards_Final.Quizlet.Question Q)
        {
            string[] QRand = Q.Vis_Answers.OrderBy(x => rand.Next()).ToArray();

            //Loads label
            lblQuestion.Text = Q.Vis_Question;
            //Loads buttons with the answers
            BtnQ1.Text = QRand[0];
            BtnQ2.Text = QRand[1];

            //Checks if the answers exist
            if (QRand.Length >= 3)
            {
                BtnQ3.Text = QRand[2];
                BtnQ3.Enabled = true;
            }
            if (QRand.Length == 4)
            {
                BtnQ4.Text = QRand[3];
                BtnQ4.Enabled = true;
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Create_Question C_question = new Create_Question();
            C_question.ShowDialog();
            if (C_question.Q == null)
                return;
            else
            {
                lstPriv.Items.Add(C_question.Q);
            }
        }
    }
}
