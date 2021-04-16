﻿using System.ComponentModel.DataAnnotations;
using System;

namespace Standards_Final.Sessions
{
    /// <summary>
    /// Main Object of determining who/where to send Data such as Active_Questions
    /// </summary>
    [Serializable()]
    public class Session_Conn
    {
        /// <summary>
        /// The String used to connect to the Session
        /// </summary>
        [Key]
        public string Session_ID { get; set; }

        /// <summary>
        /// Whether or not the user is the host
        /// </summary>
        public bool Is_Host { get; set; } = false;

        #region Constructors
        public Session_Conn()
        {

        }
        public Session_Conn(string ID)
        => Session_ID = ID;

        #endregion Constructors
    }
}
