using CropDeal_WebAPI.Interface;
using CropDeal_WebAPI.Models;
using CropDeal_WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CropDeal_WebAPI.Repository
{
    public class CropRepository : ICrop
    {
        private readonly ApplicationDbContext context;

        public CropRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Crop> CreateCrop(Crop crop)
        {
            await context.Crops.AddAsync(crop);
            await context.SaveChangesAsync();
            return crop;
        }

        public async Task<Crop> DeleteCrop(int id)
        {
            var crop = await context.Crops.FindAsync(id);
            if (crop == null)
            {
                return null;
            }
            context.Crops.Remove(crop);
            await context.SaveChangesAsync();
            return crop;
        }

        public async Task<Crop> GetCrop(int id)
        {
            return await context.Crops.FindAsync(id);
        }

        public async Task<IEnumerable<Crop>> GetCrops()
        {
            return await context.Crops.ToListAsync();
        }

        public async Task<Crop> UpdateCrop(int id, Crop crop)
        {
            var existingCrop = await context.Crops.FindAsync(id);
            if (existingCrop == null)
            {
                return null;
            }
            
            existingCrop.Crop_name = crop.Crop_name;
            existingCrop.Crop_Image = crop.Crop_Image;
            await context.SaveChangesAsync();
            return existingCrop;
        }
    }
}
