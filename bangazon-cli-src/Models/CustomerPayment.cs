using System;
using System.ComponentModel.DataAnnotations;


namespace bangazon_cli
{
    public class CustomerPayment
    {
        [Key]
        public int CustomerPaymentId { get; set;}

        public int PaymentId { get; set; }

        public int CustomerId { get; set; }

        public int Account { get; set; }

        


    }
}