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

    private Product kite = new Product();
    private Product superKite = new Product(2, "Super Kite", "string description", 9.99, 4, 1, 2);
    private InvoiceManager _im;
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
      //Establish active customer , create product with active customer as id, then pass to add method
      Customer jim = new Customer();
      _cm.AddCustomer(jim);
      Customer activeCustomer = _cm.GetSingleCustomer(1);
      Product yarn = new Product(1, "yarn", "Rolled up", 2.99, 60, 1, activeCustomer.CustomerId);
      int result = _pm.AddProductToSell(yarn);
      Assert.Equal(1, result);
    }



    [Fact]
    public void GetAllProducts()
    {
      ProductManagerShould();
      Customer activeCustomer = new Customer("Kolden", "Prue", "Street Adress", "Nashville", "TN","376787", "763726327868");
      List <Product> allProducts = _pm.GetAllProducts(activeCustomer);
      Assert.Equal(3, allProducts.Count());
    }

    [Fact]
    public void GetSingleCustomerProduct()
    {
      ProductManagerShould();
      Customer activeCustomer = new Customer("Kolden", "Prue", "Street Adress", "Nashville", "TN","376787", "763726327868");
      List <Product> singleProduct = _pm.GetSingleCustomerProduct(activeCustomer, "Baseball");
      Assert.Equal(1, singleProduct.Count());

    }



    [Fact]
    public void UpdateProduct()
    {
      ProductManagerShould();
      Customer activeCustomer = new Customer();
      Product yarn = new Product(2, "yarn", "Rolled up", 2.99, 60, 1, activeCustomer.CustomerId);
      _pm.AddProductToSell(yarn);
      //User selects the first item in cli which has a corresponding productId of 1
      List<Product> allProducts = _pm.GetAllCustomerProducts(activeCustomer);
      Product selectedProduct = allProducts.Where(x => x.ProductId == 1).Single();
      //Gather fields from cli to complete the updates parameter reqs

     string updated =  _pm.UpdateProduct(selectedProduct, 1,"Yarnballs");
     string updated2 = _pm.UpdateProduct(selectedProduct, 2, "A better description");
     string updated3 = _pm.UpdateProduct(selectedProduct, 3, "3.99");
     string updated4 = _pm.UpdateProduct(selectedProduct, 4, "25");


     Assert.Equal("Updated", updated);
     Assert.Equal("Updated", updated2);
     Assert.Equal("Updated", updated3);
     Assert.Equal("Updated", updated4);


    }

    [Fact]

    public void GetAllCustomerProducts()
    {
      ProductManagerShould();
      Customer activeCustomer = new Customer("Kolden", "Prue", "Street Adress", "Nashville", "TN","12345", "1234567890");
      // _cm.GetSingleCustomer(activeCustomer.CustomerId);
      List<Product> allProducts = _pm.GetAllCustomerProducts(activeCustomer);
      Assert.Equal(3, allProducts.Count());
    }




    [Fact]
    public void RemoveProduct()
    {
      ProductManagerShould();
      //Establish active customer , create product with active customer as id, then pass to add method
      Customer jim = new Customer();
      _cm.AddCustomer(jim);
      Customer activeCustomer = _cm.GetSingleCustomer(1);
      IEnumerable<Product> allCustomerProducts = _pm.GetAllCustomerProducts(activeCustomer);
      //User selects the first item in cli display which has a corresponding productId of 1
      Product selectedProduct = allCustomerProducts.Where(x => x.ProductId == 1).Single();
      string confirmation = _pm.RemoveProduct(selectedProduct);
      Assert.Equal("Confirm", confirmation);
    }

  }
}