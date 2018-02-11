using System;
using System.ComponentModel.DataAnnotations;

namespace bangazon_cli
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryID { get; set; }

        public string CategoryName { get; set; }
    }
    
}