using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Sessions
{
    [Serializable]
    /// <summary>
    /// Sends a request to the server to see if the session exists
    /// </summary>
    public class Ping_Request
    {
        /// <summary>
        /// The session that you want the server to compare against
        /// </summary>
        public string Session_ID { get; set; }
    }
}
