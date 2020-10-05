using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data;

namespace Web.Components
{
    public class CartComponent : ViewComponent
    {
        private readonly ApplicationDbContext db;

        public CartComponent(ApplicationDbContext db)
        {
            this.db = db;
        }

        

        
    }
    public class CartViewModel
    {
        public int CartCount { get; set; }
    }
}
