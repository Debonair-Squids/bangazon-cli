using System;
using Xunit;
using bangazon_cli;

namespace bangazon_cli_test
{
    public class CustomerPaymentShould
    {
        private Customer _customer;
        private PaymentType _paymentType;
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

             _paymentType = new PaymentType
             (
                 1,
                "Visa"
             );

        }
        [Fact]
        public void AddCustomerPaymentShould()
        {
            CustomerPayment newCustomerPayment = new CustomerPayment
            (
                1,
                1,
                1,
                12345
            );
            Assert.Equal(1, newCustomerPayment.CustomerPaymentId);
            Assert.Equal(1, newCustomerPayment.PaymentTypeId);
            Assert.Equal(1, newCustomerPayment.CustomerId);
            Assert.Equal(12345, newCustomerPayment.Account);

        }
    }
}