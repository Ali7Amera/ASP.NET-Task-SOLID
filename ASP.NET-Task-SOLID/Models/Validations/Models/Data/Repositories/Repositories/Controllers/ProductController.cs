using Microsoft.AspNetCore.Mvc;
using TaskProject.Models;
using TaskProject.Repositories;

namespace TaskProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var data = _repo.GetAll();
            return View(data);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(product);
                TempData["Success"] = "Product added successfully";
                return RedirectToAction("Index");
            }

            TempData["Error"] = "Invalid Data";
            return View(product);
        }
    }
}
