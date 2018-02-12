using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bangazon_cli
{
    public class Customer
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
        public string Zip {get; set;}
        [Required]
        public string Phone {get; set;}

        public Customer ()
        {
            // this.CustomerId = 1;
            this.FirstName = "Erin";
            this.LastName = "Egobert";
            this.StreetAddress = "123 ok Rd";
            this.City = "Nashville";
            this.State = "TN";
            this.Zip = "37210";
            this.Phone = "aaaahhhhhh";
        }

        // Constructor for Customer accepting all property parameters
        public Customer (string first, string last, string address, string city, string state, string zip, string phone)
        {
            // this.CustomerId = cid;
            this.FirstName = first;
            this.LastName = last;
            this.StreetAddress = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phone;
        }
    }
}