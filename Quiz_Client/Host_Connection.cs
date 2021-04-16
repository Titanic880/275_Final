using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Net.Sockets;
using System.IO;

using Standards_Final.Sessions;
using Standards_Final.Network;
using Standards_Final.Quizlet;
using Standards_Final.Users;

namespace Quiz_Client
{
    public class Host_Connection
    {
        private readonly string IPAddress;
        public User Active_User { get; set; }

        #region Delegates
        /// <summary>
        /// Handles the Login Result
        /// </summary>
        public event ResultLogin Login_Res;
        public delegate void ResultLogin(Login_Result result);

        /// <summary>
        /// Recieves the Active Question
        /// </summary>
        public event RecievedQuestion QuestionGet;
        public delegate void RecievedQuestion(Active_Question Q);

        /// <summary>
        /// Gets the Session from Server (Depreciated?)
        /// </summary>
        public event Session GetSession;
        public delegate void Session(Session_Conn session);


        /// <summary>
        /// Recieves a list of Quizzes for displaying
        /// </summary>
        public event RecievedQuiz GetQuiz;
        public delegate void RecievedQuiz(Quiz[] le_Quiz);

        /// <summary>
        /// Recieves a list of Questions for displaying
        /// </summary>
        public event GetQuizQuest GetQuestion;
        public delegate void GetQuizQuest(Question[] Q);

        /// <summary>
        /// Recieves a list of users for Displaying
        /// </summary>
        public event GetUserConnList GetList;
        public delegate void GetUserConnList(User[] Connected);
        #endregion Delegates

        //User Stack
        private TcpClient tcpClient;
        private NetworkStream nStream;
        private BinaryWriter writer;

        /// <summary>
        /// Controls the main Loop of Talking with the server
        /// </summary>
        readonly private BackgroundWorker wkr = new BackgroundWorker();

        /// <summary>
        /// MAIN CONSTRUCTOR
        /// </summary>
        /// <param name="IP"></param>
        public Host_Connection(string IP)
        {
            //Sets the IP to be used to talk with the server
            IPAddress = IP;

            //Configures the worker
            wkr.WorkerSupportsCancellation = true;
            wkr.DoWork += MainLoop;

            //Runs the worker
            wkr.RunWorkerAsync();
        }
        private void MainLoop(object s, DoWorkEventArgs e)
        {
            //Configures the client's TCP Information
            tcpClient = new TcpClient();
            //Attempts to connect to the given IP:Port
            tcpClient.Connect(IPAddress, Standards_Final.Standards.Port);

            //hooks onto the hosts data stream
            nStream = tcpClient.GetStream();

            //Sets up the Stream Writer
            writer = new BinaryWriter(nStream);
            //Creates the Stream to pull information from
            IFormatter Stream = new BinaryFormatter();

            //MAIN LOOP
            while (!wkr.CancellationPending)
            {
                //Checks if the stream is broken
                if (nStream == null)
                {
                    //Reconfigures the stream
                    nStream = tcpClient.GetStream();
                    writer = new BinaryWriter(nStream);
                    //continue; // DEPRECIATED?
                }
                //Pulls an item from the stream
                object o = Stream.Deserialize(nStream);

                //I WISH THIS COULD BE A SWITCH (V9.0 (.net 5) isnt out yet however :( )

#pragma warning disable IDE0038 // Use pattern matching (Was easier to read without pattern matching)
                if (o is Login_Result)
                    Login_Res((Login_Result)o);

                else if (o is Session_Conn)
                    GetSession((Session_Conn)o);

                else if (o is Question[])
                    GetQuestion((Question[])o);

                else if (o is Quiz[])
                    GetQuiz((Quiz[])o);

                else if (o is User[])
                    GetList((User[])o);

                else if (o is Active_Question)
                    QuestionGet((Active_Question)o);
#pragma warning restore IDE0038 // Use pattern matching
            }
        }

        /// <summary>
        /// Sends the object to the server
        /// </summary>
        /// <param name="package"></param>
        public void Send_To_Server(object package)
        {
            //Checks if there might be a problem
            //Depreciated?
            if (package == null || writer == null)
                return;

            IFormatter stream = new BinaryFormatter();
            stream.Serialize(writer.BaseStream, package);
        }
    }
}
