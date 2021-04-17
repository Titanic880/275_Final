using System.Windows.Forms;
using Standards_Final;
using System.Data;
using System.Linq;
using System.Net;
using System;

namespace Quiz_Client
{
    public partial class LaunchForm : Form
    {
        /// <summary>
        /// PRIMARY CONTROLLER OF CLIENT
        /// </summary>
        public static Host_Connection Host_ { get; private set; }

        public LaunchForm()
        {
            InitializeComponent();
            //Sets up Network IP List
            TbCustomIP.Text = Dns.GetHostEntry(SystemInformation.ComputerName).AddressList
               .Where(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First().ToString();
        }
        #region Buttons
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //Creates a login Request with the USER provided Credentials
            Standards_Final.Network.Login_Request request = new Standards_Final.Network.Login_Request
            {
                ReqUser = new Standards_Final.Users.User
                (MTbUsername.Text,
                Standards.Hasher(MTbPass.Text))
            };

            //Sends request to the server
            Host_.Send_To_Server(request);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            //Creates a register request with the USER provided Credentials
            Standards_Final.Network.Register_Request request = new Standards_Final.Network.Register_Request
            {
                Username = MTbUsername.Text,
                Password = Standards.Hasher(MTbPass.Text)
            };

            //Sends request to the server
            Host_.Send_To_Server(request);
        }

        /// <summary>
        /// Gets the interal set ip and connects to it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHostCon_Click(object sender, EventArgs e)
        => Connect(Standards.GetHostIP_String());
        /// <summary>
        /// Uses the IP from the Combo box to connect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConnectCustom_Click(object sender, EventArgs e)
        => Connect(TbCustomIP.Text);

        /// <summary>
        /// Connects as an anonomyous user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnon_Click(object sender, EventArgs e)
        {
            //Doesn't allow a blank ID
            if (!string.IsNullOrWhiteSpace(TbNick.Text.Trim()))
            {
                //Creates a user and passes it to the server
                Standards_Final.Users.User anon = new Standards_Final.Users.User
                {
                    UserName = TbNick.Text,
                    Temp = true
                };
                Host_.Send_To_Server(anon);
            }
            else
                MessageBox.Show("Please enter a nick name or login!");
        }
        #endregion Buttons
        /// <summary>
        /// Primary Method used to connect to a Server (Host)
        /// </summary>
        /// <param name="Ip"></param>
        private void Connect(string Ip)
        {
            //Creates a new 
            Host_ = new Host_Connection(Ip);
            Host_.Login_Res += Host__Login_Res;
            Host_.Connected += Connected;
        }

        private void OpenHome()
        {
            this.Hide();
            new Home().ShowDialog();
            Host_.Active_User = null;
            this.Show();
        }

        #region Delegates
        private void Connected()
        {
            //Makes main thread deal with the work :D
            BeginInvoke(new MethodInvoker(C_Connected));
        }
        private void C_Connected()
        {
            //User connection Stuff
            BtnLogin.Enabled = true;
            BtnRegister.Enabled = true;
            MTbUsername.Enabled = true;
            MTbPass.Enabled = true;
            //Anonymous connection stuff
            BtnAnon.Enabled = true;
            TbNick.Enabled = true;
            //TCP Connection stuff
            BtnConnectCustom.Enabled = false;
            BtnHostCon.Enabled = false;
            TbCustomIP.Enabled = false;
        }

        private void Host__Login_Res(Standards_Final.Network.Login_Result result)
        {
            if (result.User != null)
            {
                //Sets the Client User
                Host_.Active_User = result.User;
                if(!result.User.Temp)
                    Host_.Send_To_Server(result.User);
                //Checks if the person is a new user
                if (result.New_User)
                    MessageBox.Show($"Hello and welcome to kahoot.Clone {result.User.UserName}");
                else
                    MessageBox.Show($"Hello {result.User.UserName}");
            }
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
