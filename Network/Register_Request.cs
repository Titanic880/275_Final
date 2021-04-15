using System;

namespace Standards_Final.Network
{
    [Serializable()]
    //SEND A LOGIN RESULT BACK
    public class Register_Request
    {
        public string Username { get; set; }
        /// <summary>
        /// Hashed
        /// </summary>
        public string Password { get; set; }
    }
}
