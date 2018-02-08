using System;
using Xunit;

namespace bangazon_cli_test
{
    public class AddProdToCustOrder_Should
    {

        [Fact]
        public void AddProdToCustOrder()
        {
            /*
            -Given a customer has been made active in the program
            -When the user selects the option to add a product to the active customer's order
            -Then the user should be prompted with a numbered list of all products
            -And when one is chosen, the product should be added to an order for the active customer*/
            
            Invoice newInvoice = new Invoice();
            
            newInvoice.InvoiceId = 1;
            newInvoice.CustomerPaymentId = 1;
            newInvoice.CustomerId = 1;
            newInvoice.InvoiceDate = DateTime.Now;
        }
    }
}