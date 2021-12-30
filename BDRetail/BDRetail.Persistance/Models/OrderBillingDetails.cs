﻿using System;

namespace BDRetail.Persistance.Models
{
    public class OrderBillingDetails
    {
        public Guid Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string City { get; set; }
        
        public string Address { get; set; }
        
        public string PostCode { get; set; }
    }
}
