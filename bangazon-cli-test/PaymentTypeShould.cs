using System;
using Xunit;
using bangazon_cli;

namespace bangazon_cli_test
{
    public class PaymentTypeShould
    {
        // private Payment _payment;
        // public PaymentShould()
        // {
        //     /*
        //     Properties of Payment
        //     - PaymentTypeId
        //     - PaymentTypeName
        //      */

        //     _payment = new Payment()
        //     {
        //         PaymentTypeId = 1,
        //         PaymentTypeName = "Visa"
        //     };

        // }

        [Fact]
        public void AddPayment()
        {
            PaymentType newPaymentType = new PaymentType
            (
                1,
                "Visa"
            );
            Assert.Equal(1, newPaymentType.PaymentTypeId);
            Assert.Equal("Visa", newPaymentType.PaymentTypeName);
        }

    }
}
