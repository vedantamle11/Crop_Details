using CropDeal_WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CropDeal_WebAPI.Interface
{
    public interface ICropdetail
    {
        Task<Cropdetail> CreateCrop(Cropdetail user);
        Task<IEnumerable<Cropdetail>> GetCropdetails();
        Task<Cropdetail> GetCropdetail(int id);
        Task<Cropdetail> UpdateCropdetail(int id, Cropdetail user);
        Task<Cropdetail> DeleteCropdetail(int id);
    }
}
