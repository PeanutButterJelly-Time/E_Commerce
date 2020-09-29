using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Services;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepo;

        public ProductController(IProductRepository productRepo)
        {
            this.productRepo = productRepo;
        }

        // GET: ProductController
        public ActionResult Index(string sortBy, string name)
        {
            var cereals = productRepo.GetCereals(sortBy, name);
            return View(cereals);
        }


        // GET: ProductController/Details/5
        [Route("/Product/{id}")]
        public ActionResult Details(int id)
        {
            var cereal = productRepo.GetCereal(id);
            return View(cereal);
        }

        public ActionResult Name(string name)
        {
            var cereal = productRepo.GetCerealName(name);
            return View(cereal);
        }
       

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
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

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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
