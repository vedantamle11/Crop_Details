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
        public DbSet<CropDisplay> CropDisplays { get; set; }
        public DbSet<CropDetails> CropDetails { get; set; }
        public DbSet<Bank_Information> BankInformation { get; set; }
    }
}
