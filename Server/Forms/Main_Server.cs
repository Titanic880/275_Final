using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Net;
using System;
using Standards_Final.Network;
using Standards_Final.Sessions;
namespace Server.Forms
{
    public partial class Main_Server : Form
    {
        readonly Random rand = new Random();
        public static List<Client_Object> Clients = new List<Client_Object>();
        private Client_Object manager;
        private TcpListener tcpListener;

        public Main_Server()
        {
            InitializeComponent();
            CbIP.DataSource = Dns
                .GetHostEntry(SystemInformation.ComputerName)
                .AddressList
                .Where(x => x.AddressFamily == AddressFamily.InterNetwork)
                .ToList();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            IPAddress serverIP = (IPAddress)CbIP.SelectedValue;
            tcpListener = new TcpListener(serverIP, Standards_Final.Standards.Port);
            tcpListener.Start();

            lstError.Items.Add($"Server Started on {serverIP}:{Standards_Final.Standards.Port}");

            NewClient();
        }
        private void NewClient()
        {
            manager = new Client_Object(tcpListener);
            manager.NewClientConnected += NewClientConnected;
            manager.ClientDisconnected += ClientDisconnected;
            manager.ReceivedMessage += ReceivedMessage;
            manager.UserDef += UserDef;
            manager.Sess_New += NewSession;
        }

        private void NewSession(Client_Object client, New_Session new_)
        {
            Error er = new Error
            {
                Message = "User not found!"
            };
            if (new_.Host == null)
            {
                client.SendMessage(er);
            }
            else
            {
                string Session_ID = null;
                for (int i = 0; i > 6; i++)
                {
                    int Letter = rand.Next(26) + 65;
                    bool Upper = Convert.ToBoolean(rand.Next(0, 1));
                    if (Upper)
                        Letter += 32;

                    Session_ID += ((char)Letter).ToString();
                }
                Session_Conn Session = new Session_Conn(Session_ID);
                foreach (Session_Conn con in lstSessions.Items)
                {
                    //Checks if the session already exists
                    if (con.Session_ID == Session.Session_ID)
                    {
                        er.Message = "Invalid ID (Nice lottery~!)";
                        client.SendMessage(er);
                        return;
                    }
                }
                lstSessions.Items.Add(Session);
                Session.Is_Host = true;
                client.SendMessage(Session);
            }
        }

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
            string msg;
            if (client.User_Obj == null)
                msg = "A client has disconnected";
            else
                msg = $"{client.User_Obj.UserName} has disconnected";
            if (Clients.Remove(client))
            {
                    lstError.Items.Add(msg);
               Client_Object.ClientCounter--;
            }
        }

        private void ReceivedMessage(Client_Object client, object Item)
        {
            throw new NotImplementedException();
        }

        private void RelayMessage(object message)
        {
            //Loops through each User
            foreach (Client_Object c in Clients)
                c.SendMessage(message);
        }
    }
}
