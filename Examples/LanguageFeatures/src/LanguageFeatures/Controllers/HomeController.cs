using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;
using System.Collections.Generic;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new string[] { "C#", "Language", "Feautures" });
        }

        public IActionResult AboutNulls()
        {
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "No Name";
                // Since Related ties the Product implementations/objects togeather e.g."Related" 
                //  we can also set nullable on
                // simply we are allowing the related "chained" objecct to be nullable
                decimal? price = p?.Price ?? 0;
                // Notice the use of the ? in the .net chain
                string relatedName = p?.Related?.Name ?? "None";
                // If we dont specify we get the Auto set property from the model
                string category = p?.Category ?? "None";

                results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}, Category: {3}", name, price, relatedName, category));
            }

            return View(results);
       }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
