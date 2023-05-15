using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CropDeal_WebAPI.Interface;
using CropDeal_WebAPI.Models;
using CropDeal_WebAPI.Data;

namespace CropDeal_WebAPI.Repository
{
    public class AdminRepository : IAdmin
    {
        private readonly ApplicationDbContext context;

        public AdminRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Admin>> GetAllAdmins()
        {
            return await context.Admins.ToListAsync();
        }

        public async Task<Admin> GetAdminById(int id)
        {
            return await context.Admins.FindAsync(id);
        }

        public async Task AddAdmin(Admin admin)
        {
            await context.Admins.AddAsync(admin);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAdmin(int id, Admin admin)
        {
            var adminToUpdate = await context.Admins.FindAsync(id);
            if (adminToUpdate == null)
            {
                return;
            }

            adminToUpdate.Admin_name = admin.Admin_name;
            adminToUpdate.Admin_Contact = admin.Admin_Contact;
            adminToUpdate.Admin_email = admin.Admin_email;
            adminToUpdate.Admin_password = admin.Admin_password;

            await context.SaveChangesAsync();
        }

        public async Task DeleteAdmin(int id)
        {
            var admin = await context.Admins.FindAsync(id);
            if (admin == null)
            {
                return;
            }

            context.Admins.Remove(admin);
            await context.SaveChangesAsync();
        }
    }
}
