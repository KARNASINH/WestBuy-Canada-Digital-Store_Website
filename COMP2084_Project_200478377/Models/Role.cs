using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_Project_200478377.Models
{
    public class Role
    {
        [Required]
        [MinLength(3, ErrorMessage = "Role must be at least 3 characters")]
        [Key]
        public string RoleName { get; set; }
    }
}
