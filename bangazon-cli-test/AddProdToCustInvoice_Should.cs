//Author: Erin Agobert
using System;
using System.Collections.Generic;
using bangazon_cli;
using Xunit;

namespace bangazon_cli_test
{
    public class AddProdToCustOrder_Should
    {
            InvoiceManager manager = new InvoiceManager();

            //Construct an invoice and line items to test
            Invoice Invoice1 = new Invoice(1,1,1);

            LineItem LineItem1 = new LineItem(1,1,1);
            LineItem LineItem2 = new LineItem(2,2,2);
            LineItem LineItem3 = new LineItem(3,1,1);


            [Fact]
            public void AddInvoice()
            {
                Assert.Equal(1,Invoice1.InvoiceId);
                Assert.Equal(1,Invoice1.CustomerPaymentId);
                Assert.Equal(1,Invoice1.CustomerId);
            }

            [Fact]
            public void GetInvoice(){
              manager.AddInvoice(Invoice1);
              Invoice invoice = manager.GetInvoice(1);
              Assert.Equal(Invoice1, invoice);
            }

            [Fact]
            public void GetAllInvoice(){
                manager.AddInvoice(Invoice1);
                List<Invoice> invoices = manager.GetAllInvoices();
                Assert.Contains(Invoice1, invoices);
            }

            //Get all lineitems on an invoice
            [Fact]
            public void GetAllLineItems(){
                manager.AddInvoice(Invoice1);
                manager.AddLineItem(LineItem1);
                manager.AddLineItem(LineItem2);
                manager.AddLineItem(LineItem3);
                List<LineItem> lineitems = manager.GetAllLineItems(1);
                Assert.Contains(LineItem1, lineitems);
            }

            //Add new lineitems on an invoice
            [Fact]
            public void AddNewLineItem(){
                manager.AddInvoice(Invoice1);
                manager.AddLineItem(LineItem1);
                Assert.Equal(1, LineItem1.LineItemId);
                Assert.Equal(1, LineItem1.InvoiceId);
                Assert.Equal(1, LineItem1.ProductId);
            }

    }
}