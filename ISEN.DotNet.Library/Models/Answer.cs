using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RaiseMyVoice.Library.Models
{
    [Table("Answer")]
    public class Answer : BaseEntity
    {
        public bool Value { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
