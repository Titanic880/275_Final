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
using Standards_Final;

namespace Quiz_Client
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
            Standards_Final.Network.Login_Request request = new Standards_Final.Network.Login_Request
            {
                ReqUser = new Standards_Final.Users.User
                (MTbUsername.Text,
                Standards.Hasher(MTbPass.Text))
            };

            Host_.Send_To_Server(request);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Standards_Final.Network.Register_Request request = new Standards_Final.Network.Register_Request
            {
                Username = MTbUsername.Text,
                Password = Standards.Hasher(MTbPass.Text)
            };

            Host_.Send_To_Server(request);
        }

        private void BtnHostCon_Click(object sender, EventArgs e)
        => Connect(Standards_Final.Standards.GetHostIP_String());
        private void BtnConnectCustom_Click(object sender, EventArgs e)
        => Connect(TbCustomIP.Text);

        private void BtnAnon_Click(object sender, EventArgs e)
        {
            Standards_Final.Users.User_Temp tmp = new Standards_Final.Users.User_Temp
            {
                UserName = TbNick.Text,
                Session = new Standards_Final.Sessions.Session_Conn(TbSession.Text)
            };

            Host_.Send_To_Server(tmp);
        }
        #endregion Buttons
        private void Connect(string Ip)
        {
            Host_ = new Host_Connection(Ip);
            Host_.Login_Res += Host__Login_Res;
            Host_.FromServer += Host__FromServer;
            Host_.msgbox += Host__msgbox;
            Host_Connected();
        }

        private void Host__msgbox(Standards_Final.Network.Error error)
        {
            MessageBox.Show(error.Time_Of.TimeOfDay+":"+error.Message);
        }

        private void Host__FromServer(object package)
        {

        }

        private void OpenHome()
        {
            this.Hide();
            new Home().ShowDialog();
            this.Show();
        }

        #region Delegates
        private void Host_Connected()
        {
            BtnLogin.Enabled = true;
            BtnRegister.Enabled = true;
            MTbUsername.Enabled = true;
            MTbPass.Enabled = true;

            BtnAnon.Enabled = true;
            TbNick.Enabled = true;
            TbSession.Enabled = true;

            BtnConnectCustom.Enabled = false;
            BtnHostCon.Enabled = false;
            TbCustomIP.Enabled = false;
        }

        private void Host__Login_Res(Standards_Final.Network.Login_Result result)
        {
            if (result.User != null)
            {
                Active_User.Active_User_Object = result.User;
                Host_.Send_To_Server(result.User);
                if (result.New_User)
                    MessageBox.Show($"Hello and welcome to kahoot.Clone {result.User.UserName}");
                else
                    MessageBox.Show($"Hello {result.User.UserName}");

            }
            else if (result.Temp != null)
                Active_User.Active_User_Object = result.Temp;
            else
            {
                MessageBox.Show("User not found!");
                return;
            }

            //Invoke to let main thread deal with the forms
            BeginInvoke(new MethodInvoker(OpenHome));
        }
        #endregion
    }
    }
