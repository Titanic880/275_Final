using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class Home : Form
    { 
        readonly Timer TimeLeft = new Timer();
        Standards_Final.Quizlet.Quiz Le_Quiz;
        private int Question_Current = 0;

        private int Correct_Answers = 0;
        public Home()
        {
            InitializeComponent();
            TimeLeft.Interval = 100;
            TimeLeft.Tick += TimeLeft_Tick;
            QuizQuestion.Enabled = false;
        }

        private void TimeLeft_Tick(object sender, EventArgs e)
        {
            if(prgTimeLeft.Value > prgTimeLeft.Minimum)
                prgTimeLeft.Value--;
            else if(prgTimeLeft.Value == prgTimeLeft.Minimum)
            {
                TimeLeft.Stop();
                Reset_Next();
                TimeLeft.Start();
            }
        }

        /// <summary>
        /// Sets up the page for the next question
        /// </summary>
        private void Reset_Next()
        {
            //Sets up the Question
            QuizQuestion = new Quizlet.Quiz4Question(Le_Quiz.Qs[Question_Current]);
            QuizQuestion.Update();
            if (QuizQuestion.Correct)
            {
                Correct_Answers++;
                lblCorrect.Text = $"Correct Answers: {Correct_Answers}";
            }
            prgTimeLeft.Value = Le_Quiz.Qs[Question_Current].Question_Time;

            Question_Current++;
        }

        private void BtnSessionConnect_Click(object sender, EventArgs e)
        {
            LaunchForm.Host_.GetQuiz += Host__GetQuiz;
        }

        private void Host__GetQuiz(Standards_Final.Quizlet.Quiz le_Quiz)
        {
            if(le_Quiz == null)
            {
                MessageBox.Show("Blank Quiz!");
                return;
            }
            Le_Quiz = le_Quiz;
            //Sends the first question
            Reset_Next();
            QuizQuestion.Enabled = true;
        }

        private void BtnHost_Click(object sender, EventArgs e)
        {
            BtnSessionConnect.Enabled = false;
            TbSession.Enabled = false;

            //Prompts the user if they want it to be public
            DialogResult res = MessageBox.Show("Is this session public?","",MessageBoxButtons.YesNo);
            
            Standards_Final.Sessions.New_Session ses = new Standards_Final.Sessions.New_Session
            {
                Host = Active_User.Active_User_Object
            };

            if (res == DialogResult.Yes)
                ses.Is_Public = true;

            //Sends the session request
            LaunchForm.Host_.Send_To_Server(ses);
        }
    }
}
