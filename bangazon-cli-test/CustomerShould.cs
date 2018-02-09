using System;
using Xunit;
using bangazon_cli;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace bangazon_cli_test
{
    public class CustomerShould
    {
    private Customer _customer;
    private CustomerManager _cm;
    private DatabaseInitializer _db;

        public CustomerShould ()
        {
            _db = new DatabaseInitializer("bangazon_cli_db");
            _cm = new CustomerManager();
        }

        // ADD CUSTOMER TEST
        [Fact]
        public void AddCustomer ()
        {
            Customer newCustomer = new Customer();

                newCustomer.FirstName = "Pippins";
                newCustomer.LastName= "McGee";
                newCustomer.StreetAddress = "123 Buttz Rd.";
                newCustomer.City = "Nashville";
                newCustomer.State= "TN";
                newCustomer.Zip= "37210";
                newCustomer.Phone= "9876543210";


            // var result = _cm.AddCustomer(newCustomer);

            Assert.Contains("Pippins", newCustomer.FirstName);
        }
        // {
        //     _customer = new Customer(
        //         1,
        //         "Pippins",
        //         "McGee",
        //         "123 Buttz Rd.",
        //         "Nashville",
        //         "TN",
        //         "37210",
        //         "9876543210"
        //     );
        // }

        [Fact]
        public void GetAllCustomers()
        {
            CustomerManager newCustomer = new CustomerManager();
            newCustomer.AddCustomer(_customer);
            List<Customer> allCustomers = newCustomer.GetAllCustomers();

            Assert.Contains(_customer, allCustomers);
        }

        // [Fact]
        // public void GetSingleCustomer()
        // {
        //     CustomerManager manager = new CustomerManager();
        //     manager.AddCustomer(_customer);
        //     Customer theCustomer = manager.GetSingleCustomer(1);

        // // enter VALUE before the object.property
        //     Assert.Equal(1, theCustomer.CustomerId);
        //     // Assert.Equal("Pippins", theCustomer.FirstName);
        //     // Assert.Equal("McGee", theCustomer.LastName);
        // }
    }
}
