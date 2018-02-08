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
        public int Zip {get; set;}
        [Required]
        public long Phone {get; set;}

        public Customer ()
        {
            this.CustomerId = 1;
            this.FirstName = "Pippins";
            this.LastName = "McGee";
            this.StreetAddress = "123 Buttz Rd";
            this.City = "Nashville";
            this.State = "TN";
            this.Zip = 37210;
            this.Phone = 9876543210;
        }

        // Constructor for Customer accepting all property parameters
        public Customer (int cid, string first, string last, string address, string city, string state, int zip, int phone)
        {
            this.CustomerId = cid;
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