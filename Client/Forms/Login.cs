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
        public Login()
        {
            InitializeComponent();
            LaunchForm.Host_.Login_Res += Host__Login_Res;
        }

        private void Host__Login_Res(Standards_Final.Sessions.Login_Result result)
        {
            if (result.User != null)
                Active_User.Active_User_Object = result.User;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Standards_Final.Sessions.Login_Request request = new Standards_Final.Sessions.Login_Request();
            request.Username = MTbUsername.Text;
            request.Password = Standards_Final.Standards.Hasher(MTbPass.Text);

            LaunchForm.Host_.Send_To_Server(request);
        }
    }
}
