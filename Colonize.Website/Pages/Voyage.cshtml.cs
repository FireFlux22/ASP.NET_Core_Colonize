using Colonize.Website.Data;
using Colonize.Website.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Colonize.Website
{
    public class VoyageModel : PageModel
    {
        // ta bort int id inparametern i OnGet() när denna används
        // använd när du vill använda Id mer än en gång
        // använd helst inte den här! 
        //[BindProperty(SupportsGet = true)]
        //public int Id { get; set; }

        public Voyage Voyage { get; set; }

        private ApplicationDbContext context;

        public VoyageModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet(int id) // binding
        {
            Voyage = context.Voyage
                .Include(x => x.Destination)
                .FirstOrDefault(x => x.Id == id);

            if(Voyage == null)
            {
                return NotFound(); // HTTP 404 Not found
            }

            return Page();
        }
    }
}