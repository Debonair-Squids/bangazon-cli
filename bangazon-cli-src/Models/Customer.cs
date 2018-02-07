using System;

namespace bangazon_cli
{
    class Customer
    {
        [Key]
        public int CustomerId {get; set;}

        [Required]
        public string FirstName {get; set;}
        [Required]
        public string LastName {get; set;}
        [Required]
        public string StreetAddress {get; set;}
        [Required]
        public string City {get; set;}
        [Required]
        public string State {get; set;}
        [Required]
        public int Zip {get; set;}
        [Required]
        public int Phone {get; set;}
    }
}