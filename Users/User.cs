﻿using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Users
{
    /// <summary>
    /// Main User Object in database and use
    /// </summary>
    [Serializable()]
    public class User
    {
        /// <summary>
        /// Main ID of the user
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// The user focused name
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Hashed version of the password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// if the user is anon or not
        /// </summary>
        public bool Temp { get; set; }

        /// <summary>
        /// Total correct answers so far in the quiz
        /// </summary>
        public int Current_Score { get; set; }
        /// <summary>
        /// Total wrong answers so far in the Quiz
        /// </summary>
        public int Wrong_Score { get; set; }
        
        public string stuff { get { return $"{UserName}: C: {Current_Score} W: {Wrong_Score}"; } }

        /// <summary>
        /// What session they are currently Active in
        /// </summary>
        public Sessions.Session_ Current_Session { get; set; }

        #region Constructors
        public User()
        {

        }
        public User(string Username, string Pass)
        {
            this.UserName = Username;
            this.Password = Pass;
        }
        #endregion Constructors
    }
}
