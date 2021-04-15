using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Quizlet
{
    [Serializable()]
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public Users.User Creator { get; }
        public string Vis_Question { get; set; }

        /// <summary>
        /// 2-4 Answers
        /// </summary>
        public string Vis_Answers_Str { get; set; }
        public string[] Vis_Answers  { get { return Vis_Answers_Str.Split(','); } }

        /// <summary>
        /// Answers considered right/Correct
        /// </summary>
        public string Correct_Answers_Str { get; set; }
        public string[] Correct_Answers { get { return Correct_Answers_Str.Split(','); } }

        public DateTime Created_Question { get; set; }
        /// <summary>
        /// In Seconds
        /// </summary>
        public int Question_Time { get; set; }

        public Question()
        {

        }
        public Question(Users.User Creator)
        {
            this.Creator = Creator;
            Created_Question = DateTime.Now;
        }

        public Question(Users.User Creator, string _Question, string[] Answers, string[] Correct_Answers, DateTime Created_Date, int Timer)
        {
            this.Creator = Creator;
            Vis_Question = _Question;
            //Allows the Answer to be stored in the database
            Vis_Answers_Str = "";
            foreach (string a in Answers)
                Vis_Answers_Str += a + ",";
            Vis_Answers_Str = Vis_Answers_Str.TrimEnd(',');

            //Allows the Correct_Answer to be stored in the database
            Correct_Answers_Str = "";
            foreach (string a in Correct_Answers)
                Correct_Answers_Str += a + ",";
            Correct_Answers_Str = Correct_Answers_Str.TrimEnd(',');

            Created_Question = Created_Date;
            Question_Time = Timer;
        }

        public override string ToString()
        {
            return Vis_Question;
        }
    }
}
