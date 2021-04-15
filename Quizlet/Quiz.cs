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
        /// <summary>
        /// True = public, false = private
        /// </summary>
        public bool Accessiblity { get; set; }

        /// <summary>
        /// List of users with access
        /// </summary>
        public List<Users.User> AccessUsers { get; set; }

        public Users.User Creator { get; set; }
        public Quiz() { }
        public Quiz(Question[] questions)
        => Qs = questions;
        
    }
}
