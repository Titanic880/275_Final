using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Quizlet
{
    [Serializable()]
    public class Question
    {
        public int Id { get; set; }
        public Users.User Creator { get; }
        public string Vis_Question { get; set; }
        public string[] Vis_Answers { get; set; }
        public string[] Correct_Answers { get; set; }
        public DateTime Created_Question { get; set; }
        /// <summary>
        /// True = public, false = private
        /// </summary>
        public bool Accessiblity { get; set; }
        /// <summary>
        /// In Seconds
        /// </summary>
        public int Question_Time { get; set; }

        public Question(Users.User Creator)
        {
            this.Creator = Creator;
            Created_Question = DateTime.Now;
        }

        public Question(Users.User Creator, string _Question, string[] Answers, string[] Correct_Answers, DateTime Created_Date, int Timer)
        {
            this.Creator = Creator;
            Vis_Question = _Question;
            Vis_Answers = Answers;
            this.Correct_Answers = Correct_Answers;
            Created_Question = Created_Date;
            Question_Time = Timer;
        }
    }
}
