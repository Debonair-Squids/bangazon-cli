using System;
using Xunit;
using bangazon_cli;

namespace bangazon_cli_test
{
    public class CustomerShould
    {
        // ADD CUSTOMER TEST
        [Fact]
        public void AddCustomer()
        {
            Customer newCustomer = new Customer();
            newCustomer.FirstName = "Pippins";
            newCustomer.LastName = "McGee";
            newCustomer.StreetAddress = "123 Buttz Rd.";
            newCustomer.City = "Nashville";
            newCustomer.State = "TN";
            newCustomer.Zip = 37210;
            newCustomer.Phone = 9876543210;

            // must put VALUE first before object.property to avoid warning
            Assert.Equal("Pippins", newCustomer.FirstName);
            Assert.Equal("McGee", newCustomer.LastName);
            Assert.Equal("123 Buttz Rd.", newCustomer.StreetAddress);
            Assert.Equal("Nashville", newCustomer.City);
            Assert.Equal(37210, newCustomer.Zip);
            Assert.Equal(9876543210, newCustomer.Phone);
        }
    }
}
