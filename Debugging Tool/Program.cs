using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Debugging_Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress IP = DEBUG.Standards.GetLocalIP();
            Console.WriteLine(DEBUG.Standards.Hasher("Hello"));
            Console.ReadLine();
        }
    }
}
