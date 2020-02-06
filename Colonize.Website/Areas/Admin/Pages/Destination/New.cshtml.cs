using System;
using System.ComponentModel.DataAnnotations;
using Colonize.Website.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Colonize.Website.Areas.Admin.Pages.Destination
{
    public class NewModel : PageModel
    {
        private readonly ApplicationDbContext context;

        [BindProperty]
        public NewDestinationViewModel viewModel { get; set; }

        public NewModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var destination = new Data.Entities.Destination(
                viewModel.Name,
                viewModel.Description,
                new Uri(viewModel.ImageUrl, UriKind.Absolute));

            context.Destination.Add(destination);
            context.SaveChanges();

            return RedirectToPage("Index");
        }

        public class NewDestinationViewModel
        {
            // attribute
            [Required]
            [MaxLength(50)]
            public string Name { get; set; } // måste ha samma namn som name i formuläret

            [Required]
            [MaxLength(500)]
            public string Description { get; set; }

            [Required]
            public string ImageUrl { get; set; }
        }
    }
}

