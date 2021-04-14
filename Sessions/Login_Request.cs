using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Sessions
{
    [Serializable()]
    public class Login_Request
    {
        public Users.User ReqUser { get; set; }

        public Login_Request()
        {

        }
        public Login_Request(Users.User user)
        {
            ReqUser = user;
        }
    }
}
