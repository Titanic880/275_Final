using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Client_Object
    {
        public static TcpListener Client_Listener;

        //Client ID
        public static int ClientCounter;
        public string Client_Name;
        public int Client_ID;

        #region Delegates 


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
            Client_ID++;

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

            }
        }

        private void Sorting(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

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
    }
}
