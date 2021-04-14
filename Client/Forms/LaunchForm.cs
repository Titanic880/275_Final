using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void BtnHostCon_Click(object sender, EventArgs e)
        {
            connect(Standards_Final.Standards.GetHostIP_String());
        }
        private void BtnConnectCustom_Click(object sender, EventArgs e)
        {
            connect(TbCustomIP.Text);
        }

        private void connect(string Ip)
        {
            Host_ = new Host_Connection(Ip);
            Host_.Connected += Host_Connected;

        }

        private void Host_Connected()
        {
            BtnLogin.Enabled = true;
            BtnRegister.Enabled = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
        }
    }
}
