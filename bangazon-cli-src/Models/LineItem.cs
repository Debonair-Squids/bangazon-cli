using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bangazon_cli
{
    public class LineItem
    {
        [Key]
        public int LineItemId {get; set;}

        [Required]
        public int InvoiceId {get; set;}

        [Required]
        public int ProductId {get; set;}


        // Constructor for Line Items table accepting all parameters
        public LineItem (int LineItemId, int InvoiceId, int ProductId)
        {
        this.LineItemId = LineItemId;
        this.InvoiceId = InvoiceId;
        this.ProductId = ProductId;
        }
    }
}