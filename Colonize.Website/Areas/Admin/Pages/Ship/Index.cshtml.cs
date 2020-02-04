using Colonize.Website.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace Colonize.Website.Pages.Admin.Ship
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;

        // IEnumerable låter dig iterera igenom listan, men får inte lov att Add eller Delete
        public IEnumerable<Data.Entities.Ship> Ships { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
            Ships = context.Ship.ToList();
        }
    }
}