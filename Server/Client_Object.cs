﻿using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Standards_Final.Sessions;
using Standards_Final.Network;
using System.Threading.Tasks;
using Standards_Final.Users;
using System.ComponentModel;
using Server.Framework_Ent;
using System.Net.Sockets;
using System.Text;
using System.Linq;
using System.IO;
using System;
using Standards_Final.Quizlet;

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
                else if (o is DisconnectUser DisU)
                    wkr.ReportProgress(1, DisU);
                else if (o is User U)
                    wkr.ReportProgress(2, U);
                else if (o is Register_Request ResReq)
                    wkr.ReportProgress(3, ResReq);
                else if (o is Login_Request LReq)
                    wkr.ReportProgress(4, LReq);
                else if (o is New_Session NSes)
                    wkr.ReportProgress(6, NSes);
                else if (o is NewQuestion || o is NewQuiz)
                    wkr.ReportProgress(7, o);
                else if (o is Request<Quiz[]>)
                    wkr.ReportProgress(8, o);
                else if (o is Request<Question[]>)
                    wkr.ReportProgress(9,o);
            }
        }

        private void Sorting(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 0: //User connect
                    NewClientConnected(this);
                    break;
                case 1: //User Disconnect
                    ClientDisconnected(this);
                    break;
                case 2:
                    this.User_Obj = (User)e.UserState;
                    UserDef(this);
                    break;
                case 3: //Register Request
                    SendMessage(Server_DbLogic.Client_Register((Register_Request)e.UserState));
                    break;
                case 4: //Login Request
                    SendMessage(Server_DbLogic.Client_Login((Login_Request)e.UserState));
                    break;
                case 5: //Temp User Connecting to session
                    break;
                case 6: //Request for a new session 
                    Sess_New(this, (New_Session)e.UserState);
                    break;
                case 7:
                    if (e.UserState is NewQuestion)
                        Server_DbLogic.Add_Question(((NewQuestion)e.UserState).NewQ);
                    else if (e.UserState is NewQuiz)
                        Server_DbLogic.Add_Quiz(((NewQuiz)e.UserState).newQ);
                    break;
                case 8:
                    this.SendMessage(Server_DbLogic.Get_Quiz(this.User_Obj));
                    break;
                case 9:
                    this.SendMessage(Server_DbLogic.Get_Questions());
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
