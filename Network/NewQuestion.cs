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
    public class NewQuestion
    {
        /// <summary>
        /// The new Question
        /// </summary>
       public Quizlet.Question NewQ { get; set; }

        public NewQuestion()
        {

        }
        public NewQuestion(Quizlet.Question q)
            => NewQ = q;
    }
}
