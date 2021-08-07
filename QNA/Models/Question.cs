using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QNA.Models
{
    public class Question
    {
        [Key]
        [DisplayName("Question ID")]
        public int QuestionId { get; set; }

        [DisplayName("Question")]
        public string QuestionName { get; set; }

        [DisplayName("Category ID")]
        public int CategoryId { get; set; }

        [DisplayName("Posted By")]
        public String name { get; set; }

        public virtual Category Category { get; set; }
    }
}
