//Author: Erin Agobert
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace bangazon_cli
{

    public class InvoiceManager
    {
        private List<Invoice> _invoices = new List<Invoice>();

        private DatabaseInitializer _db;

        public InvoiceManager(DatabaseInitializer db)
        {
            _db = db;
        }

        //Method to add a new invoice and return InvoiceId #
        public int AddInvoice(Invoice invoice)
        {
            // _invoices.Add(invoice);
            int id = _db.Insert($"insert into Invoice values (null, '{invoice.CustomerPaymentId}', '{invoice.CustomerId}', '{invoice.InvoiceDate}') ");
        return id;
        }

        //Method to get a single invoice
        public Invoice GetInvoice(int id){
           return  _invoices.Where(i => i.InvoiceId == id).Single();
        }
        //Method to get all invoices
        public List<Invoice> GetAllInvoices(){
           return  _invoices;
        }

        public List<LineItem> _lineitems = new List<LineItem>();

        //Method to add a new line item
        public void AddLineItem(LineItem lineitem){
            _lineitems.Add(lineitem);
        }

        //Method to return all line items associated with an invoice
        public List<LineItem> GetAllLineItems(int id){
            return  _lineitems.Where(i => i.InvoiceId == id).ToList();
        }


    }
}