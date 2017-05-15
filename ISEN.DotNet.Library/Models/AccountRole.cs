using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RaiseMyVoice.Library.Models
{
    public class AccountRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
