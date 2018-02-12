using System;
using Xunit;
using bangazon_cli;
using System.Collections.Generic;

namespace bangazon_cli_test
{
    public class CustomerShould
    {
    private Customer _customer = new Customer(
                "Erin",
                "Egobert",
                "123 ok Rd.",
                "Nashville",
                "TN",
                "37210",
                "aaaahhhhhh"
            );
    private InvoiceManager _im;
    private ProductManager _pm;
    private DatabaseInitializer _db;
    private CustomerManager _cm;
    private void CustomerManagerShould()
    {
        _db = new DatabaseInitializer("bangazon_cli_db_test");
        _cm = new CustomerManager(_db);
    }
        // ADD CUSTOMER TEST
        [Fact]
        public void AddCustomer()
        {
            CustomerManagerShould();
            Customer Pippins = new Customer();
            int result = _cm.AddCustomer(Pippins);
            Assert.True(result > 0);
        }
        // GET All Customers
        [Fact]
        public void GetAllCustomers()
        {
            CustomerManagerShould();
            CustomerManager newCustomer = new CustomerManager(_db);
            newCustomer.AddCustomer(_customer);
            List<Customer> allCustomers = newCustomer.GetAllCustomers();
            int result = newCustomer.AddCustomer(_customer);
            Assert.True(result > 0);
        }
        // GET Single Customers
        [Fact]
        public void GetSingleCustomer()
        {
            CustomerManagerShould();
            CustomerManager newCustomer = new CustomerManager(_db);
            newCustomer.AddCustomer(_customer);
            Customer theCustomer = newCustomer.GetSingleCustomer(1);
            int result = newCustomer.AddCustomer(_customer);
            Assert.True(result > 0);
        }
    }
}