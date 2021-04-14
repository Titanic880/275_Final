using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Standards_Final.Users;
using Standards_Final.Sessions;

namespace Server.Framework_Ent
{
    public static class Server_DbLogic
    {
        public static Standards_Final.Users.User Host_Client { get; set; }

        public static Login_Result Login_Request(Login_Request request)
        {
            Login_Result ret = null;

            //Checks the database for the user
            using (Server_DbContext db = new Server_DbContext())
            {
                ret = new Login_Result(db.Db_Users
                    .Where(x => x.UserName == request.Username
                    && x.Password == request.Password).FirstOrDefault());
            }
            if(ret == null)
            {
                ret = new Login_Result(null);
            }
            return ret;
        }

    }
}
