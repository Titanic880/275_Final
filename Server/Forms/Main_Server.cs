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
