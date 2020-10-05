using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data;
using Web.Models;

namespace Web.Services
{
    public class AdminRepo : IAdminRepo
    {
        private readonly ApplicationDbContext _context;

        public AdminRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Product> GetProducts()
        {
            return _context.Products.ToList();     
        }
    }
}
