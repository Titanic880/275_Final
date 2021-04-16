﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Network
{
    /// <summary>
    /// Requests the server to check the database for the provided user
    /// </summary>
    [Serializable()]
    public class Login_Request
    {
        /// <summary>
        /// User that is being requested (unknown if they exist here)
        /// </summary>
        public Users.User ReqUser { get; set; }

        public Login_Request()
        {

        }
        public Login_Request(Users.User user)
        {
            ReqUser = user;
        }
    }
}
