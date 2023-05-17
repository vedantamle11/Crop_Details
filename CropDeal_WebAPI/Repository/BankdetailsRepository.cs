using CropDeal_WebAPI.Data;
using CropDeal_WebAPI.DTO;
using CropDeal_WebAPI.Interface;
using CropDeal_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CropDeal_WebAPI.Repository
{
    public class BankdetailsRepository : IBankdetail
    {
        private readonly ApplicationDbContext context;

        public BankdetailsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Bankdetail> CreateBank_acc(Bankdetaildto user)
        {
            var Bank=new Bankdetail();
            Bank.Bank_Name = user.Bank_Name;
            Bank.Bank_Account_No = user.Bank_Account_No;
            Bank.IFSC=user.IFSC;
            Bank.User_id = user.Userid;
            await context.Bankdetails.AddAsync(Bank);
            await context.SaveChangesAsync();

            return Bank;
        }

        public async Task<Bankdetail> DeleteBank_acc(int id)
        {
            var user = await context.Bankdetails.FirstOrDefaultAsync(p=>p.BankDetail_id==id);

            if (user == null)
            {
                return null;
            }

            context.Bankdetails.Remove(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<Bankdetail> GetBankdetail(int id)
        {
            var user = await context.Bankdetails.FindAsync(id);
            if(user == null) 
            {
                return null;
            }
            return user;
        }
        public async Task<IEnumerable<Bankdetail>> GetBankdetails()
        {
            return await context.Bankdetails.ToListAsync();
        }

        public async Task<IEnumerable<Bankdetail>> GetUserwithBankdetails()
        {
            return await context.Bankdetails.Include(p=>p.User).ToListAsync();
        }

        public async Task<Bankdetail> UpdateBankdetail(int id, Bankdetail user)
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
