using System;
using Xunit;
using bangazon_cli;
using System.Collections.Generic;

namespace bangazon_cli_test
{
    private CustomerPaymentManager _paymentManager;
    public class CustomerPaymentShould
    {
        private Customer _customer;

        public CustomerPaymentShould()
        {
            /*
                Properties of Customer
                    CustomerId = 1;
                    FirstName = "Sofia";
                    LastName= "Howard";
                    StreetAddress = "110 Keoneula Blvd";
                    City = "Ewa Beach"
                    State= "Hawaii";
                    Zip = 96706;
                    Phone= "808-729-4354";
             */
            _customer = new Customer
            (
                1,
                "Sofia",
                "Howard",
                "110 Keoneula Blvd",
                "Ewa Beach",
                "Hawaii",
                96706,
                8087294354
            );
        }
        [Fact]
        public void AddPaymentShould()
        {
            CustomerPayment newPayment = new CustomerPayment
            (
                1,
                "Visa",
                12345,
                1
            );
            Assert.Equal(1, newPayment.CustomerPaymentId);
            Assert.Equal("Visa", newPayment.PaymentTypeName);
            Assert.Equal(12345, newPayment.Account);
            Assert.Equal(1, newPayment.CustomerId);
        }
    }
}