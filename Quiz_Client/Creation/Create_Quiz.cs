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
using Standards_Final.Network;
using Standards_Final.Quizlet;

namespace Quiz_Client.Creation
{
    public partial class Create_Quiz : Form
    {
        private readonly Random rand = new Random();
        public Create_Quiz()
        {
            InitializeComponent();
            //Sets up delegate before using it
            LaunchForm.Host_.GetQuestion += Host__GetQuestions;
            LaunchForm.Host_.Send_To_Server(new Request<Question[]>());
        }

        private void Host__GetQuestions(Question[] Q)
        {
            BeginInvoke(new MethodInvoker(() => LoadLists(Q)));
        }

        private void LoadLists(Question[] Q)
        {
            foreach(Question q in Q)
            {
                lstPub.AccessibleName = "Vis_Question";
                lstPub.Items.Add(q);
            }
        }

        private void BtnPubView_Click(object sender, EventArgs e)
        {
            LoadQuiz((Question)lstPub.SelectedItem);
        }
        private void BtnQuiz_Click(object sender, EventArgs e)
        {
            LoadQuiz((Question)lstQuiz.SelectedItem);
        }

        private void LoadQuiz(Question Q)
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
                LaunchForm.Host_.Send_To_Server(new NewQuestion(C_question.Q));
                lstPub.Items.Add(C_question.Q);
            }
        }

        private void BtnPubAdd_Click(object sender, EventArgs e)
        {
            if(lstPub.SelectedIndex < lstPub.Items.Count 
                || lstPub.SelectedIndex > 0 
                || lstPub.SelectedIndex != -1)
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
            foreach (Question quest in lstQuiz.Items)
            {
                tmp.Add(quest);
            }
            quiz.Qs = tmp.ToArray();

            DialogResult dia = MessageBox.Show("Is this public?", "Public?", MessageBoxButtons.YesNo);

            if (dia == DialogResult.Yes)
                quiz.Accessiblity = true;
            quiz.Creator = Active_User.Active_User_Object;
            quiz.AccessUsers.Add(quiz.Creator);

            LaunchForm.Host_.Send_To_Server(new NewQuiz(quiz));   
        }
    }
}
