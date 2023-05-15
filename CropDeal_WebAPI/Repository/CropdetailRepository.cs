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

        public async Task<Cropdetail> CreateCrop_acc(Cropdetail cropdetail)
        {
            await context.Cropdetails.AddAsync(cropdetail);
            await context.SaveChangesAsync();
            return cropdetail;
        }

        public async Task<Cropdetail> DeleteCrop_acc(int id)
        {
            var cropdetail = await context.Cropdetails.FindAsync(id);
            if (cropdetail == null)
            {
                return null;
            }

            context.Cropdetails.Remove(cropdetail);
            await context.SaveChangesAsync();
            return cropdetail;
        }

        public async Task<Cropdetail> GetCropdetail(int id)
        {
            var cropdetail = await context.Cropdetails.FindAsync(id);
            return cropdetail;
        }

        public async Task<List<Cropdetail>> GetCropdetails()
        {
            var cropdetails = await context.Cropdetails.ToListAsync();
            return cropdetails;
        }

        public async Task<Cropdetail> UpdateCropdetail(int id, Cropdetail cropdetail)
        {
            var existingCropdetail = await context.Cropdetails.FindAsync(id);

            if (existingCropdetail == null)
           
                return null;
            existingCropdetail.Crop_Details_id= id;
            existingCropdetail.Crop_Name = cropdetail.Crop_Name;
            existingCropdetail.Crop_Details_Description = cropdetail.Crop_Details_Description;
            existingCropdetail.Crop_Type = cropdetail.Crop_Type;
            existingCropdetail.Quantity = cropdetail.Quantity;
            existingCropdetail.Location = cropdetail.Location;

            await context.SaveChangesAsync();

            return existingCropdetail;
        }

    }
}
