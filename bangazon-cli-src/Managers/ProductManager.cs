using System.Collections.Generic;
using System.Linq;

namespace bangazon_cli
{
  public class ProductManager
  {
    private List<Product> products = new List<Product>();
    CustomerManager cm = new CustomerManager();

    public void AddProduct(Product product)
    {
      products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
      products.Remove(product);
    }
    public List<Product> GetAllProducts()
    {
      return products;
    }

    public IEnumerable<Product> GetAllCustomerProducts(Customer activeCustomer)
    {
     IEnumerable<Product> allProducts = 
     from prod in products
     where prod.CustomerId == activeCustomer.CustomerId
     select prod;
     return allProducts; 

    }
    public Product GetSingleCustomerProduct(Customer activeCustomer , string title)
    {
      return products.Where(x => x.CustomerId == activeCustomer.CustomerId && x.Title == title).Single();
    }


    public void UpdateProduct(Product product, int replaceChoice, string update)
    {

      switch (replaceChoice)
      {
        case 1:
          product.Title = update;
          break;
        case 2:
          product.Description = update;
          break;
        case 3:
          product.Price = double.Parse(update);
          break;
        case 4:
          product.Quantity = int.Parse(update);
          break;
      }
    }
  }
}