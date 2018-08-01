using System;
using System.Collections.Generic;
using System.Text;
using MedicalPlus.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicalPlus.Data
{
    public class MedicalPlusContext : IdentityDbContext<ApplicationUser>
    {
        public MedicalPlusContext(DbContextOptions<MedicalPlusContext> options)
            : base(options)
        {

         
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Appointment>().HasKey(x => new { x.DoctorID, x.ApplicationUserId });
        }
    }
}
