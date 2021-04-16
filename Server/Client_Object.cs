using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Net.Sockets;
using System.IO;

using Standards_Final.Sessions;
using Standards_Final.Network;
using Standards_Final.Quizlet;
using Standards_Final.Users;

using Server.Framework_Ent;

namespace Server
{
    public class Client_Object
    {
        public static TcpListener Client_Listener;

        //Client ID
        public static int ClientCounter;
        public User User_Obj { get; private set; }

        #region Delegates 
        //Runs when a client first connects
        public event NewClientConnectedEventHandler NewClientConnected;
        public delegate void NewClientConnectedEventHandler(Client_Object client);

        //Runs when a client disconnects
        public event ClientDisconnectedEventHandler ClientDisconnected;
        public delegate void ClientDisconnectedEventHandler(Client_Object client);

        //Runs when the user class is assigned
        public event UserDefined UserDef;
        public delegate void UserDefined(Client_Object client);

        //Runs when a client requests a new session
        public event NewSession Sess_New;
        public delegate void NewSession(Client_Object client, New_Session new_);

        public event StartQuiz Start_Quiz;
        public delegate void StartQuiz(Quiz_Start _Start);

        public event Update_Score scores;
        public delegate void Update_Score(Score_Update _Update);
        #endregion Delegates

        //Main worker
        private readonly BackgroundWorker wkr = new BackgroundWorker();
        //Generic Socket
        private Socket C_Socket;
        //network datapath
        private NetworkStream C_nStream;
        //Generic read/write
        private BinaryReader C_reader;
        private BinaryWriter C_writer;

        public Client_Object(TcpListener listener)
        {
            //Resets the listener
            Client_Listener = listener;
            
            //Increases ID Counter
            ClientCounter++;
            
            //Sets up the worker
            wkr.WorkerReportsProgress = true;
            wkr.DoWork += Incoming;
            wkr.ProgressChanged += Sorting;

            //Runs worker
            wkr.RunWorkerAsync();
        }

        /// <summary>
        /// Incoming Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Incoming (object sender, DoWorkEventArgs e)
        {
            //Makes sure the socket is connected
            C_Socket = Client_Listener.AcceptSocket();
            //Creates the user Connection objects
            wkr.ReportProgress(0);

            if (C_Socket == null)
                return;

            //Sets up the Main Stream
            C_nStream = new NetworkStream(C_Socket);
            if (C_nStream == null)
                return;

            //Sets up the Read/Writer Objects
            C_reader = new BinaryReader(C_nStream);
            C_writer = new BinaryWriter(C_nStream);

            IFormatter formatter = new BinaryFormatter();

            while (!wkr.CancellationPending)
            {
                //Error checking
                if (C_nStream == null)
                {
                    C_nStream = new NetworkStream(C_Socket);
                    if (C_reader == null)
                        C_reader = new BinaryReader(C_nStream);
                    
                    if (C_reader.BaseStream == null)
                        continue;
                }

                //Distrobution of information
                object o = formatter.Deserialize(C_reader.BaseStream);
                if (o is null)
                    continue;
                else //Instead of double sorting i sort it once
                    wkr.ReportProgress(1, o);
            }
        }

        private void Sorting(object sender, ProgressChangedEventArgs e)
        {
            //New Client Connected
            if (e.ProgressPercentage == 0)
            {
                NewClientConnected(this);
                return;
            }
            //Changes the object into a easier to read format
            object Sort = e.UserState;

            switch (Sort)
            {
                //Disconnects the user
                case DisconnectUser _:
                    ClientDisconnected(this);
                    break;
                //Ties a Client_Object & Client to a User
                case User _:
                    User_Obj = (User)Sort;
                    UserDef(this);
                    break;
                //User requesting to register with provided credentials
                case Register_Request _:
                    SendMessage(Server_DbLogic.Client_Register((Register_Request)Sort));
                    break;
                //Client Asking server to check DB for User object
                case Login_Request _:
                    SendMessage(Server_DbLogic.Client_Login((Login_Request)Sort));
                    break;
                //Creates a new Session
                case New_Session _:
                    Sess_New(this, (New_Session)Sort);
                    break;
                //Adds a new Question to the DB
                case NewQuestion _:
                    Server_DbLogic.Add_Question(((NewQuestion)e.UserState).NewQ);
                    break;
                //Adds a new Quiz to the Db
                case NewQuiz _:
                    Server_DbLogic.Add_Quiz(((NewQuiz)e.UserState).newQ);
                    break;
                //Recieves a list of all accessible quizzes
                case Quiz[] _:
                    SendMessage(Server_DbLogic.Get_Quiz(User_Obj));
                    break;
                //Recieves a list of all questions
                case Question[] _:
                    SendMessage(Server_DbLogic.Get_Questions());
                    break;
                case Quiz_Start _:
                    Start_Quiz((Quiz_Start) Sort);
                    break;
                case Score_Update _:
                    scores((Score_Update)Sort);
                    break;
                default:
                    break;
            }

        }

        public void SendMessage(object Msg)
        {
            if (Msg == null)
                return;

            else if (C_writer == null)  //Checks for writer, if its null wait a second for initilization attempt
            {
                //Depreciated?
                System.Threading.Thread.Sleep(1000);
                if (C_writer == null)
                    return;
            }

            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(C_writer.BaseStream, Msg);
        }

    }
}
