using System;

namespace BDRetail.Persistance.Models
{
    public class OrderHistory
    {
        public Guid Id { get; set; }
        
        public Guid OrderId { get; set; }
        
        public Order Order { get; set; }

        public string State { get; set; }
        
        public DateTime CreatedOn { get; set; }
    }
}
