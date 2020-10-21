using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProjekt_Beispiel.Models;
     
namespace WebProjekt_Beispiel.Controllers
{    
    public class ShopController : Controller
    {
        // wird Index() aufgerufen, sollen alle Artikel angezeigt werden
        public IActionResult Index()
        {
            return View(CreateArticeList());
        }

        public IActionResult ReturnArticles()
        {
            return View();
        }


        private List<Article> CreateArticeList()
        {
            //normalerweise würden die Artikel aus einer DB-Tabelle geladen
            return new List<Article>()
            {
                new Article(1, "Iphone 11", 980.90m, "Tolles teueres Handy", new DateTime(2020, 5, 20)),
                new Article(2, "Xiaomi Mi a10 Lite 5g", 310.90m, "Preisleistuungsking", null),
                new Article(3, "Samsung Galaxy S20", 780.90m, "Samsung Flagship", new DateTime(2019, 9, 1)),
                new Article(4, "Iphone 11 Pro Plus Max", 1980.90m, "Tolles sehr teueres Handy", new DateTime(2020, 5, 20))
            };
        }
    }
}
