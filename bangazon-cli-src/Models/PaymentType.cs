using System;
using System.ComponentModel.DataAnnotations;


namespace bangazon_cli
{
    public class PaymentType
    {

        public int PaymentTypeId { get; set; }

        public string PaymentTypeName { get; set; }

        public PaymentType(int paymentTypeId, string paymentTypeName)
        {
            this.PaymentTypeId = paymentTypeId;
            this.PaymentTypeName = paymentTypeName;
        }
    }
}