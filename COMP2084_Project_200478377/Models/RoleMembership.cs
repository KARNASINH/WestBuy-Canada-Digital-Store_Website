using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_Project_200478377.Models
{
    public class RoleMembership
    {
        public IdentityRole Role { get; set; }
        public ICollection<IdentityUser> Members { get; set; }
        public ICollection<IdentityUser> NonMembers { get; set; }
    }
}
