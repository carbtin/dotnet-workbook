using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        // Auto initialize the property using the "=" for assignment
        public string Category { get; set; } = "Watersports";
        // The ? defines the this type can be Nullable
        public decimal? Price { get; set; }
        public Product Related { get; set; }

        public static Product[] GetProducts()
        {
            Product kayak = new Product { Name = "kayak", Category = "Water Craft", Price = 275M };
            Product lifejacket = new Product { Name = "Lifejacket", Price = 48.95M };

            kayak.Related = lifejacket;

            // Notice here at the end we are adding a null - Empty Product class item to the Product Array
            return new Product[] { kayak, lifejacket, null };
        }
    }
}
