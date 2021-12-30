using System;
using System.Collections.Generic;

namespace BDRetail.Persistance.Models
{
    public class ProductCategory
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public string ImageUrl { get; set; }
        
        public Guid? SubCategoryId { get; set; }

        public ProductCategory SubCategory { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
