using System;

namespace BDRetail.Persistance.Models
{
    public class UserProfile
    {
        public Guid Id { get; set; }
        
        public string UserId { get; set; }
        
        public ApplicationUser User { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string ImageUrl { get; set; }
    }
}
