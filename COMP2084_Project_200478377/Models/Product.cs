using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_Project_200478377.Models
{
    public class Product
    {
            [Required(ErrorMessage = "Product ID is required")]
            [Column(Order = 0, TypeName = "int")]
            [Key]
            public int ProductId { get; set; }


            [Required(ErrorMessage = "Please enter product code.")]
            [Column(Order = 1, TypeName = "int")]
            public int ProductCode { get; set; }

            [Required(ErrorMessage = "Product name is required")]
            [Column(Order = 2, TypeName = "nvarchar(255)")]
            public string Name { get; set; }

            [Required]
            [Column(Order = 3, TypeName = "decimal(8,2)")]
            public decimal Price { get; set; }

            [Required]
            [Column(Order = 4, TypeName = "nvarchar(255)")]
            public string Description { get; set; }

            [Required]
            [Column(Order = 5, TypeName = "int")]
            public int CategoryId { get; set; }


            [ForeignKey("CategoryId")]
            //public virtual ProductCategory ProCatIdFk { get; set; }
            public virtual ProductCategory CategoryID { get; set; }

    }
}
