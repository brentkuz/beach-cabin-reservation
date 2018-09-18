using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeachCabinReservation.Data.Entities
{
    public class AppUser : IdentityUser
    {
        [PersonalData]
        public string Color { get; set; }
        [PersonalData]
        public string Name { get; set; }
    }
}
