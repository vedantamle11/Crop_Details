﻿using CropDeal_WebAPI.Data;
using CropDeal_WebAPI.Interface;
using CropDeal_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CropDeal_WebAPI.Repository
{
    public class BankdetailsRepository : IBankdetails
    {
        private readonly ApplicationDbContext context;

        public BankdetailsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Bankdetails> CreateBank_acc(Bankdetails user)
        {
            await context.Bankdetails.AddAsync(user);
            await context.SaveChangesAsync();

            return user;
        }

        public async Task<Bankdetails> DeleteBank_acc(int id)
        {
            var user = await context.Bankdetails.FirstOrDefaultAsync(x=>x.BankDetail_id==id);

            if (user == null)
            {
                return null;
            }

            context.Bankdetails.Remove(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<Bankdetails> GetBankdetails(int id)
        {
            var user = await context.Bankdetails.FindAsync(id);
            if(user == null) 
            {
                return null;
            }
            return user;
        }
        public async Task<List<Bankdetails>> GetBankdetails()
        {
            return await context.Bankdetails.ToListAsync();
        }

        public async Task<Bankdetails> UpdateBankdetails(int id, Bankdetails user)
        {
            var bankDetailsToUpdate = await context.Bankdetails.FindAsync(id);

            if (bankDetailsToUpdate == null)
            {
                return null;
            }
            bankDetailsToUpdate.BankDetail_id = id;
            bankDetailsToUpdate.Bank_Name = user.Bank_Name;
            bankDetailsToUpdate.Bank_Account_No = user.Bank_Account_No;
            bankDetailsToUpdate.IFSC = user.IFSC;

            await context.SaveChangesAsync();

            return bankDetailsToUpdate;
        }

        
    }
}
