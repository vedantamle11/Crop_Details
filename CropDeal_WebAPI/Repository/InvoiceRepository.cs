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
    public class InvoiceRepository : IInvoice
    {
        private readonly ApplicationDbContext context;

        public InvoiceRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Invoice> CreateInvoice(Invoice invoice)
        {
            await context.Invoices.AddAsync(invoice);
            await context.SaveChangesAsync();
            return invoice;
        }

        public async Task<Invoice> DeleteInvoice(int id)
        {
            var invoice = await context.Invoices.FindAsync(id);
            if (invoice == null)
            {
                return null;
            }

            context.Invoices.Remove(invoice);
            await context.SaveChangesAsync();

            return invoice;
        }

        public async Task<Invoice> GetInvoice(int id)
        {
            var invoice = await context.Invoices.FindAsync(id);
            if(invoice==null)
            {
                return null;
            }
            return invoice;
        }

        public async Task<IEnumerable<Invoice>> GetInvoices()
        {
            return await context.Invoices.ToListAsync();
            
        }
  
    }
}
