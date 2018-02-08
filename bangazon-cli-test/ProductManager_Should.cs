//Author : Kolden Prue 
//Tests for updating, adding, and removing a product from a customer.

using System;
using Xunit;
using System.Collections.Generic;
using bangazon_cli;

namespace bangazon_cli_test
{



  public class ProductManager_Should
  {

    private Product kite = new Product();
    private Product superKite = new Product (2, "Super Kite", "string description", 9.99, 4, 1, 1);    

    [Fact]
    public void AddProduct()
    {
      ProductManager productManager = new ProductManager();
      productManager.AddProduct(kite);
      List<Product> returned = productManager.GetAllProducts();

      Assert.Contains(kite,returned);

    }

    [Fact]
    public void GetAllCustomerProducts()
    {
      ProductManager prodMan = new ProductManager();
      prodMan.AddProduct(kite);
      prodMan.AddProduct(superKite);
      CustomerManager cm = new CustomerManager();
      Customer jim = new Customer();
      cm.AddCustomer(jim);
      Customer activeCustomer =  cm.GetSingleCustomer(1);
      IEnumerable<Product> allProducts =  prodMan.GetAllCustomerProducts(activeCustomer);
      Assert.Contains(kite,allProducts );
      Assert.Contains(superKite, allProducts);
    }

    [Fact]
    public void UpdateProduct()
    {
      ProductManager prodMan = new ProductManager();
      prodMan.AddProduct(kite);
      prodMan.AddProduct(superKite);
      CustomerManager cm = new CustomerManager();
      Customer jim = new Customer();
      cm.AddCustomer(jim);
      Customer activeCustomer =  cm.GetSingleCustomer(1);
      Product singleProduct =  prodMan.GetSingleCustomerProduct(activeCustomer, "Super Kite");
      prodMan.UpdateProduct(singleProduct, 1, "Great Kite");
      prodMan.UpdateProduct(singleProduct, 2, "This is very good kite, great even");
      prodMan.UpdateProduct(singleProduct, 3, "25.99"); 
      prodMan.UpdateProduct(singleProduct, 4, "20");      
           
      
      Assert.Equal("Great Kite", singleProduct.Title);
      Assert.Equal("This is very good kite, great even", singleProduct.Description);
      Assert.Equal(25.99, singleProduct.Price);      
      Assert.Equal(20, singleProduct.Quantity);            
    }

    [Fact]

    public void GetSingleCustomerProduct()
    {
      CustomerManager cm = new CustomerManager();
      ProductManager prodMan = new ProductManager();
      prodMan.AddProduct(kite);
      prodMan.AddProduct(superKite);
      Customer jim = new Customer();
      cm.AddCustomer(jim);
      Customer activeCustomer =  cm.GetSingleCustomer(1);

      Product singleProduct = prodMan.GetSingleCustomerProduct(activeCustomer, "Kite");

      Assert.Equal("Kite", singleProduct.Title);
    }




    [Fact]
    public void RemoveProduct()
    {
      CustomerManager cm = new CustomerManager();
      ProductManager prodMan = new ProductManager();
      prodMan.AddProduct(kite);
      prodMan.AddProduct(superKite);
      Customer jim = new Customer();
      cm.AddCustomer(jim);
      Customer activeCustomer =  cm.GetSingleCustomer(1);
      Product toRemove = prodMan.GetSingleCustomerProduct(activeCustomer, "Super Kite");
      prodMan.RemoveProduct(toRemove);
      IEnumerable<Product> allProducts = prodMan.GetAllCustomerProducts(activeCustomer);
      Assert.DoesNotContain(superKite,allProducts );      
      Assert.Contains(kite,allProducts);
    }

  }
}
