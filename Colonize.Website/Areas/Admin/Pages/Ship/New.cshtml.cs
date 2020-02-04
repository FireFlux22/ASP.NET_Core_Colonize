using Colonize.Website.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;

namespace Colonize.Website.Pages.Admin.Ship
{
    public class NewModel : PageModel
    {
        private readonly ApplicationDbContext context;

        [BindProperty]
        public NewShipViewModel viewModel { get; set; }

        public NewModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {

        }

        // HTTP POST /admin/ship/new
        // ...headers (metadata om anropet)
        // name=Haven&description=Lorem-ipsum&...
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var ship = new Data.Entities.Ship(
                viewModel.Name, 
                viewModel.Description, 
                viewModel.PassengerCapacity,
                new Uri(viewModel.ImageUrl, UriKind.Absolute));

            context.Ship.Add(ship);
            context.SaveChanges();

            return RedirectToPage("Index");
        }

        public class NewShipViewModel
        {
            // attribute
            [Required]
            [MaxLength(50)]
            public string Name { get; set; } // måste ha samma namn som name i formuläret

            [Required]
            [MaxLength(500)]
            public string Description { get; set; }

            [Required]
            public ushort PassengerCapacity { get; set; }

            [Required]
            public string ImageUrl { get; set; }
        }
    }
}