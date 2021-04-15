using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Standards_Final.Users;
using Standards_Final.Network;

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
                    && x.Password == request.ReqUser.Password).FirstOrDefault();
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
        public static Login_Result Client_Login(Login_Request request, bool newUser = false)
        {
            //Checks for null/Empty request
            if (request == null)
                return new Login_Result(null);
            if (request.ReqUser == null)
                return new Login_Result(null);

            Login_Result ret = null;

            //Checks the database for the user
            using (Server_DbContext db = new Server_DbContext())
            {
                ret = new Login_Result(db.Db_Users
                    .Where(x => x.UserName == request.ReqUser.UserName
                    && x.Password == request.ReqUser.Password).FirstOrDefault());
            }
            if (ret == null)
            {
                ret = new Login_Result(null);
            }
            ret.New_User = newUser;
            return ret;
        }

        public static Login_Result Client_Register(Register_Request request)
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
                    return Client_Login(new Login_Request(Test));


                db.Db_Users.Add(newUser);
                db.SaveChanges();
                return Client_Login(new Login_Request(newUser), true);
            }
        }
        #endregion Client

        #region Questions

        public static void Add_Question(Standards_Final.Quizlet.Question question)
        {
            using (Server_DbContext db = new Server_DbContext())
            {
                //Adds question if it doesn't already exist
                if (!db.Db_Questions.Contains(question))
                    db.Db_Questions.Add(question);
                db.SaveChanges();
            }
        }

        public static Standards_Final.Quizlet.Question[] Get_Questions()
        {
            Standards_Final.Quizlet.Question[] arr;
            using (Server_DbContext db = new Server_DbContext())
            {
                arr = db.Db_Questions.ToArray();
            }
            return arr;
        }
        #endregion Questions
        #region Quiz
        public static void Add_Quiz(Standards_Final.Quizlet.Quiz quiz)
        {
            using (Server_DbContext db = new Server_DbContext())
            {
                //Adds quiz if it doesn't already exist
                if (!db.Db_Quizzes.Contains(quiz))
                    db.Db_Quizzes.Add(quiz);
                db.SaveChanges();
            }
        }
        public static Standards_Final.Quizlet.Quiz[] Get_Quiz(User user = null)
        {
            Standards_Final.Quizlet.Quiz[] arr;
            using (Server_DbContext db = new Server_DbContext()) 
            {
                if (user == null)
                    arr = db.Db_Quizzes.Where(x => x.Accessiblity == true).ToArray();
                else
                    arr = db.Db_Quizzes.Where(x => x.Accessiblity == true 
                                            ||x.AccessUsers.Contains(user)).ToArray();
            }
            return arr;
        }

        #endregion Quiz
    }
}
