using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using COMP2084_Project_200478377.Models;

namespace COMP2084_Project_200478377.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BillDetail> BillDetail { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<DeliveryDetail> DeliveryDetail { get; set; }
        public DbSet<COMP2084_Project_200478377.Models.Role> Role { get; set; }
    }
}
