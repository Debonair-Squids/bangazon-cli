using System;
using Xunit;

namespace bangazon_cli_test
{
    public class AddProdToCustOrder_Should
    {

        [Fact]
        public void AddProdToCustOrder()
        {
            //Construct an invoice, products, and line items to test
            Invoice Invoice1 = new Invoice();
            Invoice1.InvoiceId = 1;
            Invoice1.CustomerPaymentId = 1;
            Invoice1.CustomerId = 1;
            Invoice1.InvoiceDate = DateTime.Now;

            Product Product1 = new Product();
            Product1.ProductId = 1;
            Product1.Title = "The Sims";
            Product1.Description = "The Sims base game pack"
            Product1.Quantity = 1;
            Product1.DateCreated = DateTime.Now;

            Product Product2 = new Product();
            Product1.ProductId = 2;
            Product1.Title = "Destiny 2";
            Product1.Description = "Destiny, an xbox one game"
            Product1.Quantity = 1;
            Product1.DateCreated = DateTime.Now;

            LineItem LineItem1 = new LineItem();
            LineItem1.LineItemId = 1;
            LineItem1.InvoiceId = 1;
            LineItem1.ProductId = 1;

            LineItem LineItem2 = new LineItem();
            LineItem1.LineItemId = 2;
            LineItem1.InvoiceId = 1;
            LineItem1.ProductId = 2;

            LineItem LineItem3 = new LineItem();
            LineItem1.LineItemId = 3;
            LineItem1.InvoiceId = 1;
            LineItem1.ProductId = 1;
            
            /*
            -Given a customer has been made active in the program
            -When the user selects the option to add a product to the active customer's order
            -Then the user should be prompted with a numbered list of all products
            -And when one is chosen, the product should be added to an order for the active customer
            */
        }
    }
}