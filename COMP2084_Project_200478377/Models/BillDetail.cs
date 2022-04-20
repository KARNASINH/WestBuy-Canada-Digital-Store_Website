using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_Project_200478377.Models
{
    public class BillDetail
    {
        [Required(ErrorMessage = "Bill Id is required")]
        [Column(Order = 0, TypeName = "int")]
        [Key]
        public int BillId { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "int")]
        public int BillNumber { get; set; }

        [Required]
        [Column(Order = 2, TypeName = "int")]
        public int Quantity { get; set; }

        [Required]
        [Column(Order = 3, TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        [Required]
        [Column(Order = 4, TypeName = "int")]
        public int SKU { get; set; }

        [Required]
        [Column(Order = 5, TypeName = "decimal(5,2)")]
        public decimal Discount { get; set; }

    }
}
