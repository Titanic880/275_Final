using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Network
{
    [Serializable]
    public class NewQuestion
    {
       public Quizlet.Question NewQ { get; set; }

        public NewQuestion()
        {

        }
        public NewQuestion(Quizlet.Question q)
            => NewQ = q;
    }
}
