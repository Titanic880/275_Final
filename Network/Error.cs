using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Network
{
    [Serializable]
    public class Error
    {
        public string Message { get; set; }
        public DateTime Time_Of { get; set; }
        public Error()
        {
            Time_Of = DateTime.Now;
        }
    }
}
