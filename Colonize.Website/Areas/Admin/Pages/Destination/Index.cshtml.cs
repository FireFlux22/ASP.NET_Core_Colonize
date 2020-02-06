using System.Collections.Generic;
using System.Linq;
using Colonize.Website.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Colonize.Website.Areas.Admin.Pages.Destination
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;

        // IEnumerable låter dig iterera igenom listan, men får inte lov att Add eller Delete
        public IEnumerable<Data.Entities.Destination> Destinations { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
            Destinations = context.Destination.ToList();
        }
    }
}
