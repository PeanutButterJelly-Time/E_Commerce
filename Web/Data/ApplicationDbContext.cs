using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Models.Identity;
using Web.Models.Products;

namespace Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions options) :base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Shoe>()
                .HasData(
                    new Shoe { Id = -1, Name = "AJ1", Manufacturer = "Jordan", Style = Style.Mid },
                    new Shoe { Id = -2, Name = "AJ5", Manufacturer = "Jordan", Style = Style.High },
                    new Shoe { Id = -3, Name = "AJ13", Manufacturer = "Jordan" }
                );


        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cereal> Cereals { get; set; }
        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<Beer> Beer { get; set; }
    }
}
