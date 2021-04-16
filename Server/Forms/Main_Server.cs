using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Data;
using System.Linq;
using System.Net;
using System;

using Standards_Final.Sessions;

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
            //Grabs the ip and starts the listener
            IPAddress serverIP = (IPAddress)CbIP.SelectedValue;
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
            manager.UserDef += UserDef;
            manager.Sess_New += NewSession;
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
                    bool Upper = Convert.ToBoolean(rand.Next(0, 1));
                    if (Upper)
                        Letter += 32;

                    Session_ID += ((char)Letter).ToString();
                }

                //Builds a session and compares it against all in list
                Session_Conn Session = new Session_Conn(Session_ID);
                foreach (Session_Conn con in lstSessions.Items)
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
                client.SendMessage(Session);
            }
        }

        /// <summary>
        /// Runs when a client logs in with a User
        /// </summary>
        /// <param name="client"></param>
        private void UserDef(Client_Object client)
        {
            RelayMessage($"{client.User_Obj.UserName} has connected!");
        }

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

        private void RelayMessage(object message)
        {
            //Loops through each User
            foreach (Client_Object c in Clients)
                c.SendMessage(message);
        }
    }
}
