using LearningViewComponentTagHelper.Models;
using MFramework.Services.FakeData;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LearningViewComponentTagHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult List()
        {
            Tuple<string, string> kisi1 = new Tuple<string, string>("Murat", "Başeren");
            Tuple<string, int> kisi2 = new Tuple<string, int>("Murat Başeren", 38);

            (string Ad, string Soyad) kisi3 = ("Kadir Murat", "Başeren");
            (string AdSoyad, int Yas) kisi4 = ("Murat Başeren", 38);


            //List<Tuple<string, string>> kisiler = new List<Tuple<string, string>>();
            //kisiler.Add(new Tuple<string, string>("murat", "başeren"));
            //kisiler.Add(new Tuple<string, string>("kadir", "başeren"));

            List<(string Ad, string Soyad)> kisiler = new List<(string Ad, string Soyad)>();

            for (int i = 0; i < 10; i++)
            {
                kisiler.Add((NameData.GetFirstName(), NameData.GetSurname()));
            }

            //foreach ((string Ad, string Soyad) item in kisiler)
            //{
            //    //item.Ad
            //}

            return View(kisiler);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}