using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace bangazon_cli
{
  public class ProductManager
  {

    private List<Product> products = new List<Product>();
    private DatabaseInitializer _db;

    public ProductManager(DatabaseInitializer db)
    {
      _db = db;
    }

    //Passing the product info, and then the activeCustomer's id , so the product is created for the active customer
    public int AddProductToSell(Product product)
    {
      products.Add(product);
      int id = _db.Insert($"insert into Product values (null, '{product.Title}', '{product.Description}', '{product.Price}', '{product.Quantity}', '{product.Category}', '{product.CustomerId}', '{product.DateCreated}') ");
      return id;
    }

    public string RemoveProduct(Product product)
    {
      products.Remove(product);

      string confirmation = _db.Delete($"Delete from Product Where ProductId == {product.ProductId}");
      return confirmation;
    }

    public List<Product> GetAllProducts(Customer activeCustomer)
    {
      _db.Query($"SELECT * FROM Product WHERE CustomerId != {activeCustomer.CustomerId} and Quantity != 0;",
      (SqliteDataReader reader) =>
      {
        products.Clear();
        while (reader.Read())
        {
          products.Add(new Product()
          {
            ProductId = reader.GetInt32(0),
            Title = reader[1].ToString(),
            Description = reader[2].ToString(),
            Price = reader.GetDouble(3),
            Quantity = reader.GetInt32(4),
            Category = reader.GetInt32(5),
            CustomerId = reader.GetInt32(6),
            DateCreated = reader.GetDateTime(7)
          });
        }
      }
      );
      return products;
    }

    public List<Product> GetAllCustomerProducts(Customer activeCustomer)
    {
      _db.Query($"SELECT * FROM Product WHERE CustomerId == {activeCustomer.CustomerId} and Quantity != 0;",
      (SqliteDataReader reader) =>
      {
        products.Clear();
        while (reader.Read())
        {
          products.Add(new Product()
          {
            ProductId = reader.GetInt32(0),
            Title = reader[1].ToString(),
            Description = reader[2].ToString(),
            Price = reader.GetDouble(3),
            Quantity = reader.GetInt32(4),
            Category = reader.GetInt32(5),
            CustomerId = reader.GetInt32(6),
            DateCreated = reader.GetDateTime(7)
          });
        }
      }
      );
      return products;
    }


    public List<Product> GetSingleCustomerProduct(Customer activeCustomer, string title)
    {
      _db.Query($"SELECT * FROM Product WHERE CustomerId == {activeCustomer.CustomerId} and Title == '{title}'",
      (SqliteDataReader reader) =>
      {
        products.Clear();
        while (reader.Read())
        {
            products.Add(new Product()
            {
              ProductId = reader.GetInt32(0),
              Title = reader[1].ToString(),
              Description = reader[2].ToString(),
              Price = reader.GetDouble(3),
              Quantity = reader.GetInt32(4),
              Category = reader.GetInt32(5),
              CustomerId = reader.GetInt32(6),
              DateCreated = reader.GetDateTime(7)
            });
          }
        }
      );
      return products;
    }

    public Product GetSingleCustomerProduct(int id)
    {
      _db.Query($"SELECT * FROM Product WHERE ProductId == {id}",
      (SqliteDataReader reader) =>
      {
        products.Clear();
        while (reader.Read())
        {
            products.Add(new Product()
            {
              ProductId = reader.GetInt32(0),
              Title = reader[1].ToString(),
              Description = reader[2].ToString(),
              Price = reader.GetDouble(3),
              Quantity = reader.GetInt32(4),
              Category = reader.GetInt32(5),
              CustomerId = reader.GetInt32(6),
              DateCreated = reader.GetDateTime(7)
            });
          }
        }
      );
      return products[0];
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