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

namespace Server.Forms
{
    public partial class Main_Server : Form
    {
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
            string msg = null;
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
