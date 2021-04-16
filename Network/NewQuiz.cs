using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Network
{
    /// <summary>
    /// Object that is sent to the server when they make a new Question to be added to the database
    /// </summary>
    [Serializable]
    public class NewQuiz
    {
        /// <summary>
        /// The new Quiz
        /// </summary>
        public Quizlet.Quiz newQ { get; set; }

        public NewQuiz()
        {

        }
        public NewQuiz(Quizlet.Quiz q)
            => newQ = q;
    }

}
