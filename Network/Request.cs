using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Network
{
    [Serializable]
    public class Request<T>
    {
        public T Requested { get; set; }
    }
}
