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
            Random rand = new Random();
            string Session_ID = null;
            for (int i = 0; i < 6; i++)
            {
                int Letter = rand.Next(26) + 65;
                bool Upper = Convert.ToBoolean(rand.Next(2));
                if (Upper)
                    Letter += 32;

                Session_ID += ((char)Letter).ToString();
            }

            Console.WriteLine(Session_ID);
            Console.ReadLine();
        }
    }
}
