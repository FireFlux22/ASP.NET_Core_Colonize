using Colonize.Website.Data;
using Colonize.Website.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace Colonize.Website
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext context;

        [BindProperty]
        public Ship Ship { get; set; }

        public DeleteModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        // HTTP GET /admin/ship/delete
        public void OnGet(int id)
        {
            Ship = context.Ship.FirstOrDefault(x => x.Id == id);
        }

        public IActionResult OnPost()
        {
            // Get ship corresponding id
            var foundShip = context.Ship.FirstOrDefault(x => x.Id == Ship.Id);

            // If not found, return 404, else
            if (foundShip == null)
            {
                return NotFound();
            }

            // Delete ship
            context.Ship.Remove(foundShip);
            context.SaveChanges();

            // redirect to indexpage
            return RedirectToPage("./Index");
        }
    }
}