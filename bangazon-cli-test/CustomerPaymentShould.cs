using System;
using Xunit;
using bangazon_cli;
using System.Collections.Generic;

namespace bangazon_cli_test
{
    public class CustomerPaymentShould
    {
        private CustomerPaymentManager _paymentManager;
        private Customer _customer;
        private CustomerPayment _customerPayment;

        public CustomerPaymentShould()
        {
            // constructors to hold data
            _paymentManager = new CustomerPaymentManager();


            _customer = new Customer()
            {
                FirstName = "Sofia",
                LastName = "Howard",
                CustomerId = 5
            };

            int number = 4567;

            string paymentTypeName = "Master";
            _customerPayment = new CustomerPayment()
            {
                PaymentTypeName = paymentTypeName,
                Account = number,
                CustomerId = _customer.CustomerId
            };

        }

        // AddPaymentForCurrentCustomer is a test method for the 'AddPayment()' method in CustomerPaymentManager.cs
        [Fact]
        public void AddPaymentForCurrentCustomer()
        {
            int paymentTest = _paymentManager.AddPayment(_customerPayment);
            Assert.True(paymentTest != 0);
            Assert.Equal(5, _customerPayment.CustomerId);
            Assert.Equal("Master", _customerPayment.PaymentTypeName);
            Assert.Equal(4567, _customerPayment.Account);
        }

        // GetPaymentsForCustomer is a test method for the GetCustomerPayments() method in the CustomerPaymentManager.cs
        // The first test checks to see if the list is empty.
        // Then add a Customer payment to the list
        // The second text makes sure the list is not empty.
        [Fact]
        public void GetPaymentsForCustomer()
        {

            List<CustomerPayment> paymentList = _paymentManager.GetCustomerPayments(_customer.CustomerId);
            Assert.Empty(paymentList);
            Assert.Equal(5, _customer.CustomerId);

            _paymentManager.AddPayment(_customerPayment);

            paymentList = _paymentManager.GetCustomerPayments(_customer.CustomerId);
            Assert.True(paymentList.Count > 0);
            Assert.Equal(5, _customerPayment.CustomerId);
        }


    }
}