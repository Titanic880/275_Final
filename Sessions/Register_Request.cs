using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Sessions
{
    //SEND A LOGIN RESULT BACK
    public class Register_Request
    {
        public string Username { get; set; }
        /// <summary>
        /// Hashed
        /// </summary>
        public string Password { get; set; }
    }
}
