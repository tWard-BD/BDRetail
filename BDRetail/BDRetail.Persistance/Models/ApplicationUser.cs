using System;
using Microsoft.AspNetCore.Identity;

namespace BDRetail.Persistance.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Guid UserProfileId { get; set; }

        public UserProfile UserProfile { get; set; }
    }
}
