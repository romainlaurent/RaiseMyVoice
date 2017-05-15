using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RaiseMyVoice.Library.Models
{
    [Table("Module")]
    public class Module : BaseEntity
    {
        public string Location { get; set; }
        public List<Question> QuestionCollection { get; set; } = new List<Question>();

        public int AccountUserId { get; set; }
        public AccountUser AccountUser { get; set; }
    }
}
