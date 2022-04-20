using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_Project_200478377.Models
{
    public class ProductCategory
    {
        [Required(ErrorMessage = "Category ID is required")]
        [Column(Order = 0, TypeName = "int")]
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Enter Category Description.")]
        [Column(Order = 1, TypeName = "nvarchar(255)")]
        public string CategoryDescription { get; set; }

        [Required]
        [Column(Order = 2, TypeName = "nvarchar(5)")]
        public string Aisle { get; set; }

        [Required]
        [Column(Order = 3, TypeName = "nvarchar(25)")]
        public string ProductType { get; set; }

        [Required]
        [Column(Order = 4, TypeName = "nvarchar(15)")]
        public string Status { get; set; }

        [Required]
        [Column(Order = 5, TypeName = "nvarchar(5)")]
        public string Discount { get; set; }
    }
}
