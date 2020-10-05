using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.Cart;

namespace Web.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public CartItem Cart { get; set; }
    }
   
}
