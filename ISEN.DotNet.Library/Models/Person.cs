using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RaiseMyVoice.Library.Models
{
    [Table("Person")]
    public class Person : BaseEntity
    {
        [RegularExpression("([0-9a-fA-F]{2}:){5}[0-9a-fA-F]{2}")]
        public string MacAddress { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
