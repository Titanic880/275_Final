using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class LaunchForm : Form
    {
        public static Host_Connection Host_ { get; private set; }
        public LaunchForm()
        {
            InitializeComponent();
            TbCustomIP.Text = Dns.GetHostEntry(SystemInformation.ComputerName).AddressList
               .Where(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First().ToString();
        }
        #region Buttons
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Standards_Final.Sessions.Login_Request request = new Standards_Final.Sessions.Login_Request
            {
                Username = MTbUsername.Text,
                Password = Standards_Final.Standards.Hasher(MTbPass.Text)
            };

            Host_.Send_To_Server(request);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Standards_Final.Sessions.Register_Request request = new Standards_Final.Sessions.Register_Request
            {
                Username = MTbUsername.Text,
                Password = Standards_Final.Standards.Hasher(MTbPass.Text)
            };

            Host_.Send_To_Server(request);
        }

        private void BtnHostCon_Click(object sender, EventArgs e)
        {
            Connect(Standards_Final.Standards.GetHostIP_String());
        }
        private void BtnConnectCustom_Click(object sender, EventArgs e)
        {
            Connect(TbCustomIP.Text);
        }
        #endregion Buttons
        private void Connect(string Ip)
        {
            Host_ = new Host_Connection(Ip);
            Host_.Connected += Host_Connected;
            Host_.Login_Res += Host__Login_Res;
        }

        #region Delegates
        private void Host_Connected()
        {
            BtnLogin.Enabled = true;
            BtnRegister.Enabled = true;
        }

        private void Host__Login_Res(Standards_Final.Sessions.Login_Result result)
        {
            if (result.User != null)
                Active_User.Active_User_Object = result.User;
        }
        #endregion
    }
}
