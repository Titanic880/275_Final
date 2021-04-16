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
using Standards_Final.Quizlet;

namespace Server.Forms
{


    /// <summary>
    /// DEPRECIATED
    /// </summary>
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
                lstPub.Items.Add(C_question.Q);
            }
        }

        private void BtnPubAdd_Click(object sender, EventArgs e)
        {
            lstQuiz.Items.Add(lstPub.SelectedItem);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            lstQuiz.Items.RemoveAt(lstQuiz.SelectedIndex);
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            List<Question> tmp = new List<Question>();
            foreach(Question quest in lstQuiz.Items)
            {
                tmp.Add(quest);
            }
            //quiz.Qs = tmp.ToArray();

            DialogResult dia = MessageBox.Show("Is this public?","Public?",MessageBoxButtons.YesNo);

            if (dia == DialogResult.Yes)
                quiz.Accessiblity = true;
            quiz.AccessUsers += quiz.Creator_ID+",";
            
            //NEEDS TO BE FINISHED
        }
    }
}
