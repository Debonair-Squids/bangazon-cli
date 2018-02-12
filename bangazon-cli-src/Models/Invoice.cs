using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bangazon_cli
{
    public class Invoice
    {
        [Key]
        public int InvoiceId {get; set;}

        [Required]
        public int CustomerPaymentId {get; set;}

        [Required]
        public int CustomerId {get; set;}

        [Required]
        public DateTime InvoiceDate {get; set;}= DateTime.Now;
        

        // Constructor for Invoice accepting all parameters
        public Invoice (int CustomerPaymentId, int CustomerId)
        {
        this.InvoiceId = InvoiceId;
        this.CustomerPaymentId = CustomerPaymentId;
        this.CustomerId = CustomerId;
        this.InvoiceDate = DateTime.Now;
        }
    }
}