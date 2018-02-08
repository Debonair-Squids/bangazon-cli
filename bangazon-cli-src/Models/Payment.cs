using System;
using System.ComponentModel.DataAnnotations;


namespace bangazon_cli
{
    public class Payment
    {

        public int PaymentId { get; set; }

        public string PaymentType { get; set; }

        public Payment(int paymentId, string paymentType)
        {
            this.PaymentId = paymentId;
            this.PaymentType = paymentType;
        }
    }
}