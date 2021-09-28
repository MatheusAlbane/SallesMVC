using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesMVC.Models;

namespace SalesMVC.Data
{
    public class SalesMVCContext : DbContext
    {
        public SalesMVCContext (DbContextOptions<SalesMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesMVC.Models.Departament> Departament { get; set; }
        public DbSet<SalesMVC.Models.Seller> Seller { get; set; }
        public DbSet<SalesMVC.Models.SalesRecord> SalesRecord { get; set; }
    }
}
