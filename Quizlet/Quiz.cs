using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards_Final.Quizlet
{
    /// <summary>
    /// Collection of Questions
    /// </summary>
    [Serializable()]
    public class Quiz
    {
        /// <summary>
        /// MAIN DB ID
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// List of Question Id's
        /// </summary>
        public string Questions_Str { get; set; }

        /// <summary>
        /// True = public, false = private
        /// </summary>
        public bool Accessiblity { get; set; }

        /// <summary>
        /// List of users with access
        /// </summary>
        public string AccessUsers { get; set; }

        /// <summary>
        /// User.Id of the creator
        /// </summary>
        public int Creator_ID { get; set; }

        public Quiz() { }
       
        /*
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
            newQs = newQs.TrimEnd('\\');
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
        }*/
    }
}
