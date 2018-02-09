using System;
using System.ComponentModel.DataAnnotations;


namespace bangazon_cli
{
    public class CustomerPayment
    {
        [Key]
        public int CustomerPaymentId { get; set; }
        public string PaymentTypeName { get; set; }
        public int Account { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public CustomerPayment(int customerPaymentId, string paymentTypeName, int account, int customerId)
        {
            this.CustomerPaymentId = customerPaymentId;
            this.PaymentTypeName = paymentTypeName;
            this.Account = account;
            this.CustomerId = customerId;
        }
    }
}