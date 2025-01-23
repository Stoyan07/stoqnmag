using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shop11A.Models;

namespace Shop11A.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public List<Product> products = new List<Product>
        {
            
            new Product{ Id = 7, Name = "teniska1", Description = "krust", Price = 45.00M, ImageUrl = "/images/teniska1.jpg" },

           new Product{ Id = 8, Name = "kargo", Description = "PAUSE", Price = 150.00M, ImageUrl = "/images/kargo.jpg" },
           new Product{ Id = 9, Name = "qke", Description = "NIKE", Price = 400.00M, ImageUrl = "/images/qke.jpg" },
           new Product{ Id = 10, Name = "potnik", Description = "PAUSE", Price = 50.00M, ImageUrl = "/images/potnik.jpg" },
            new Product{ Id = 11, Name = "obuvki", Description = "EA7", Price = 330.00M, ImageUrl = "/images/obuvki.jpg" },
            new Product{ Id = 12, Name = "dunki", Description = "hugo", Price = 220.00M, ImageUrl = "/images/dunki.jpg" },
            new Product{ Id = 13, Name = "greika", Description = "calvin klein", Price = 300.00M, ImageUrl = "/images/greika.jpg" },
            new Product{ Id = 14, Name = "shapka", Description = "guess", Price = 95.00M, ImageUrl = "/images/shapka.jpg" },
            new Product{ Id = 15, Name = "bokserki", Description = "BOSS", Price = 120.00M, ImageUrl = "/images/bokserki.jpg" },
            new Product{ Id = 16, Name = "pijama", Description = "Kral Lagerfeld", Price = 190.00M, ImageUrl = "/images/pijama.jpg" },
            new Product{ Id = 17, Name = "chorapi", Description = "AMIRI", Price = 80.00M, ImageUrl = "/images/chorapi.jpg" },
            new Product{ Id = 18, Name = "chanta", Description = "TOMMY HILFIGER", Price = 125.00M, ImageUrl = "/images/chanta.jpg" },
            new Product{ Id = 19, Name = "gornishe", Description = "nike tech fleese", Price = 240.00M, ImageUrl = "/images/gornishe.jpg" },
            new Product{ Id = 20, Name = "pantalon", Description = "nike tech fleese", Price = 200.00M, ImageUrl = "/images/pantalon.jpg" },
            new Product{ Id = 21, Name = "ochila", Description = "ray ban", Price = 300.00M, ImageUrl = "/images/ocila.jpg" },



        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
