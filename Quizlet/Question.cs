using System.ComponentModel.DataAnnotations;
using System;

namespace Standards_Final.Quizlet
{
    /// <summary>
    /// The Primary question object that is stored in the database
    /// </summary>
    [Serializable()]
    public class Question
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// ID of the creator
        /// </summary>
        public int Creator_ID { get; }
        /// <summary>
        /// 
        /// </summary>
        public string Vis_Question { get; set; }

        /// <summary>
        /// The set of 2-4 options in the Question
        /// </summary>
        public string Vis_Answers_Str { get; set; }
        /// <summary>
        /// Array of options
        /// </summary>
        public string[] Vis_Answers  { get { return Vis_Answers_Str.Split(','); } }

        /// <summary>
        /// The correct options
        /// </summary>
        public string Correct_Answers_Str { get; set; }
        /// <summary>
        /// Array of correct options
        /// </summary>
        public string[] Correct_Answers { get { return Correct_Answers_Str.Split(','); } }

        /// <summary>
        /// DateTime of when the Question was created
        /// </summary>
        public DateTime Created_Question { get; set; }
        /// <summary>
        /// Duration the test should run in seconds
        /// </summary>
        public int Question_Time { get; set; }

        public Question()
        {

        }
        public Question(int CreatorID)
        {
            this.Creator_ID = CreatorID;
            Created_Question = DateTime.Now;
        }

        /// <summary>
        /// Used by Active_Question
        /// </summary>
        /// <param name="q"></param>
        public Question(Question q)
        {
            this.Id = q.Id;
            this.Creator_ID = q.Creator_ID;
            Vis_Question = q.Vis_Question;
            Vis_Answers_Str = q.Vis_Answers_Str;
            Correct_Answers_Str = q.Correct_Answers_Str;
            Created_Question = q.Created_Question;
            Question_Time = q.Question_Time;
        }

        /// <summary>
        /// Primary way of filling a question
        /// </summary>
        /// <param name="CreatorID"></param>
        /// <param name="_Question"></param>
        /// <param name="Answers"></param>
        /// <param name="Correct_Answers"></param>
        /// <param name="Created_Date"></param>
        /// <param name="Timer"></param>
        public Question(int CreatorID, string _Question, string[] Answers, string[] Correct_Answers, DateTime Created_Date, int Timer)
        {
            this.Creator_ID = CreatorID;
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

        /// <summary>
        /// HURDUR
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Vis_Question;
        }
    }
}
