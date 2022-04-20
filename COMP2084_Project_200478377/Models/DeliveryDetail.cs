using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_Project_200478377.Models
{
    public class DeliveryDetail
    {
        [Required(ErrorMessage = "Delivery Detail ID is required")]
        [Column(Order = 0, TypeName = "int")]
        [Key]
        public int DeliveryId { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "nvarchar(255)")]
        public string ShippingAddress { get; set; }

        [Required]
        [Column(Order = 2, TypeName = "nvarchar(10)")]
        public string OrderDate { get; set; }

        [Required]
        [Column(Order = 3, TypeName = "nvarchar(10)")]
        public string DeliveryDate { get; set; }

        [Required]
        [Column(Order = 4, TypeName = "int")]
        public int BillId { get; set; }

        [Required]
        [Column(Order = 5, TypeName = "int")]
        public int CustomerId { get; set; }

        [ForeignKey("BillId")]
        public virtual BillDetail BillID { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer CustomerID { get; set; }
    }
}
