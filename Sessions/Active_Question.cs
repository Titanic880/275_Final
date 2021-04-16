using Standards_Final.Quizlet;
using Standards_Final.Users;

namespace Standards_Final.Sessions
{
    /// <summary>
    /// The question that is sent to connected clients for a quiz
    /// </summary>
    public class Active_Question : Question
    {
        /// <summary>
        /// What session to send the question to
        /// </summary>
        public Session_ Session { get; set; }
        /// <summary>
        /// Who is sending/Who not to send the question to
        /// </summary>
        public User Host { get; set; }
    }
}
