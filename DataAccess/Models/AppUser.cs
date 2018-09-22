using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
        }

        public DateTime? BirthDay { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Gender { get; set; }
    }
}
