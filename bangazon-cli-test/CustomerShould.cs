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
        public CustomerShould()
        {
            /*
                Properties of job
                    - First
                    - Last
                    -Address
                    -City
                    -State
                    -Zip
                    -Phone
             */
            _customer = new Customer(
                1,
                "Pippins",
                "McGee",
                "123 Buttz Rd.",
                "Nashville",
                "TN",
                37210,
                9876543210
            );
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

        // enter VALUE before the object.property
            Assert.Equal(1, theCustomer.CustomerId);
            Assert.Equal("Pippins", theCustomer.FirstName);
            Assert.Equal("McGee", theCustomer.LastName);

        }
    }
}
