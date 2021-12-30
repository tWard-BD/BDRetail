﻿using System;

namespace BDRetail.Persistance.Models
{
    public class ProductImage
    {
        public Guid Id { get; set; }
        
        public string ImageUrl { get; set; }
        
        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }
}