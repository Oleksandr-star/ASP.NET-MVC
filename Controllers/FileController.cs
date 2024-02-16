// Controllers/FileController.cs
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace WebApplication2.Controllers
{
    public class FileController : Controller
    {
        public IActionResult DownloadFile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(fileName))
            {
                ViewBag.Error = "All fields are required.";
                return View();
            }

            // Формуємо вміст файлу
            string fileContent = $"First Name: {firstName}\nLast Name: {lastName}";

            // Записуємо вміст файлу в текстовий файл
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", $"{fileName}.txt");
            System.IO.File.WriteAllText(filePath, fileContent, Encoding.UTF8);

            // Повертаємо файл для завантаження користувачу
            return PhysicalFile(filePath, "text/plain", $"{fileName}.txt");
        }
    }
}