using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RaiseMyVoice.Library.Models
{
    [Table("Question")]
    public class Question : BaseEntity
    {
        public int SubjectId { get; set; }
        public Subject Sujet { get; set; }

        public List<Person> PersonCollection { get; set; } = new List<Person>();
        public List<Answer> AnswerCollection { get; set; } = new List<Answer>();
    }
}
