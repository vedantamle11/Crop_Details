using CropDeal_WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CropDeal_WebAPI.Interface
{
    public interface IBankdetails
    {
        Task<Bankdetails> CreateBank_acc(Bankdetails user);
        Task<List<Bankdetails>> GetBankdetails();
        Task<Bankdetails> GetBankdetails(int id);
        Task<Bankdetails> UpdateBankdetails(int id, Bankdetails user);
        Task<Bankdetails> DeleteBank_acc(int id);
    }
}
