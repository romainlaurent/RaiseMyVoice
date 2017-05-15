using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RaiseMyVoice.Library.Models
{
    [Table("User")]
    public class User : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [ForeignKey("AccountUser")]
        public string AccountUserId { get; set; }
        public virtual AccountUser AccountUser { get; set; }

        public List<Module> ModuleCollection{ get; set; } = new List<Module>();

        public override string ToString() =>
            $"{base.ToString()}|FirstName={FirstName}|LastName={LastName}";
    }
}
