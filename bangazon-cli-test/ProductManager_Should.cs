//Author : Kolden Prue
//Tests for updating, adding, and removing a product from a customer.
using System;
using Xunit;
using System.Collections.Generic;
using bangazon_cli;
using System.Linq;

namespace bangazon_cli_test
{
  public class ProductManager_Should
  {

    private ProductManager _pm;
    private DatabaseInitializer _db;
    private CustomerManager _cm;
    private void ProductManagerShould()
    {
      _db = new DatabaseInitializer("bangazon_cli_db_test");
      _pm = new ProductManager(_db);
      _cm = new CustomerManager(_db);
    }

    [Fact]
    public void AddProductToSell()  
    {
      ProductManagerShould();
      Customer erin = new Customer();
      //Establish active customer , create product with active customer as id, then pass to add method
      int activeCustomerId = _cm.AddCustomer(erin);

      Product yarn = new Product();
      yarn.Title = "Yard Yarn";
      yarn.Description = "Rolled up";
      yarn.Price = 1.99;
      yarn.Quantity = 60;
      yarn.Category = 1;
      yarn.CustomerId = activeCustomerId;
      yarn.DateCreated = DateTime.Now;
      int result = _pm.AddProductToSell(yarn);
      Product returnedAfterAdding = _pm.GetSingleCustomerProduct(result);
      Assert.Equal(returnedAfterAdding.ProductId, result);
    }


    [Fact]
    public void GetAllProducts()
    {
      ProductManagerShould();
      Customer Kolden = new Customer("Kolden", "Prue", "Street Adress", "Nashville", "TN", "376787", "763726327868");
      int result = _cm.AddCustomer(Kolden);
      Customer activeCustomer = _cm.GetSingleCustomer(result);

      List<Product> allProducts = _pm.GetAllProducts(activeCustomer);
      Assert.Equal(12, allProducts.Count());
    }

    [Fact]
    public void GetSingleCustomerProduct()
    {
      ProductManagerShould();
      Customer retrievedCustomer = _cm.GetSingleCustomer(1);
      List<Product> singleProduct = _pm.GetSingleCustomerProduct(retrievedCustomer, "Hand Shovel");
      Assert.Equal(1, singleProduct.Count());

    }



    [Fact]
    public void UpdateProduct()
    {
      ProductManagerShould();
      //User selects the first item in cli which has a corresponding productId of 1
      //Gather fields from cli to complete the updates parameter reqs

      Customer activeCustomer = _cm.GetSingleCustomer(1);
      List<Product> selectedProductList = _pm.GetSingleCustomerProduct(activeCustomer, "Shovel");
      Product selectedProduct = selectedProductList[0];
      string updated = _pm.UpdateProduct(selectedProduct, 1, "Good Shovel");
      string updated2 = _pm.UpdateProduct(selectedProduct, 2, "25 footer");
      string updated3 = _pm.UpdateProduct(selectedProduct, 3, "350.99");
      string updated4 = _pm.UpdateProduct(selectedProduct, 4, "30");


      Assert.Equal("Updated", updated);
      Assert.Equal("Updated", updated2);
      Assert.Equal("Updated", updated3);
      Assert.Equal("Updated", updated4);


    }

    [Fact]

    public void GetAllCustomerProducts()
    {
      ProductManagerShould();
      Customer activeCustomer = _cm.GetSingleCustomer(1);
      List<Product> allProducts = _pm.GetAllCustomerProducts(activeCustomer);
      Assert.Equal(3, allProducts.Count());
    }




    [Fact]
    public void RemoveProduct()
    {
      ProductManagerShould();
      //Establish active customer , create product with active customer as id, then pass to method
      Customer activeCustomer = _cm.GetSingleCustomer(5);
      List<Product> listToRemove = _pm.GetSingleCustomerProduct(activeCustomer, "Ladel");
      //User selects the first item in cli display which has a corresponding productId of 1
      Product toRemove = listToRemove[0];
      string confirmation = _pm.RemoveProduct(toRemove);
      Assert.Equal("Confirm", confirmation);
    }

  }
}