using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Users
{
    [Serializable()]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        /// <summary>
        /// Hashed
        /// </summary>
        public string Password { get; set; }
        public Sessions.Session_Conn Current_Session { get; set; }

        public User()
        {

        }
        public User(string Username, string Pass)
        {
            this.UserName = Username;
            this.Password = Pass;
        }
    }
}
