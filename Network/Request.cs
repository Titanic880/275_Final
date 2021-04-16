using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Network
{
    /// <summary>
    /// Sends a Blank Request to the server, with the object type being the seperator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class Request<T>
    {
        public T Requested { get; set; }
    }
}
