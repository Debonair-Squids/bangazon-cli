using System;
using System.ComponentModel.DataAnnotations;


namespace bangazon_cli
{
    public class CustomerPayment
    {
        [Key]
        public int CustomerPaymentId { get; set;}

        public int PaymentTypeId { get; set; }

        public PaymentType PaymentType { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int Account { get; set; }

        public CustomerPayment(int customerPaymentId, int paymentTypeId, int customerId, int account)
        {
            this.CustomerPaymentId = customerPaymentId;
            this.PaymentTypeId = paymentTypeId;
            this.CustomerId = customerId;
            this.Account = account;
        }
    }
}