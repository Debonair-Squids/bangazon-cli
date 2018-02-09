using System;
using Xunit;
using System.Collections.Generic;
using bangazon_cli;

namespace bangazon_cli_test
{
    public class ProductCategoryShould
    {
        private ProductCategory _productCategory;
        private ProductCategoryManager _productCategoryManager;

        public ProductCategoryShould()
        {
            _productCategoryManager = new ProductCategoryManager();
            _productCategory = new ProductCategory()
            {
                CategoryName = "Shoes"
            };
        }

        [Fact]
        public void AddProductCategory()
        {
            int categoryTest = _productCategoryManager.AddProductCategoryToList(_productCategory);
            Assert.True(categoryTest != 0);
            Assert.Equal("Shoes", _productCategory.CategoryName);
        }

        [Fact]

        public void GetProductCategory()
        {
            List<ProductCategory> categoryList = _productCategoryManager.GetProductCategorylist();
            Assert.Empty(categoryList);

            _productCategoryManager.AddProductCategoryToList(_productCategory);

            categoryList = _productCategoryManager.GetProductCategorylist();
            Assert.True(categoryList.Count > 0);
            Assert.Equal("Shoes", _productCategory.CategoryName);
        }
    }
}
