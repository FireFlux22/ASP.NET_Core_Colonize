using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Colonize.Website.Data;
using Colonize.Website.Data.Entities;

namespace Colonize.Website
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Ship Ship { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ship = await _context.Ship.FirstOrDefaultAsync(m => m.Id == id);

            if (Ship == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
