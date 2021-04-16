using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Sessions
{
    /// <summary>
    /// This is sent from the server to the client to confirm a request about a session
    /// </summary>
    [Serializable]
    public class Ping_Result
    {
        public string Session_ID { get; set; }
        public bool Does_Exist { get; set; }

        public Session_ ToSession()
        {
            return new Session_(Session_ID);
        }
    }
}
