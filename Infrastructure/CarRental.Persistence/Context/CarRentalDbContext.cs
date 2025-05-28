using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Persistence.Context
{
    public class CarRentalDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CarRentalDb;Integrated Security=True;TrustServerCertificate=True; ");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner1> Banner1s { get; set; }
        public DbSet<Banner2> Banner2s { get; set; }
        public DbSet<Banner3> Banner3s { get; set; }
        public DbSet<BrandIcon> BrandIcons { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<CarDetail> CarDetails { get; set; }

    }
}
