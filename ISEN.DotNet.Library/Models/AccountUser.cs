using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RaiseMyVoice.Library.Models
{
    public class AccountUser : IdentityUser<int>
    {
        public List<Module> ModuleCollection { get; set; } = new List<Module>();
    }
}
