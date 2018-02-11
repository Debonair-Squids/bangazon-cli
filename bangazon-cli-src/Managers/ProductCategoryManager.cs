using System.Collections.Generic;
using System.Linq;

namespace bangazon_cli
{
    public class ProductCategoryManager
    {
        private List<ProductCategory> _categories = new List<ProductCategory>();

        public int AddProductCategoryToList(ProductCategory currentCategory)
        {
           int currentCategoryId = 0;
            _categories.Add(currentCategory);

             currentCategoryId= 2;
            return currentCategoryId;
        }
        public List<ProductCategory> GetProductCategorylist()
        {
            return _categories;
        }
    }
}
