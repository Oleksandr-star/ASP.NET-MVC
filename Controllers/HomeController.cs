// Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System.Collections.Generic;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (user.Age > 16)
            {
                return View("ProductCount", user);
            }
            else
            {
                return View("NotEligible");
            }
        }

        [HttpPost]
        public IActionResult ProductCount(User user)
        {
            // Перенаправляємо на OrderForm, передаючи модель користувача
            return View("OrderForm", user);
        }



        [HttpPost]
        public IActionResult OrderConfirmation(List<Product> products)
        {
            // Обрабатываем заказ и выводим информацию о заказанных товарах
            return View(products);
        }
    }
}