using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WebStore.Models
{
    public class ProductCategoryViewModel
    {
        public List<Product> Products;
        public SelectList Categories;
        public string ProductCategory { get; set; }
    }
}
