using Standards_Final.Users;
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
    public partial class Home : Form
    {
        readonly Timer TimeLeft = new Timer();
        Standards_Final.Quizlet.Quiz Le_Quiz;
        private int Question_Current = 0;
        //QuizQuestion Quiz_Question = new QuizQuestion();


        private int Correct_Answers = 0;
        public Home()
        {
            InitializeComponent();
            LaunchForm.Host_.GetSession += Host__GetSession;
            LaunchForm.Host_.GetList += Host_UserList;
            LaunchForm.Host_.GetQuiz += Host__GetQuiz;
            TimeLeft.Interval = 100;
            TimeLeft.Tick += TimeLeft_Tick;
            Quiz_Question.Enabled = false;
        }



        private void Host__GetSession(Standards_Final.Sessions.Session_Conn session)
        {
            BeginInvoke(new MethodInvoker(() => UpdateLabelSession("Session ID: " + session.Session_ID)));
            Active_User.Active_User_Object.Current_Session = session;
        }
        private void UpdateLabelSession(string txt)
        {
            lblSession.Text = txt;
        }

        private void Host__GetQuiz(Standards_Final.Quizlet.Quiz[] le_Quiz)
        {
            BeginInvoke(new MethodInvoker(() => UpdateQuizList(le_Quiz)));
        }
        private void UpdateQuizList(Standards_Final.Quizlet.Quiz[] quizzes)
        {
            lstQuiz.AccessibleName = "Id";
            lstQuiz.DataSource = quizzes;
        }

        private void Host_UserList(User[] Connected)
        {
            BeginInvoke(new MethodInvoker(() => UpdateUserList(Connected)));
        }
        private void UpdateUserList(User[] users)
        {
            lstUsers.AccessibleName = "UserName";
            lstUsers.DataSource = users;
        }

        private void TimeLeft_Tick(object sender, EventArgs e)
        {
            if (prgTimeLeft.Value > prgTimeLeft.Minimum)
                prgTimeLeft.Value--;
            else if (prgTimeLeft.Value == prgTimeLeft.Minimum)
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
            //Quiz_Question = new QuizQuestion(Le_Quiz.Qs[Question_Current]);
            Quiz_Question.Update();
            if (Quiz_Question.Correct)
            {
                Correct_Answers++;
                lblCorrect.Text = $"Correct Answers: {Correct_Answers}";
            }
            //prgTimeLeft.Value = Le_Quiz.Qs[Question_Current].Question_Time;

            Question_Current++;
        }

        private void BtnHost_Click(object sender, EventArgs e)
        {
            BtnSessionConnect.Enabled = false;
            TbSession.Enabled = false;

            //Prompts the user if they want it to be public
            DialogResult res = MessageBox.Show("Is this session public?", "", MessageBoxButtons.YesNo);

            Standards_Final.Sessions.New_Session ses = new Standards_Final.Sessions.New_Session
            {
                Host = Active_User.Active_User_Object
            };

            if (res == DialogResult.Yes)
                ses.Is_Public = true;

            //Sends the session request
            LaunchForm.Host_.Send_To_Server(ses);
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            new Creation.Create_Quiz().ShowDialog();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnSessionConnect_Click(object sender, EventArgs e)
        {

        }
    }
}
