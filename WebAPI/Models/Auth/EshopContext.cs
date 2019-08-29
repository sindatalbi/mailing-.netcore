using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class EshopContext : IdentityDbContext
    {
        public EshopContext(DbContextOptions options) : base(options)
        {

        }

        // Creating Roles for the application
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                    new { Id = "1", Name = "SuperAdmin", NormalizedName = "SUPERADMIN" },
                    new { Id = "2", Name = "Admin", NormalizedName = "ADMIN" }
                );
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
