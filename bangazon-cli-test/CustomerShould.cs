using System;
using Xunit;
using bangazon_cli;
using System.Collections.Generic;

namespace bangazon_cli_test
{
    public class CustomerShould
    {
    private Customer _customer;

        // ADD CUSTOMER TEST
        [Fact]
        public void AddCustomer()
        {
            // REFACTOR newCustomer? use _customer instead?
            
            Customer newCustomer = new Customer();
            newCustomer.CustomerId = 1;
            newCustomer.FirstName = "Pippins";
            newCustomer.LastName = "McGee";
            newCustomer.StreetAddress = "123 Buttz Rd.";
            newCustomer.City = "Nashville";
            newCustomer.State = "TN";
            newCustomer.Zip = 37210;
            newCustomer.Phone = 9876543210;

            // must put VALUE first before object.property to avoid warning
            Assert.Equal(1, newCustomer.CustomerId);
            Assert.Equal("Pippins", newCustomer.FirstName);
            Assert.Equal("McGee", newCustomer.LastName);
            Assert.Equal("123 Buttz Rd.", newCustomer.StreetAddress);
            Assert.Equal("Nashville", newCustomer.City);
            Assert.Equal(37210, newCustomer.Zip);
            Assert.Equal(9876543210, newCustomer.Phone);
        }

        [Fact]
        public void GetAllCustomers()
        {
            CustomerManager newCustomer = new CustomerManager();
            newCustomer.AddCustomer(_customer);
            List<Customer> allCustomers = newCustomer.GetAllCustomers();

            Assert.Contains(_customer, allCustomers);
        }

        [Fact]
        public void GetSingleCustomer()
        {
            CustomerManager manager = new CustomerManager();
            manager.AddCustomer(_customer);
            Customer theCustomer = manager.GetSingleCustomer(1);


            Assert.Equal(theCustomer.CustomerId, 1);
            Assert.Equal(theCustomer.FirstName, "Pippins");
            Assert.Equal(theCustomer.LastName, "McGee");

        }

        // // GET CUSTOMER TEST
        // [Fact]
        // public void GetCustomer()
        // {
        //     Customer newCustomer = new Customer();
        //     newCustomer.FirstName = "Pippins";
        //     newCustomer.LastName = "McGee";
        //     newCustomer.StreetAddress = "123 Buttz Rd.";
        //     newCustomer.City = "Nashville";
        //     newCustomer.State = "TN";
        //     newCustomer.Zip = 37210;
        //     newCustomer.Phone = 9876543210;

        //     // must put VALUE first before object.property to avoid warning

        // }
    }
}
