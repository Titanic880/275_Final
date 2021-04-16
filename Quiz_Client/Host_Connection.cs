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

        //Runs when the user first connects
        public event Connection Connected;
        public delegate void Connection();

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

        public event PingRes Result_Ping;
        public delegate void PingRes(Ping_Result result);
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

            Connected();
            //MAIN LOOP
            while (!wkr.CancellationPending)
            {
                //Checks if the stream is broken
                if (nStream == null)
                {
                    //Reconfigures the stream
                    nStream = tcpClient.GetStream();
                    writer = new BinaryWriter(nStream);
                }
                //Pulls an item from the stream
                object o = Stream.Deserialize(nStream);

                //I WISH THIS COULD BE A SWITCH (EDIT:: INTELLISENSE SAID IT CAN BE DONE~!~!)
                //Pls Teach this Wizardry to people, it makes switches a good idea

                switch (o)
                {
                    case Login_Result _:
                        Login_Res((Login_Result)o);
                        break;
                    case Question[] _:
                        GetQuestion((Question[])o);
                        break;
                    case Quiz[] _:
                        GetQuiz((Quiz[])o);
                        break;
                    case User[] _:
                        GetList((User[])o);
                        break;
                    case Active_Question _:
                        QuestionGet((Active_Question)o);
                        break;
                    case Ping_Result _:
                        Result_Ping((Ping_Result)o);
                        break;
                    case Quiz_Start _:

                        break;
                }
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
