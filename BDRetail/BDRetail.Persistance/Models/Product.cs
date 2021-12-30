using System;
using System.Collections.Generic;

namespace BDRetail.Persistance.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public string ProductCode { get; set; }
        
        public string Brand { get; set; }

        public string State { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public Guid CategoryId { get; set; }

        public ProductCategory Category { get; set; }

        public bool InPromotion { get; set; }

        public ICollection<ProductImage> Images { get; set; }

        public ICollection<ProductRelation> RealtedProducts { get; set; }

        public ICollection<ProductRelation> RelatedToProducts { get; set; }
    }
}
