using System;
using System.Collections.Generic;

namespace BDRetail.Persistance.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        
        public DateTime CreatedOn { get; set; }
        
        public DateTime? UpdatedOn { get; set; }
        
        public string State { get; set; }
        
        public Guid OrderBillingDetailsId { get; set; }

        public OrderBillingDetails OrderBillingDetails { get; set; }

        public Guid OrderDeliveryDetailsId { get; set; }

        public OrderDeliveryDetails OrderDeliveryDetails { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
