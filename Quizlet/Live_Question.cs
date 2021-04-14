using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Quizlet
{
    public class Live_Question : Question
    {
        public Live_Question(Users.User Creator)
        :base(Creator)
        {
            
        }
        public Live_Question(Users.User Creator, string _Question, string[] Answers, string[] Correct_Answers, DateTime Created_Date, int Timer)
        :base(Creator,_Question,Answers,Correct_Answers,Created_Date,Timer)
        {
            
        }
    }
}
