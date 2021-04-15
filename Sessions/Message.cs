using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Standards_Final.Users;

namespace Standards_Final.Sessions
{
    /// <summary>
    /// A Standard message, if Session is Null then it sends to everyone
    /// </summary>
    [Serializable]
    class Message
    {
        public User Sender { get; set; }
        public string Text { get; set; }
        public Session_Conn Session { get; set; } = null;

        public Message(User sender, string message, bool Sess = false)
        {
            Sender = sender;
            Text = message;
            if(Sess)
                Session = Sender.Current_Session;
        }
    }
}
