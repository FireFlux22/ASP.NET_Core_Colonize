using System.Collections.Generic;
using Colonize.Website.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Colonize.Website
{
    public class BasketModel : PageModel
    {
        public IEnumerable<Product> Products { get; set; } = new List<Product>();

        public void OnGet()
        {
            var serializedBasket = HttpContext.Session.GetString("Basket");

            // så att hemsidan kan hantera en tom Basket (när du kastar cookies)
            if (!string.IsNullOrEmpty(serializedBasket))
            {
                Products = JsonConvert.DeserializeObject<List<Product>>(serializedBasket);
            }
        }
    }
}