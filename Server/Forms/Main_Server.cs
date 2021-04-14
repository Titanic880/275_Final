using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Forms
{
    public partial class Main_Server : Form
    {
        public static Standards_Final.Users.User Host_Client { get; set; }
        public static List<Client_Object> Clients = new List<Client_Object>();
        private readonly Client_Object manager;
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
        }
        private void NewClient()
        {
           // Mngr_NewClientConnected;
           // Mngr_ClientDisconnected;
           // Mngr_ReceivedMessage;
           // Mngr_ReceivedFile;
           // Mngr_SetUserName;
           // Mngr_RecievedCommand;
        }
    }
}
