// Controllers/ProductsController.cs
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Products()
        {
            // Створюємо колекцію продуктів для передачі в представлення
            var products = new List<Products>
            {
                new Products { ID = 1, Name = "Product A", Price = 19.99M, CreatedDate = DateTime.Now.AddDays(-5) },
                new Products { ID = 2, Name = "Product B", Price = 29.99M, CreatedDate = DateTime.Now.AddDays(-3) },
                new Products { ID = 3, Name = "Product C", Price = 39.99M, CreatedDate = DateTime.Now.AddDays(-1) }
            };

            // Передаємо колекцію в представлення
            return View(products);
        }
    }
}