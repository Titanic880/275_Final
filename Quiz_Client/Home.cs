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

        private Question Prev;
        /// <summary>
        /// The Current Question
        /// </summary>
        private Question Active;

        public Home()
        {
            InitializeComponent();
            //Ties into some Delegates
            LaunchForm.Host_.GetQuiz += Host__GetQuiz;
            LaunchForm.Host_.Result_Ping += Host__Result_Ping;
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
        private void Host__GetQuiz(Quiz[] le_Quiz)
        {
            BeginInvoke(new MethodInvoker(() => UpdateQuizList(le_Quiz)));
        }
        private void UpdateQuizList(Quiz[] quizzes)
        {
            lstQuiz.AccessibleName = "Id";
            lstQuiz.DataSource = quizzes;
        }

        private void Host__Result_Ping(Ping_Result result)
        {
            BeginInvoke(new MethodInvoker(() => Result_Ping_Method(result)));
        }
        private void Result_Ping_Method(Ping_Result result)
        {
            if (result.Does_Exist)
            {
                lblSession.Text = "Session ID: " + result.Session_ID;
                LaunchForm.Host_.Active_User.Current_Session = result.ToSession();
                UpdateGui();
            }
            else
            {
                MessageBox.Show("Session does not exist!");
            }
        }
        #endregion Delegates
        #region Events
        /// <summary>
        /// Disables/enables majority of UI
        /// </summary>
        /// <param name="Toggle"></param>
        private void UpdateGui(bool Toggle = false)
        {
            TbSession.Enabled = Toggle;
            BtnSessionConnect.Enabled = Toggle;
           
            //Checks if user is anon so certain Gui isnt actived after a quiz
            if (LaunchForm.Host_.Active_User.Temp)
            {
                lstQuiz.Enabled = false;
                BtnCreate.Enabled = false;
                BtnHost.Enabled = false;
                BtnStart.Enabled = false;
            }
            else
            {
                lstQuiz.Enabled = Toggle;
                BtnCreate.Enabled = Toggle;
                BtnHost.Enabled = Toggle;
                BtnStart.Enabled = Toggle;
            }
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
                lblCorrect.Text = $"Correct Answers: {LaunchForm.Host_.Active_User.Current_Score}";
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
            //Checks for current session
            if (LaunchForm.Host_.Active_User.Current_Session.Is_Host)
            {
                //Checks for valid index
                if (lstQuiz.SelectedIndex != -1)
                {
                    //Sets the quiz
                    Quiz quiz = (Quiz)lstQuiz.SelectedItem;

                    //Creates the main Quiz object to be sent to server
                    Quiz_Start quiz_ = new Quiz_Start
                    {
                        Active_Session = LaunchForm.Host_.Active_User.Current_Session,
                        Host = LaunchForm.Host_.Active_User,
                        The_Quiz = (Quiz)lstQuiz.SelectedItem
                    };

                    //Sends it to the server
                    LaunchForm.Host_.Send_To_Server(quiz_);
                }
                else
                    MessageBox.Show("Invalid Quiz!");
            }
        }
        private void BtnSessionConnect_Click(object sender, EventArgs e)
        {
            //Resets players Score
            LaunchForm.Host_.Active_User.Current_Score = 0;
            
            //FIGURE OUT A WAY TO PING THE SERVER TO SEE IF THE SESSION EXISTS
            //If it does then let the client know, and if it doesn't let the client know
            //if it does then tie them to that given session
            //And set them up into a 'Waiting for Quiz to begin' mode
            
            //Session_Conn session = new Session_Conn();
            //session.Session_ID = TbSession.Text;


        }
        #endregion Buttons
    }
}
