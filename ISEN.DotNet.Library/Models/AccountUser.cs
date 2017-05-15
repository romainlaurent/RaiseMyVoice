using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RaiseMyVoice.Library.Models
{
    public class AccountUser : IdentityUser
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
