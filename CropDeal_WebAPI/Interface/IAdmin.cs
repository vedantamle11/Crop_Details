using CropDeal_WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CropDeal_WebAPI.Interface
{
    public interface IAdmin
    {
        Task<Admin> GetAdminById(int id);
        Task<List<Admin>> GetAllAdmins();
        Task AddAdmin(Admin admin);
        Task UpdateAdmin(int id, Admin admin);
        Task DeleteAdmin(int id);
    }
}
