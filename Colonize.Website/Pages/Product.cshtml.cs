using System.Collections.Generic;
using System.Linq;
using Colonize.Website.Data;
using Colonize.Website.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Colonize.Website
{
    public class ProductModel : PageModel
    {
        private readonly ApplicationDbContext context;

        [BindProperty]
        public Product Product { get; set; }

        public ProductModel(ApplicationDbContext context)
        {
            this.context = context; 
        }
        public IActionResult OnGet(string urlSlug)
        {
            Product = context.Product
                .FirstOrDefault(x => x.UrlSlug == urlSlug.ToLower());

            if (Product == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            var serializedBasket = HttpContext.Session.GetString("Basket");

            var basket = new List<Product>();

            if (serializedBasket != null)
            {
                basket = JsonConvert.DeserializeObject<List<Product>>(serializedBasket);
            }

            // dra in all info om produkten, inte endast id
            Product = context.Product
                .FirstOrDefault(x => x.Id == Product.Id);

            basket.Add(Product);

            serializedBasket = JsonConvert.SerializeObject(basket);

            HttpContext.Session.SetString("Basket", serializedBasket);

            // Servern kommer komma ihåg våra produkter 
            // Skickar med cookies för att lagra info i minnet
            // Kan endast lagra int eller string 
            //HttpContext.Session.SetInt32("Basket", Product.Id);

            return RedirectToPage("Basket");
        }
    }
}