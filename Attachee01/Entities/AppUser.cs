﻿using Microsoft.AspNetCore.Identity;

namespace Attachee01.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
