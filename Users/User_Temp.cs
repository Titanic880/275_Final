using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Users
{
    [Serializable()]
    public class User_Temp : User
    {
        public Sessions.Session_Conn Session { get; set; }
    }
}
