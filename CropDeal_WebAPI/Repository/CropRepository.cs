using CropDeal_WebAPI.Interface;
using CropDeal_WebAPI.Models;
using CropDeal_WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace CropDeal_WebAPI.Repository
{
    public class CropRepository : ICrop
    {
        private readonly ApplicationDbContext context;

        public CropRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Crop> CreateCrop(Crop user)
        {
            await context.Crops.AddAsync(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<Crop> DeleteCrop(int id)
        {
            var user = await context.Crops.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            context.Crops.Remove(user); 
            await context.SaveChangesAsync();   
            return user;
        }


        public async Task<Crop> GetCrop(int id)
        {
            var user = await context.Crops.FindAsync(id);
            if(user== null)
            {
                return null;
            }
            return user;
        }


        public async Task<IEnumerable<Crop>> GetCrops()
        {
            return await context.Crops.ToListAsync();
        }

        

        public async Task<Crop> UpdateCrop(int id, Crop user)
        {
            var existingCrop = await context.Crops.FindAsync(id);
            if (existingCrop == null)
            {
                return null;
             
            }
            existingCrop.Crop_name = user.Crop_name;
            existingCrop.Cropid =id;
            existingCrop.Crop_Image = user.Crop_Image;
            await context.SaveChangesAsync();
            return existingCrop;
        }

        
    }

}

