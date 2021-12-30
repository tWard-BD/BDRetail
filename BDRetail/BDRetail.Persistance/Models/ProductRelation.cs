using System;

namespace BDRetail.Persistance.Models
{
    public class ProductRelation
    {
        public Guid ProductId { get; set; }
        
        public Product Product { get; set; } 

        public Guid RelatedId { get; set; }
    
        public Product Related { get; set; }
    }
}
