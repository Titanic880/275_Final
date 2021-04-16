using Standards_Final.Quizlet;
using Standards_Final.Users;

namespace Standards_Final.Sessions
{
    /// <summary>
    /// The object that is sent to the participates which is forwarded to the server by the host 
    /// Server Fills out Participants and Questions
    /// </summary>
    public class Quiz_Start
    {
        /// <summary>
        /// The Quiz that will be used
        /// </summary>
        public Quiz The_Quiz { get; set; }
        /// <summary>
        /// The user file of the Host
        /// </summary>
        public User Host { get; set; }

        /// <summary>
        /// List of those that are participating in the quiz
        /// </summary>
        public User[] Participatants { get; set; }

        public Question[] Quiz_Questions { get; set; }

        public Session_ Active_Session { get; set; }
    }
}
