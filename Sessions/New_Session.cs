using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Standards_Final.Users;

namespace Standards_Final.Sessions
{
    [Serializable]
    /// <summary>
    /// used to request a new session from the server
    /// </summary>
    public class New_Session
    {
        public User Host { get; set; }
        public Session_Conn Session_ID { get; set; }
        public bool Is_Public { get; set; } = false;
    }
}
