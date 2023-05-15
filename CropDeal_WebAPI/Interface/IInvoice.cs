﻿using CropDeal_WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CropDeal_WebAPI.Interface
{
    public interface IInvoice
    {
        Task<Invoice> CreateInvoice(Invoice invoice);
        Task<List<Invoice>> GetInvoices();
        Task<Invoice> GetInvoice(int id);
        Task<Invoice> UpdateInvoice(int id, Invoice invoice);
        Task<Invoice> DeleteInvoice(int id);
    }
}
