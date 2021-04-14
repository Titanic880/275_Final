using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debugging_Tool.DEBUG
{ 
    public static class Standards
    {
        public const int Port = 25567;
        static byte[] ip;
        const string ipAdd = "24.64.76.171";
        private const string SultyBoio = "123145sadfawsragdghkjdrgsd";

        public static IPAddress GetLocalIP()
        {
            IPAddress address = Dns.GetHostEntry(SystemInformation.ComputerName).AddressList
               .Where(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First();

            return address;
        }

        public static IPAddress GetHostIP()
        {
            ip = convertIP(ipAdd);
            IPAddress address = new IPAddress(ip);

            return address;
        }

        private static byte[] convertIP(string address)
        {
            byte[] ret = new byte[address.Split('.').Length];
            for (int i = 0; i < ret.Length; i++)
                ret[i] = Convert.ToByte(address.Split('.')[i]);
            
            return ret;
        }

        //https://www.c-sharpcorner.com/article/compute-sha256-hash-in-c-sharp/ ;; Minor modifications made
        public static string Hasher(string plainText)
        {
            using (SHA256 hasher = SHA256.Create())
            {
                byte[] bytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(plainText + SultyBoio));
                string ret = null;
                for (int i = 0; i < bytes.Length; i++)
                    ret += bytes[i].ToString("x2");

                return ret;
            }

        }
    }
}
