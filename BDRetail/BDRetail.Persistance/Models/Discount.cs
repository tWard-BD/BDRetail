using System;

namespace BDRetail.Persistance.Models
{
    public class Discount
    {
        public Guid Id { get; set; }
        
        public string Code { get; set; }
        
        public decimal Price { get; set; }
        
        public bool IsValid { get; set; }
        
        public DateTime? ValidTo { get; set; }
    }
}
