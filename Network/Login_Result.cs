using Standards_Final.Users;
using System;

namespace Standards_Final.Network
{
    /// <summary>
    /// Object is returned after a login is attempted
    /// </summary>
    [Serializable()]
    public class Login_Result
    {
        /// <summary>
        /// If the person was registered then signed in
        /// </summary>
        public bool New_User { get; set; } = false;

        /// <summary>
        /// The user object that is currently signed in (Actively used within the connecteds' 'Client_Object')
        /// </summary>
        public User User { get; private set; }

        public Login_Result(User u)
        {
            User = u;
        }
    }
}
