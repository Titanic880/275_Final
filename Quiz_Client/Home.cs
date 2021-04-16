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
        private int Q_Index = 0;
        private Question[] questions;


        public Home()
        {
            InitializeComponent();
            //Personalization
            this.Text = $"Home: {LaunchForm.Host_.Active_User.UserName}";


            //Ties into some Delegates
            LaunchForm.Host_.GetQuiz += Host__GetQuiz;
            LaunchForm.Host_.Result_Ping += Host__Result_Ping;
            LaunchForm.Host_.QStart += Host__QStart;
            LaunchForm.Host_.S_Update += Host__S_Update;
            LaunchForm.Host_.Ses_Get += Host__Ses_Get;

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
                MessageBox.Show($"Session {result.Session_ID} does not exist!");
            }
        }

        private void Host__QStart(Quiz_Start _Start)
        {
            BeginInvoke(new MethodInvoker(() => QStart(_Start)));
        }
        private void QStart(Quiz_Start _Start)
        {
            LoadUsers(_Start.Participatants);
            
            //Checks if the client is the host
            if(LaunchForm.Host_.Active_User != _Start.Host)
            {
                //prepares the quiz
                questions = _Start.Quiz_Questions;
                Reset_Next();

                //Starts the quiz
                MessageBox.Show("Quiz will begin when this is closed");
                TimeLeft.Start();
            }
        }

        private void Host__S_Update(Score_Update score)
        {
            BeginInvoke(new MethodInvoker(() => UpdateUser(score.user)));
        }


        private void Host__Ses_Get(Session_ session)
        {
            BeginInvoke(new MethodInvoker(() => Ses_Get(session)));
        }

        private void Ses_Get(Session_ session)
        {
            LaunchForm.Host_.Active_User.Current_Session = session;\
            UpdateGui();
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
            else
            {
                LaunchForm.Host_.Active_User.Wrong_Score++;
                lblWrong.Text = $"Wrong Answers: {LaunchForm.Host_.Active_User.Wrong_Score}";
            }

            //Reloads with a new Question
            Quiz_Question = new QuizQuestion(questions[Q_Index]);
            Quiz_Question.Update();
            
            //Updates Question index
            Q_Index++;

            //Builds and sends the updated user with updated score
            Score_Update update = new Score_Update
            {
                user = LaunchForm.Host_.Active_User
            };
            LaunchForm.Host_.Send_To_Server(update);
        }

        /// <summary>
        /// Updates the list with new users
        /// </summary>
        /// <param name="users"></param>
        private void LoadUsers(User[] users)
        {
            lstUsers.Items.Clear();
            foreach (User a in users)
            {
                lstUsers.AccessibleName = "stuff";
                lstUsers.Items.Add(a);
            }
            
        }

        /// <summary>
        /// Updates a single user in the list
        /// </summary>
        /// <param name="user"></param>
        private void UpdateUser(User user)
        {
            for(int i = 0; i < lstUsers.Items.Count; i++)
            {
                if(((User)lstUsers.Items[i]).Id == user.Id)
                {
                    lstUsers.Items.RemoveAt(i);
                    lstUsers.Items.Insert(i, user);
                }
            }
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
            //Stops an error with empty Textbox
            if (!string.IsNullOrWhiteSpace(TbSession.Text.Trim()))
            {
                //Resets players Score
                LaunchForm.Host_.Active_User.Current_Score = 0;

                //Builds and sends the request to see if the session exists
                Ping_Request req = new Ping_Request
                {
                    Session_ID = LaunchForm.Host_.Active_User.Current_Session.Session_ID
                };
                LaunchForm.Host_.Send_To_Server(req);
            }
            else
                MessageBox.Show("No session ID Found!");

            ///FIGURE OUT A WAY TO PING THE SERVER TO SEE IF THE SESSION EXISTS
            ///If it does then let the client know, and if it doesn't let the client know
            ///if it does then tie them to that given session
            ///And set them up into a 'Waiting for Quiz to begin' mode
        }
        #endregion Buttons

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            //NOT NEEDED?
            LaunchForm.Host_.Active_User.Current_Score = 0;
            LaunchForm.Host_.Active_User.Wrong_Score = 0;
            Session_DC _DC = new Session_DC
            {
                session = LaunchForm.Host_.Active_User.Current_Session
            };
            LaunchForm.Host_.Active_User.Current_Session = null;
            _DC.user = LaunchForm.Host_.Active_User;
            LaunchForm.Host_.Send_To_Server(_DC);
        }
    }
}
