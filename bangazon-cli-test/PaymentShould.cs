using System;
using Xunit;
using bangazon_cli;

namespace bangazon_cli_test
{
    public class PaymentShould
    {
        // private Payment _payment;
        // public PaymentShould()
        // {
        //     /*
        //     Properties of Payment
        //     - PaymentId
        //     - PaymentType
        //      */

        //     _payment = new Payment()
        //     {
        //         PaymentId = 1,
        //         PaymentType = "Visa"
        //     };

        // }

        [Fact]
        public void AddPayment()
        {
            Payment newPayment = new Payment
            (
                1,
                "Visa"
            );
            Assert.Equal(newPayment.PaymentId, 1);
            Assert.Equal(newPayment.PaymentType, "Visa");
        }


    }
}
