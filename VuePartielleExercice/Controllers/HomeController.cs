using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VuePartielleExercice.Models;

namespace VuePartielleExercice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Vendor = "Bob Roberts";
            var product = new Product
            {
                description = "Sert à ranger des choses.",
                name = "Boite",
                rating = 75,
                details = new ProductDetail() {availableColors = new List<string> {"Rouge", "Vert", "Brun"},price=decimal.Parse("10,65"),size="largeur:40cm x longueur:40cm x hauteur:20cm"}
            };
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
