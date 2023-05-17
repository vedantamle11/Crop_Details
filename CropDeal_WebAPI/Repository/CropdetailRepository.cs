using CropDeal_WebAPI.Data;
using CropDeal_WebAPI.Interface;
using CropDeal_WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CropDeal_WebAPI.Repository
{
    public class CropdetailRepository : ICropdetail
    {
        private readonly ApplicationDbContext context;

        public CropdetailRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Cropdetail> CreateCrop(Cropdetail user)
        {
            await context.Cropdetails.AddAsync(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<Cropdetail> DeleteCropdetail(int id)
        {
            var user = await context.Cropdetails.FindAsync(id);
            if (user == null)
            {
                return null;
            }

            context.Cropdetails.Remove(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<Cropdetail> GetCropdetail(int id)
        {
            var user = await context.Cropdetails.FindAsync(id);
            if(user==null)
            {
                return null;
            }
            return user;
        }

        public async Task<IEnumerable<Cropdetail>> GetCropdetails()
        {
            return await context.Cropdetails.ToListAsync();
            
        }

        public async Task<Cropdetail> UpdateCropdetail(int id, Cropdetail user)
        {
            var existingCropdetail = await context.Cropdetails.FindAsync(id);

            if (existingCropdetail == null)
            {
                return null;
            }
           
            existingCropdetail.Crop_Details_id= id;
            existingCropdetail.Crop_Name = user.Crop_Name;
            existingCropdetail.Crop_Details_Description = user.Crop_Details_Description;
            existingCropdetail.Crop_Type = user.Crop_Type;
            existingCropdetail.Quantity = user.Quantity;
            existingCropdetail.Location = user.Location;
            existingCropdetail.Price= user.Price;   

            await context.SaveChangesAsync();

            return existingCropdetail;
        }

    }
}
