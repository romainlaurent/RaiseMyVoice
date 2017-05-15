using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RaiseMyVoice.Library.Models
{
    public class AccountRole : IdentityRole<int>
    {
        public string Description { get; set; }
    }
}
