using CropDeal_WebAPI.DTO;
using CropDeal_WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CropDeal_WebAPI.Interface
{
    public interface IBankdetail
    {
        Task<Bankdetail> CreateBank_acc(Bankdetaildto user);
        Task<IEnumerable<Bankdetail>> GetBankdetails();

        Task<IEnumerable<Bankdetail>> GetUserwithBankdetails();
        Task<Bankdetail> GetBankdetail(int id);
        Task<Bankdetail> UpdateBankdetail(int id, Bankdetail user);
        Task<Bankdetail> DeleteBank_acc(int id);
    }
}
