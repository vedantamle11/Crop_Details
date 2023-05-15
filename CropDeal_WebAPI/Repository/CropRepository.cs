using CropDeal_WebAPI.Interface;
using CropDeal_WebAPI.Models;
using CropDeal_WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace CropDeal_WebAPI.Repository
{
    public class CropRepository : ICrop
    {
        Task<Crop> ICrop.CreateCrop(Crop crop)
        {
            throw new NotImplementedException();
        }

       Task<Crop> ICrop.DeleteCrop(int id)
        {
            throw new NotImplementedException();
        }

        Task<Crop> ICrop.GetCrop(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Crop>> ICrop.GetCrops()
        {
            throw new NotImplementedException();
        }

        Task<Crop> ICrop.UpdateCrop(int id, Crop crop)
        {
            throw new NotImplementedException();
        }
    }
}
