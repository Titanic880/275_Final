using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Network
{
    [Serializable]
    public class NewQuiz
    {
        public Quizlet.Quiz newQ { get; set; }

        public NewQuiz()
        {

        }
        public NewQuiz(Quizlet.Quiz q)
            => newQ = q;
    }

}
