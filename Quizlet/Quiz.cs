using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Quizlet
{
    [Serializable()]
    public class Quiz
    {
        [Key]
        public int Id { get; set; }
        public Question[] Qs {get; set; }

        private string Questions_Str { get; set; }
        /// <summary>
        /// True = public, false = private
        /// </summary>
        public bool Accessiblity { get; set; }

        /// <summary>
        /// List of users with access
        /// </summary>
        public List<Users.User> AccessUsers { get; set; } = new List<Users.User>();

        public Users.User Creator { get; set; }
        public Quiz() { }
        public Quiz(Question[] questions)
        => Qs = questions;
     
        
        public void SetQuestions(Question[] Q)
        {
            string newQs = null;
            foreach (Question quest in Q)
            {
                //Sets up the first chunk of data
                string SpecInfo = $"{quest.Vis_Question}%{quest.Question_Time}";
                //Combines it all
                newQs += $"{SpecInfo}&{quest.Vis_Answers_Str}&{quest.Correct_Answers_Str}";

                //Adds onto the end ready for next Question
                newQs += "\\";
            }
            newQs.TrimEnd('\\');
            Questions_Str = newQs;
        }
        public Question[] GetQuestions()
        {
            //Build an array of the Question Objects
            string[] str_Questions = Questions_Str.Split('\\');
            List<Question> qs = new List<Question>();
            foreach(string a in str_Questions)
            {
                Question Q = new Question();
                //Splits Data to be stored
                string[] QInfo = a.Split('&');
                string[] SpecInfo = QInfo[0].Split('%');

                //Gets the Question                
                Q.Vis_Question = SpecInfo[0];
                //Gets the QTime
                Q.Question_Time = int.Parse(SpecInfo[1]);
                //Gets the Answers
                Q.Vis_Answers_Str = QInfo[1];
                //Gets the correct Answers
                Q.Correct_Answers_Str = QInfo[2];
                qs.Add(Q);
            }

            return qs.ToArray();
        }
    }
}
