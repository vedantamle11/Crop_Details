using CropDeal_WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CropDeal_WebAPI.Interface
{
    public interface IUser
    {
        Task<User> CreateUser(User user);
        Task<List<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<User> UpdateUser(int id, User user);
        Task<User> DeleteUser(int id);
    }
}
