using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Data;
using System.Linq;
using System.Net;
using System;

using Standards_Final.Sessions;
using Standards_Final.Network;
using Standards_Final.Quizlet;

using Server.Framework_Ent;
using Standards_Final.Users;

namespace Server.Forms
{
    public partial class Main_Server : Form
    {
        //List of active Clients
        public static List<Client_Object> Clients = new List<Client_Object>();

        readonly Random rand = new Random();
        
        //Primary Stream listener
        private TcpListener tcpListener;
        //Main object that is duplicated
        private Client_Object manager;

        public Main_Server()
        {
            InitializeComponent();
            //Gets the local IP to host on
            CbIP.DataSource = Dns
                .GetHostEntry(SystemInformation.ComputerName)
                .AddressList
                .Where(x => x.AddressFamily == AddressFamily.InterNetwork)
                .ToList();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            BtnStart.Enabled = false;
            //Grabs the ip and starts the listener
            IPAddress serverIP = (IPAddress)CbIP.SelectedValue;
            if (tcpListener != null)
            {
                MessageBox.Show("Already started!");
                return;
            }    
            
                tcpListener = new TcpListener(serverIP, Standards_Final.Standards.Port);
                tcpListener.Start();

            lstError.Items.Add($"Server Started on {serverIP}:{Standards_Final.Standards.Port}");

            NewClient();
        }
        private void NewClient()
        {
            //Generates and sets up a new client for when one connects
            manager = new Client_Object(tcpListener);
            manager.NewClientConnected += NewClientConnected;
            manager.ClientDisconnected += ClientDisconnected;
            manager.Sess_New += NewSession;
            manager.UserDef += UserDef;
            manager.Start_Quiz += Manager_Start_Quiz;
            manager.scores += Manager_scores;
            manager.pong += Manager_pong;
        }

        #region Delegates
        private void NewClientConnected(Client_Object client)
        {
            Clients.Add(client);
            lstError.Items.Add($"{Clients.Count-1} has connected");
            NewClient();
        }
        
        private void ClientDisconnected(Client_Object client)
        {
            //Checks to see if a user was assigned to a client
            string msg;
            if (client.User_Obj == null)
                msg = "A client has disconnected";
            else
                msg = $"{client.User_Obj.UserName} has disconnected";
            
            //Attempts to remove the client from the list of clients
            if (Clients.Remove(client))
            {
                    lstError.Items.Add(msg);
               Client_Object.ClientCounter--;
            }
        }
        
        private void NewSession(Client_Object client, New_Session new_)
        {
            //DEPRECIATED?
            if (new_.Host == null)
                return;            
            else
            {
                //Generates a random session ID (6 Char long with 52 options per)
                string Session_ID = null;
                for (int i = 0; i < 6; i++)
                {
                    int Letter = rand.Next(26) + 65;
                    bool Upper = Convert.ToBoolean(rand.Next(2));
                    if (Upper)
                        Letter += 32;

                    Session_ID += ((char)Letter).ToString();
                }

                //Builds a session and compares it against all in list
                Session_ Session = new Session_(Session_ID);
                foreach (Session_ con in lstSessions.Items)
                {
                    //Checks if the session already exists
                    if (con.Session_ID == Session.Session_ID)
                    {
                        return;
                    }
                }

                //If session is not found then it adds it to the list and sends it back to the host
                lstSessions.AccessibleName = "Session_ID";
                lstSessions.Items.Add(Session);
                Session.Is_Host = true;
                client.User_Obj.Current_Session = Session;
                client.SendMessage(Session);
            }
        }
        
        /// <summary>
        /// Runs when a client logs in with a User
        /// </summary>
        /// <param name="client"></param>
        private void UserDef(Client_Object client)
        {
            if (client.User_Obj.Temp)
                client.SendMessage(new Login_Result(client.User_Obj));
        }

        private void Manager_Start_Quiz(Quiz_Start _Start)
        {
            //Gets the Array of questions
            string[] Str_Ids = _Start.The_Quiz.Questions_Str.Split(',');
            Question[] questions = new Question[Str_Ids.Length];
            for (int i = 0; i < Str_Ids.Length; i++)
                if (int.TryParse(Str_Ids[i], out int ID))
                    questions[i] = Server_DbLogic.Get_Specific_Question(ID);
                else
                    lstUMessage.Items.Add($"Session {_Start.Active_Session.Session_ID} Tried to access non existent Question with ID {Str_Ids[i]}");

            //Assigns the questions to the quiz
            _Start.Quiz_Questions = questions;

            List<User> users = new List<User>();
            //Loads the users that are in the session
            foreach (Client_Object a in Clients)
                if (_Start.Host.Id != a.User_Obj.Id)
                    if (a.User_Obj.Current_Session.Session_ID == _Start.Active_Session.Session_ID)
                        users.Add(a.User_Obj);

            _Start.Participatants = users.ToArray();

            //Sends the final session to the users
            foreach (Client_Object a in Clients)
                if (a.User_Obj.Current_Session.Session_ID == _Start.Active_Session.Session_ID)
                    a.SendMessage(_Start);
        }

        private void Manager_scores(Score_Update _Update)
        {
            //Sends the update for the client to deal with (INCLUDES HOST)
            foreach(Client_Object a in Clients)
                if(a.User_Obj.Current_Session == _Update.user.Current_Session)
                {
                    a.SendMessage(_Update);
                }
        }


        private void Manager_pong(Client_Object client, Ping_Request ping)
        {
            Session_ ses = new Session_(ping.Session_ID);
            foreach (Session_ a in lstSessions.Items)
            {
                if(a.Session_ID == ses.Session_ID)
                {
                    Ping_Result res = new Ping_Result
                    {
                        Does_Exist = true,
                        Session_ID = a.Session_ID
                    };
                    client.User_Obj.Current_Session = ses;
                    client.SendMessage(res);
                }
            }
        }

        #endregion Delegates

        private void RelayMessage(object message)
        {
            //Loops through each User
            foreach (Client_Object c in Clients)
                c.SendMessage(message);
        }
    }
}
