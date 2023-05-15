using CropDeal_WebAPI.Interface;
using CropDeal_WebAPI.Models;
using CropDeal_WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace CropDeal_WebAPI.Repository
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext context;
        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<User> CreateUser(User user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return user;
        }
        public async Task<List<User>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }
        public async Task<User> DeleteUser(int id)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Userid == id);
            if (user == null)
            {
                return null;
            }
            context.Users.Remove(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUser(int id, User i)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            user.Userid = id;
            user.UserName = i.UserName;
            user.Password = i.Password;
            user.UserEmail_id = i.UserEmail_id;
            user.UserContact = i.UserContact;
            
            user.UserAddress = i.UserAddress;
            user.UserRoles = i.UserRoles;
            user.Is_Suscribed = i.Is_Suscribed;
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            return user;
        }
    }
}
