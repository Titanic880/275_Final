using System;

namespace Standards_Final.Network
{
    /// <summary>
    /// Object that is sent to the server when client asks to register the credentials
    /// </summary>
    [Serializable()]
    public class Register_Request
    {
        /// <summary>
        /// PlainText
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Hashed
        /// </summary>
        public string Password { get; set; }
    }
}
