using System.Collections.Generic;
using System.Linq;

namespace bangazon_cli
{
  public class ProductManager
  {

    private List<Product> products = new List<Product>();
    // CustomerManager cm = new CustomerManager();
    private DatabaseInitializer _db;

    public ProductManager(DatabaseInitializer db)
    {
      _db = db;
    }

    //Passing the product info, and then the activeCustomer's id , so the product is created for the active customer
    public int AddProductToSell(Product product)
    {
      products.Add(product);
      // int id = _db.Insert($"insert into Product values (null, '{product.Title}', '{product.Description}', '{product.Price}', '{product.Quantity}', '{product.Category}', '{product.CustomerId}', '{product.DateCreated}') ");
      return 7;
    }

    public string RemoveProduct(Product product)
    {
      products.Remove(product);

      string confirmation = _db.Delete($"Delete from Product Where ProductId == {product.ProductId}");
      return confirmation;
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
    public Product GetSingleCustomerProduct(Customer activeCustomer, string title)
    {
      return products.Where(x => x.CustomerId == activeCustomer.CustomerId && x.Title == title).Single();
    }


    public string UpdateProduct(Product product, int replaceChoice, string update)
    {

      switch (replaceChoice)
      {
        case 1:
          product.Title = update;
          return _db.Update($"UPDATE Product SET Title = '{update}' WHERE ProductId == {product.ProductId}");
        case 2:
          product.Description = update;
          return _db.Update($"UPDATE Product SET Description = '{update}' WHERE ProductId == {product.ProductId}");
        case 3:
          double parsedPatch = double.Parse(update);
          product.Price = parsedPatch;
          return _db.Update($"UPDATE Product SET Price = '{parsedPatch}' WHERE ProductId == {product.ProductId}");
        case 4:
          int parsedPatchQ = int.Parse(update);
          product.Quantity = parsedPatchQ;
          return _db.Update($"UPDATE Product SET Quantity = '{parsedPatchQ}' WHERE ProductId == {product.ProductId}");
      }
      return "Not Updated";
    }
  }
}
// UPDATE table_name
// SET column1 = value1, column2 = value2, ...
// WHERE condition;