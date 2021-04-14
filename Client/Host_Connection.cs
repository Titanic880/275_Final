using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Net.Sockets;
using System.Text;
using System.Linq;
using System.IO;
using System;

namespace Client
{
    public class Host_Connection
    {
        private string IPAddress;

        #region Delegates
        //Runs when connection is made
        public event ConnEst Connected;
        public delegate void ConnEst();

        #endregion Delegates

        //User Stack
        private TcpClient tcpClient;
        private NetworkStream nStream;
        private BinaryWriter writer;

        readonly private BackgroundWorker wkr = new BackgroundWorker();

        public Host_Connection(string IP)
        {
            IPAddress = IP;

            wkr.WorkerSupportsCancellation = true;
            wkr.DoWork += MainLoop;
        }



        private void MainLoop(object s, DoWorkEventArgs e)
        {
            tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress, Standards_Final.Standards.Port);

            nStream = tcpClient.GetStream();

            if (nStream == null)
                return;

            writer = new BinaryWriter(nStream);
            IFormatter Stream = new BinaryFormatter();

            while (!wkr.CancellationPending)
            {
                if (nStream == null)
                    continue;
                object o = Stream.Deserialize(nStream);

            }
        }
    }
}
