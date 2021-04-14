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
        public static User Host_Client { get; set; }

        #region Server
        public static bool Server_Login(Login_Request request)
        {
            //Checks for null/Empty request
            bool ret = false;
            if (request == null)
                return ret;

            Host_Client = null;

            //Checks the database for the user
            using (Server_DbContext db = new Server_DbContext())
            {
                Host_Client = db.Db_Users
                    .Where(x => x.UserName == request.ReqUser.UserName
                    && x.Password == request.ReqUser.Password).FirstOrDefault());
            }

            if (Host_Client != null)
                ret = true;
            
            return ret;
        }

        public static bool Server_Register(Register_Request request)
        {
            using (Server_DbContext db = new Server_DbContext())
            {
                User newUser = new User
                {
                    UserName = request.Username,
                    Password = request.Password
                };

                User Test = db.Db_Users
                    .Where(x => x.UserName == newUser.UserName
                    && x.Password == newUser.Password).FirstOrDefault();
                if (Test != null)
                {
                    return false;
                }

                db.Db_Users.Add(newUser);
                db.SaveChanges();

                return Server_Login(new Login_Request(newUser));
            }
        }
        #endregion

        #region Client
        public static Login_Result Client_Login(Login_Request request)
        {
            //Checks for null/Empty request
            if (request == null)
                return new Login_Result(null); 

            Login_Result ret = null;

            //Checks the database for the user
            using (Server_DbContext db = new Server_DbContext())
            {
                ret = new Login_Result(db.Db_Users
                    .Where(x => x.UserName == request.ReqUser.UserName
                    && x.Password == request.ReqUser.Password).FirstOrDefault());
            }
            if(ret == null)
            {
                ret = new Login_Result(null);
            }
            return ret;
        }

        public static Login_Request Client_Register(Register_Request request)
        {
            using (Server_DbContext db = new Server_DbContext())
            {
                User newUser = new User
                {
                    UserName = request.Username,
                    Password = request.Password
                };

                User Test = db.Db_Users
                    .Where(x => x.UserName == newUser.UserName
                    && x.Password == newUser.Password).FirstOrDefault();
                if(Test != null)
                {
                    return new Login_Request();
                }

                db.Db_Users.Add(newUser);
                db.SaveChanges();

                return new Login_Request(newUser);
            }
        }
        #endregion Client
    }
}
