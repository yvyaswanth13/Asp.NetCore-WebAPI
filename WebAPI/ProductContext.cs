using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI
{
    public class ProductContext:DbContext
    {
        public ProductContext() : base()
        {

        }
        public ProductContext(DbContextOptions<ProductContext> options): base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=eurofins;Trusted_Connection=True;");
            }
        }

        public DbSet<Product> products { get; set; }
       
    }
}
