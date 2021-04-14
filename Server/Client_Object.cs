using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Standards_Final.Sessions;
using System.Threading.Tasks;
using Standards_Final.Users;
using System.ComponentModel;
using System.Net.Sockets;
using System.Text;
using System.Linq;
using System.IO;
using System;
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

        //Handles user messages
        public event ReceivedMessageEventHandler ReceivedMessage;
        public delegate void ReceivedMessageEventHandler(Client_Object client, object Item);

        //Runs when the user class is assigned
        public event UserDefined UserDef;
        public delegate void UserDefined(Client_Object client);
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
            Client_Listener = listener;
            ClientCounter++;

            wkr.WorkerReportsProgress = true;
            wkr.DoWork += Incoming;
            wkr.ProgressChanged += Sorting;

            //Runs worker
            wkr.RunWorkerAsync();
        }

        private void Incoming (object sender, DoWorkEventArgs e)
        {
            //Makes sure the socket is connected
            C_Socket = Client_Listener.AcceptSocket();
            //Creates the user Connection objects
            wkr.ReportProgress(0);

            if (C_Socket == null)
                return;

            C_nStream = new NetworkStream(C_Socket);
            if (C_nStream == null)
                return;

            C_reader = new BinaryReader(C_nStream);
            C_writer = new BinaryWriter(C_nStream);

            IFormatter formatter = new BinaryFormatter();

            while (!wkr.CancellationPending)
            {
                //Error checking
                if (C_reader == null)
                    continue;
                else if (C_reader.BaseStream == null)
                    continue;

                //Distrobution of information
                object o = formatter.Deserialize(C_reader.BaseStream);
                if (o is null)
                    continue;
                else if (o is DisconnectUser DU)
                    wkr.ReportProgress(1, DU);
                else if (o is User U)
                    wkr.ReportProgress(2, U);
            }
        }

        private void Sorting(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 0:
                    NewClientConnected(this);
                    break;
                case 1:
                    ClientDisconnected(this);
                    break;
                case 2:
                    this.User_Obj = (User)e.UserState;
                    UserDef(this);
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
            }
        }

        public void SendMessage(object Msg)
        {
            if (Msg == null)
                return;

            else if (C_writer == null)  //Checks for writer, if its null wait a second for initilization attempt
            {
                System.Threading.Thread.Sleep(1000);
                if (C_writer == null)
                    return;
            }

            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(C_writer.BaseStream, Msg);
        }

    }
}
