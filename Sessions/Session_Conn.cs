using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Sessions
{
    [Serializable()]
    public class Session_Conn
    {
        [Key]
        public string Session_ID { get; set; }
        public bool Is_Host { get; set; } = false;

        public Session_Conn()
        {

        }
        public Session_Conn(string ID)
        => Session_ID = ID;
    }
}
