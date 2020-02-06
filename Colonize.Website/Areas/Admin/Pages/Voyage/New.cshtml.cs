using Colonize.Website.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Colonize.Website.Areas.Admin.Pages.Voyage
{
    public class NewModel : PageModel
    {
        private readonly ApplicationDbContext context;

        [BindProperty]
        public NewVoyageViewModel ViewModel { get; set; }

        //public IEnumerable<Data.Entities.Voyage> Voyages { get; set; }

        public NewModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
            ViewModel = new NewVoyageViewModel();

            ViewModel.DestinationList = context.Destination
                .ToList()
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                });

            ViewModel.ShipList = context.Ship
                .ToList()
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                });
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var voyage = new Data.Entities.Voyage(
                ViewModel.DestinationId,
                ViewModel.ShipId,
                ViewModel.DepartureAt,
                ViewModel.ArrivalAt);

            context.Voyage.Add(voyage);
            context.SaveChanges();

            return RedirectToPage("Index");
        }

        public class NewVoyageViewModel
        {
            [Required]
            public int DestinationId { get; set; }

            public IEnumerable<SelectListItem> DestinationList { get; set; }
            public IEnumerable<SelectListItem> ShipList { get; set; }

            [Required]
            public int ShipId { get; set; }

            [Required]
            public DateTime DepartureAt { get; set; }

            [Required]
            public DateTime ArrivalAt { get; set; }
        }
    }
}

