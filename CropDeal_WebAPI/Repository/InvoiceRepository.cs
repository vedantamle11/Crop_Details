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
            return invoice;
        }

        public async Task<List<Invoice>> GetInvoices()
        {
            var invoices = await context.Invoices.ToListAsync();
            return invoices;
        }

        public async Task<Invoice> UpdateInvoice(int id, Invoice invoice)
        {
            var database_invoice = await context.Invoices.FindAsync(id);
            if (database_invoice == null)
            {
                return null;
            }

            database_invoice.Quantity = invoice.Quantity;
            database_invoice.Price = invoice.Price;
            database_invoice.Payment_Mode = invoice.Payment_Mode;
            database_invoice.Status = invoice.Status;
            database_invoice.Date_created = invoice.Date_created;

            await context.SaveChangesAsync();

            return database_invoice;
        }
    }
}
