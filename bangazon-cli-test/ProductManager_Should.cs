// //Author : Kolden Prue
// //Tests for updating, adding, and removing a product from a customer.
// using System;
// using Xunit;
// using System.Collections.Generic;
// using bangazon_cli;
// using System.Linq;

// namespace bangazon_cli_test
// {
//   public class ProductManager_Should
//   {

//     private Product kite = new Product();
//     private Product superKite = new Product(2, "Super Kite", "string description", 9.99, 4, 1, 2);
//     // private DatabaseInitializer _db;
//     private InvoiceManager _im;
//     private ProductManager _pm;
//     private CustomerManager _cm;
//     private DatabaseInitializer _db;
//     private void ProductManagerShould()
//     {
//       _db = new DatabaseInitializer("bangazon_cli_test");
//       _pm = new ProductManager(_db);
//       _cm = new CustomerManager(_db);
//     }

// //Verified
//     [Fact]
//     public void AddProductToSell()
//     {
//       ProductManagerShould();
//       //Establish active customer , create product with active customer as id, then pass to add method
//       Customer jim = new Customer();
//       _cm.AddCustomer(jim);
//       Customer activeCustomer = _cm.GetSingleCustomer(1);
//       Product yarn = new Product(1, "yarn", "Rolled up", 2.99, 60, 1, activeCustomer.CustomerId);
//       int result = _pm.AddProductToSell(yarn);
//       Assert.Equal(1, result);
//     }

//     //Ticket 5
//     // [Fact]
//     // public void AddProductToOrder()
//     // {
//     //   ProductManagerShould();
//     //   _im = new InvoiceManager();
//     //   Customer pippins = new Customer();
//     //   _pm.AddProductToSell(superKite);
//     //   List<Product> allProducts = _pm.GetAllProducts();
//     //   //User selects the first item in cli which has a corresponding productId of 1
//     //   Product selected = allProducts.Where(x => x.ProductId == 2).Single();
//     //   Invoice order1 = new Invoice(1, 1, pippins.CustomerId);
//     //   _im.AddInvoice(order1);


//     //   Invoice customersPendingInvoice = _im.GetInvoice(pippins.CustomerId);
//     //   // Should search by active customer
//     //   // public Invoice GetInvoice(int id){
//     //   //      return  _invoices.Where(i => i.CustomerId == id).Single();
//     //   //   }

//     //   LineItem superKitePurchase = new LineItem(1, customersPendingInvoice.InvoiceId, selected.ProductId);
//     //   _im.AddLineItem(superKitePurchase);

//     //   List<LineItem> toTest = _im.GetAllLineItems(order1.InvoiceId);


//     //   Assert.Equal(1, toTest.Count());

//     // }

//     // [Fact]
//     // public void GetAllCustomerProducts()
//     // {
//     //   ProductManager prodMan = new ProductManager();
//     //   prodMan.AddProduct(kite);
//     //   prodMan.AddProduct(superKite);
//     //   CustomerManager cm = new CustomerManager();
//     //   Customer jim = new Customer();
//     //   cm.AddCustomer(jim);
//     //   Customer activeCustomer =  cm.GetSingleCustomer(1);
//     //   IEnumerable<Product> allProducts =  prodMan.GetAllCustomerProducts(activeCustomer);
//     //   Assert.Contains(kite,allProducts );
//     //   Assert.Contains(superKite, allProducts);
//     // }

//     // [Fact]
//     // public void UpdateProduct()
//     // {
//     //   ProductManagerShould();
//     //   Customer activeCustomer = new Customer();
//     //   Product yarn = new Product(2, "yarn", "Rolled up", 2.99, 60, 1, activeCustomer.CustomerId);
//     //   _pm.AddProductToSell(yarn);
//     //   //User selects the first item in cli which has a corresponding productId of 1
//     //   IEnumerable<Product> allProducts = _pm.GetAllCustomerProducts(activeCustomer);
//     //   Product selectedProduct = allProducts.Where(x => x.ProductId == 2).Single();
//     //   //Gather fields from cli to complete the updates parameter reqs

//     //  string updated =  _pm.UpdateProduct(selectedProduct, 1,"Yarnballs");
//     //  string updated2 = _pm.UpdateProduct(selectedProduct, 2, "A better description");
//     //  string updated3 = _pm.UpdateProduct(selectedProduct, 3, "3.99");
//     //  string updated4 = _pm.UpdateProduct(selectedProduct, 4, "25");


//     //  Assert.Equal("Updated", updated);
//     //  Assert.Equal("Updated", updated2);
//     //  Assert.Equal("Updated", updated3);
//     //  Assert.Equal("Updated", updated4);


//     // }

//     // [Fact]

//     // public void GetSingleCustomerProduct()
//     // {
//     //   CustomerManager cm = new CustomerManager();
//     //   ProductManager prodMan = new ProductManager();
//     //   prodMan.AddProduct(kite);
//     //   prodMan.AddProduct(superKite);
//     //   Customer jim = new Customer();
//     //   cm.AddCustomer(jim);
//     //   Customer activeCustomer = cm.GetSingleCustomer(1);

//     //   Product singleProduct = prodMan.GetSingleCustomerProduct(activeCustomer, "Kite");

//     //   Assert.Equal("Kite", singleProduct.Title);
//     // }




//     // [Fact]
//     // public void RemoveProduct()
//     // {
//     //   ProductManagerShould();
//     //   //Establish active customer , create product with active customer as id, then pass to add method
//     //   Customer jim = new Customer();
//     //   _cm.AddCustomer(jim);
//     //   Customer activeCustomer = _cm.GetSingleCustomer(1);
//     //   Product yarn = new Product(1, "yarn", "Rolled up", 2.99, 60, 1, activeCustomer.CustomerId);
//     //   _pm.AddProductToSell(yarn);

//     //   IEnumerable<Product> allCustomerProducts = _pm.GetAllCustomerProducts(activeCustomer);
//     //   //User selects the first item in cli display which has a corresponding productId of 1
//     //   Product selectedProduct = allCustomerProducts.Where(x => x.ProductId == 1).Single();

//     //   string confirmation = _pm.RemoveProduct(selectedProduct);

//     //   Assert.Equal("Confirm", confirmation);
//     // }

//   }
// }
