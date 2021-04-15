﻿using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Net.Sockets;
using System.Text;
using System.Linq;
using System.IO;
using System;
using Standards_Final.Network;
using Standards_Final.Sessions;

namespace Quiz_Client
{
    public class Host_Connection
    {
        private readonly string IPAddress;

        #region Delegates
        //Recieves data from the server
        public event RecievedFromServer FromServer;
        public delegate void RecievedFromServer(object package);

        public event ResultLogin Login_Res;
        public delegate void ResultLogin(Login_Result result);

        public event RecievedQuiz GetQuiz;
        public delegate void RecievedQuiz(Standards_Final.Quizlet.Quiz le_Quiz);

        public event RecievedQuestion QuestionGet;
        public delegate void RecievedQuestion(Standards_Final.Quizlet.Question Q);

        public event Session GetSession;
        public delegate void Session(Session_Conn session);
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

            wkr.RunWorkerAsync();
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

                if (o is Login_Result LR)
                    Login_Res(LR);
                else if (o is Standards_Final.Quizlet.Quiz Q)
                    GetQuiz(Q);
                else if (o is Session_Conn ses)
                    GetSession(ses);
                else if (o is Standards_Final.Quizlet.Question q)
                    QuestionGet(q);
                else
                    FromServer(o);
            }
        }

        /// <summary>
        /// Sends the object to the server
        /// </summary>
        /// <param name="package"></param>
        public void Send_To_Server(object package)
        {
            if (package == null || writer == null)
                return;

            IFormatter stream = new BinaryFormatter();
            stream.Serialize(writer.BaseStream, package);
        }
    }
}