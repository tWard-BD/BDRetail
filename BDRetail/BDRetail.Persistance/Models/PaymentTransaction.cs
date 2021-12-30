using System;

namespace BDRetail.Persistance.Models
{
    public class PaymentTransaction
    {
        public Guid Id { get; set; }
        
        public string State { get; set; }
        
        public string Description { get; set; }
        
        public DateTime CreatedOn { get; set; }
    }
}
