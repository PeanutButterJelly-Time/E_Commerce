using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Web.Data;
using Web.Services;

namespace Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IAdminRepo repo;
        public IConfiguration Configuration { get; }
        public AdminController(ApplicationDbContext context, IAdminRepo repo, IConfiguration configuration)
        {
            this.repo = repo;
            _context = context;
            Configuration = configuration;
        }
        // GET: AdminController
        public ActionResult Index()
        {
            var products = repo.GetProducts();
            return View(products);
        }

        // GET: AdminController/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
