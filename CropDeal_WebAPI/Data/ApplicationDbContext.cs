using Microsoft.EntityFrameworkCore;
using CropDeal_WebAPI.Models;

namespace CropDeal_WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Crop> Crops { get; set; }
        public DbSet<Cropdetail> Cropdetails { get; set; }
        public DbSet<Bankdetails> Bankdetails { get; set; }
    }
}
