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
    public partial class Login : Form
    {
        Host_Connection host_;
        public Login(ref Host_Connection host)
        {
            InitializeComponent();
            host_ = host;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Standards_Final.Sessions.Login_Request request = new Standards_Final.Sessions.Login_Request();
            request.Username = MTbUsername.Text;
            request.Password = 

            throw new NotImplementedException();
        }
    }
}
