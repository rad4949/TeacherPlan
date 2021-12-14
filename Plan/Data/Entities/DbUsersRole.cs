using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Data.Entities
{
    public class DbUserRole : IdentityUserRole<long>
    {
        public virtual DbRole Role { get; set; }
        public virtual DbUser User { get; set; }
    }
}
