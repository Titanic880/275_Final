using System.Security.Cryptography;
using System.Windows.Forms;
using System.Text;
using System.Linq;
using System.Net;
using System;

namespace Standards_Final
{
    /// <summary>
    /// Standard of IP Protocol
    /// </summary>
    public static class Standards
    {
        #region IP
        public const int Port = 25567;
        const string ipAdd = "24.64.76.171";
        private const string SultyBoio = "123145sadfawsragdghkjdrgsd";
        /// <summary>
        /// Gets the 
        /// </summary>
        /// <returns></returns>
        public static IPAddress GetLocalIP()
        {
            IPAddress address = Dns.GetHostEntry(SystemInformation.ComputerName).AddressList
               .Where(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First();
            return address;
        }

        /// <summary>
        /// Gets hidden IP as an object
        /// </summary>
        /// <returns></returns>
        public static IPAddress GetHostIP_IPAddress()
        {
            IPAddress address = new IPAddress(ConvertIP(ipAdd));
            return address;
        }

        /// <summary>
        /// Returns hidden IP to be used
        /// </summary>
        /// <returns></returns>
        public static string GetHostIP_String()
        {
            return ipAdd;
        }

        /// <summary>
        /// Converts a string into a byte[]
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        private static byte[] ConvertIP(string address)
        {
            byte[] ret = new byte[address.Split('.').Length];
            for (int i = 0; i < ret.Length; i++)
                ret[i] = Convert.ToByte(address.Split('.')[i]);
            return ret;
        }

        //https://www.c-sharpcorner.com/article/compute-sha256-hash-in-c-sharp/ ;; Minor modifications made
        //https://passwordsgenerator.net/sha256-hash-generator/ ;; easy testing
        public static string Hasher(string plainText)
        {
            using (SHA256 hasher = SHA256.Create())
            {
                byte[] bytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(plainText+SultyBoio));
                string ret = null;
                for (int i = 0; i < bytes.Length; i++)
                    ret += bytes[i].ToString("x2");

                return ret;
            }
        }
        #endregion IP
    }
}
