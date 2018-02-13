using System;
using System.ComponentModel.DataAnnotations;

namespace bangazon_cli
{
  public class Product
  {
    [Key]
    public int ProductId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public int Category { get; set; }
    public int CustomerId { get; set; }
    public DateTime DateCreated { get; set; }

    // public Product(string title, string description, double price, int quantity, int category, int customerId)
    // {
    //   this.ProductId = 0;
    //   this.DateCreated = DateTime.Now;
    //   this.CustomerId = customerId;
    //   this.Description = description;
    //   this.Price = price;
    //   this.Title = title;
    //   this.Quantity = quantity;
    //   this.Category = category;
    // }
  }
}