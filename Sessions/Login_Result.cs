﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Standards_Final.Users;

namespace Standards_Final.Sessions
{
    public class Login_Result
    {
        public User User { get; private set; }

        public Login_Result(User u)
        {
            User = u;
        }
    }
}
