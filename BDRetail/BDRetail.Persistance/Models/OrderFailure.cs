using System;

namespace BDRetail.Persistance.Models
{
    public class OrderFailure
    {
        public Guid Id { get; set; }
        
        public DateTime CreatedOn { get; set; }
        
        public string Reason { get; set; }
    }
}
