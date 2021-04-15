using Standards_Final.Users;
using System;

namespace Standards_Final.Network
{
    [Serializable()]
    public class Login_Result
    {
        public bool New_User { get; set; } = false;
        public User User { get; private set; }
        public User_Temp Temp { get; set; }

        public Login_Result(User u)
        {
            User = u;
        }
    }
}
