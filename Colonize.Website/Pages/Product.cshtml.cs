using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colonize.Website.Data;
using Colonize.Website.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Colonize.Website
{
    public class ProductModel : PageModel
    {
        private readonly ApplicationDbContext context;

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
    }
}