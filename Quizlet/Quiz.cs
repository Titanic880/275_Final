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

        public Quiz(Question[] questions)
        => Qs = questions;
        
    }
}
