using System;
using System.ComponentModel.DataAnnotations;

namespace bangazon_cli
{
  public class Product
  {
    [Key]
    public int ProductId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public double Price { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public int Category { get; set; }
    [Required]
    public int CustomerId { get; set; }
    [Required]
    public DateTime DateCreated { get; set; }

    public Product()
    {
      this.DateCreated = DateTime.Now;
      this.CustomerId = 1;
      this.Title = "Kite";
      this.Description = "Flies around";
      this.Price = 9.99;
      this.Quantity = 5;
      this.Category = 1;
      this.ProductId = 1;
    }
    
    public Product(int productId, string title, string description, double price, int quantity, int category, int customerId)
    {
      this.DateCreated = DateTime.Now;
      this.CustomerId = customerId;
      this.ProductId = productId;
      this.Description = description;
      this.Price = price;
      this.Title = title;
      this.Quantity = quantity;
      this.Category = category;
    }
  }
}