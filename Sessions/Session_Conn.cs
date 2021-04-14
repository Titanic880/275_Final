using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Sessions
{
    [Serializable()]
    public class Session_Conn
    {
        public string Session_ID { get; set; }

        public Session_Conn(string ID)
        => Session_ID = ID;
    }
}
