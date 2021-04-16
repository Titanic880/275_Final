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
        /// <summary>
        /// Who requested a new Session
        /// </summary>
        public User Host { get; set; }

        /// <summary>
        /// Whether or not the session can be found within a list of public sessions (:: UNIMPLEMENTED ::)
        /// </summary>
        public bool Is_Public { get; set; } = false;
    }
}
