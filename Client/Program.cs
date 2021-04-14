using System.Windows.Forms;
using Client.Forms;
using System;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LaunchForm frm = new LaunchForm();
            Application.Run(frm);
            LaunchForm.Host_.Send_To_Server(new Standards_Final.Sessions.DisconnectUser());
            frm.Dispose();
        }
    }
}
