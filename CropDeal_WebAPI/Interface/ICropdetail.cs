using CropDeal_WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CropDeal_WebAPI.Interface
{
    public interface ICropdetail
    {
        Task<Cropdetail> CreateCrop_acc(Cropdetail user);
        Task<List<Cropdetail>> GetCropdetails();
        Task<Cropdetail> GetCropdetail(int id);
        Task<Cropdetail> UpdateCropdetail(int id, Cropdetail user);
        Task<Cropdetail> DeleteCrop_acc(int id);
    }
}
