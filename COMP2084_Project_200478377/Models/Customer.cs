using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_Project_200478377.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Customer ID is required")]
        [Column(Order = 0, TypeName = "int")]
        public int CustomerId { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "nvarchar(255)")]
        public string FirstName { get; set; }

        [Required]
        [Column(Order = 2, TypeName = "nvarchar(255)")]
        public string LastName { get; set; }

        [Required]
        [Column(Order = 3, TypeName = "nvarchar(50)")]
        public string EmailId { get; set; }

        [Required]
        [Column(Order = 4, TypeName = "nvarchar(50)")]
        public string City { get; set; }

        [Required]
        [Column(Order = 5, TypeName = "int")]
        public int Phone { get; set; }
    }
}
