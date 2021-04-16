using Standards_Final.Users;
using System.Windows.Forms;
using System;

using Standards_Final.Sessions;
using Standards_Final.Quizlet;

namespace Quiz_Client
{
    public partial class Home : Form
    {
        /// <summary>
        /// Decrements the progress bar and decides when the game is over
        /// </summary>
        readonly Timer TimeLeft = new Timer();
        /// <summary>
        /// Amount of correct answers of the client
        /// </summary>
        private int Correct_Answers = 0;

        private Question Prev;
        /// <summary>
        /// The Current Question
        /// </summary>
        private Question Active;

        public Home()
        {
            InitializeComponent();
            //Ties into some Delegates
            LaunchForm.Host_.GetSession += Host__GetSession;
            LaunchForm.Host_.GetList += Host_UserList;
            LaunchForm.Host_.GetQuiz += Host__GetQuiz;
            LaunchForm.Host_.QuestionGet += Host__QuestionGet;
            //Sets up the basic timer
            TimeLeft.Interval = 100;
            TimeLeft.Tick += TimeLeft_Tick;
            Quiz_Question.Enabled = false;

            //Checks to see if the user is Anon
            if (LaunchForm.Host_.Active_User.Temp)
            {
                lstQuiz.Enabled = false;
                BtnCreate.Enabled = false;
                BtnHost.Enabled = false;
                BtnStart.Enabled = false;
            }
        }

        #region Delegates
        private void Host__GetSession(Session_Conn session)
        {
            BeginInvoke(new MethodInvoker(() => UpdateLabelSession("Session ID: " + session.Session_ID)));
            LaunchForm.Host_.Active_User.Current_Session = session;
        }
        private void UpdateLabelSession(string txt)
        {
            lblSession.Text = txt;
        }


        private void Host__GetQuiz(Quiz[] le_Quiz)
        {
            BeginInvoke(new MethodInvoker(() => UpdateQuizList(le_Quiz)));
        }
        private void UpdateQuizList(Quiz[] quizzes)
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


        private void Host__QuestionGet(Active_Question Q)
        {
            BeginInvoke(new MethodInvoker(() => QuestionGet(Q)));
        }
        private void QuestionGet(Active_Question Q)
        {
            //Shifts the Question down
            Prev = Active;
            Active = Q;


        }
        #endregion Delegates
        #region Events
        /// <summary>
        /// Disables/enables majority of UI
        /// </summary>
        /// <param name="Toggle"></param>
        private void UpdateGui(bool Toggle = false)
        {
            BtnCreate.Enabled = Toggle;
            BtnHost.Enabled = Toggle;
            BtnSessionConnect.Enabled = Toggle;
            BtnStart.Enabled = Toggle;
            lstQuiz.Enabled = Toggle;
            TbSession.Enabled = Toggle;
        }

        private void TimeLeft_Tick(object sender, EventArgs e)
        {
            if (prgTimeLeft.Value > prgTimeLeft.Minimum)
                prgTimeLeft.Value--;
            //Stops and restarts the timer for the next question
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

            if (Quiz_Question.Correct)
            {
                LaunchForm.Host_.Active_User.Current_Score++;
                lblCorrect.Text = $"Correct Answers: {Correct_Answers}";
            }

            //Reloads with a new Question
            Quiz_Question = new QuizQuestion(Active);
            Quiz_Question.Update();
            //Add Score update for others here?
        }
        #endregion

        #region Buttons
        private void BtnHost_Click(object sender, EventArgs e)
        {
            //easier to update all Gui then change back what i care about
            UpdateGui();
            BtnStart.Enabled = true;

            //Prompts the user if they want it to be public
            DialogResult res = MessageBox.Show("Is this session public?", "", MessageBoxButtons.YesNo);

            New_Session ses = new New_Session
            {
                Host = LaunchForm.Host_.Active_User
            };

            //reads prompt
            if (res == DialogResult.Yes)
                ses.Is_Public = true;

            //Sends the session request
            LaunchForm.Host_.Send_To_Server(ses);
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            //Opens a new Quiz Creation window
            new Creation.Create_Quiz().ShowDialog();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(lstQuiz.SelectedIndex != -1)
            {
                Quiz quiz = (Quiz)lstQuiz.SelectedItem;

                //Create a new QuestionGet object and send that to let the server bounce the question
                LaunchForm.Host_.Send_To_Server(quiz);
            }
            else
                MessageBox.Show("Invalid Quiz!");
        }
        private void BtnSessionConnect_Click(object sender, EventArgs e)
        {
            //Resets players Score
            LaunchForm.Host_.Active_User.Current_Score = 0;
            Session_Conn session = new Session_Conn();
            session.Session_ID = TbSession.Text;

        }
        #endregion Buttons
    }
}
