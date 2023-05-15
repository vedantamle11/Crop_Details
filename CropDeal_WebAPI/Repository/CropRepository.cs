using CropDeal_WebAPI.Interface;
using CropDeal_WebAPI.Models;
using CropDeal_WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace CropDeal_WebAPI.Repository
{
    public class CropRepository : ICrop
    {
        private readonly ApplicationDbContext _context;

        public CropRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Crop> CreateCrop(Crop crop)
        {
            _context.Crops.Add(crop);
            await _context.SaveChangesAsync();
            return crop;
        }

        public async Task<List<Crop>> GetCrops()
        {
            return await _context.Crops.ToListAsync();
        }

        public async Task<Crop> GetCrop(int id)
        {
            return await _context.Crops.FindAsync(id);
        }

        public async Task<Crop> UpdateCrop(int id, Crop crop)
        {
            var existingCrop = await _context.Crops.FindAsync(id);
            if (existingCrop != null)
            {
                existingCrop.Crop_name = crop.Crop_name;
                existingCrop.Crop_id = crop.Crop_id;
                existingCrop.Crop_Image = crop.Crop_Image;
                await _context.SaveChangesAsync();
            }
            return existingCrop;
        }

        public async Task<Crop> DeleteCrop(int id)
        {
            var existingCrop = await _context.Crops.FindAsync(id);
            if (existingCrop != null)
            {
                _context.Crops.Remove(existingCrop);
                await _context.SaveChangesAsync();
            }
            return existingCrop;
        }
    }

}

