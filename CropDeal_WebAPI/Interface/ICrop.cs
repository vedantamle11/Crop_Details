using CropDeal_WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CropDeal_WebAPI.Interface
{
    public interface ICrop
    {
        Task<Crop> CreateCrop(Crop crop);
        Task<List<Crop>> GetCrops();
        Task<Crop> GetCrop(int id);
        Task<Crop> UpdateCrop(int id, Crop crop);
        Task<Crop> DeleteCrop(int id);
    }
}
