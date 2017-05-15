using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RaiseMyVoice.Library.Models
{
    public class AccountUser : IdentityUser<int>
    {
        public string RoleId { get; set; }
        public AccountRole Role { get; set; }
        public List<Module> ModuleCollection { get; set; } = new List<Module>();
    }
}
