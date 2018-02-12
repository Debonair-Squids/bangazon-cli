//Author: Erin Agobert
//Purpose:  
using System;
using System.Collections.Generic;
using bangazon_cli;
using Xunit;
using System.Linq;

namespace bangazon_cli_test
{
    public class InvoiceManager_Should
    {
        // private DatabaseInitializer _db;
        private InvoiceManager _im;
        private ProductManager _pm;
        private CustomerManager _cm = new CustomerManager();
        private DatabaseInitializer _db;

        private void InvoiceManagerShould()
    {
      _db = new DatabaseInitializer("bangazon_cli_db_test");
      _pm = new ProductManager(_db);
      _im = new InvoiceManager(_db);

    }
            // InvoiceManager manager = new InvoiceManager();

            //Construct an invoice and line items to test
            Invoice Invoice1 = new Invoice(1,1); 

            LineItem LineItem1 = new LineItem(1,1,1);
            LineItem LineItem2 = new LineItem(2,2,2);
            LineItem LineItem3 = new LineItem(3,1,1);


            [Fact]
            public void AddInvoice()
            {
                InvoiceManagerShould();
                int result = _im.AddInvoice(Invoice1);
                Assert.Equal(1,result);
            }

            [Fact]
            public void GetInvoice()
            {
                InvoiceManagerShould();
                _im.AddInvoice(Invoice1);
                Invoice invoice = _im.GetInvoice(1);
                Assert.Equal(Invoice1, invoice);
            }

            [Fact]
            public void GetAllInvoice()
            {
                InvoiceManagerShould();
                _im.AddInvoice(Invoice1);
                List<Invoice> invoices = _im.GetAllInvoices();
                Assert.Contains(Invoice1, invoices);
            }

            //Get all lineitems on an invoice
            [Fact]
            public void GetAllLineItems()
            {
                InvoiceManagerShould();
                _im.AddInvoice(Invoice1);
                _im.AddLineItem(LineItem1);
                _im.AddLineItem(LineItem2);
                _im.AddLineItem(LineItem3);
                List<LineItem> lineitems = _im.GetAllLineItems(1);
                Assert.Contains(LineItem1, lineitems);
            }

            //Add new lineitems on an invoice
            [Fact]
            public void AddNewLineItem()
            {
                InvoiceManagerShould();
                _im.AddInvoice(Invoice1);
                _im.AddLineItem(LineItem1);
                Assert.Equal(1, LineItem1.LineItemId);
                Assert.Equal(1, LineItem1.InvoiceId);
                Assert.Equal(1, LineItem1.ProductId);
            }

    }
}