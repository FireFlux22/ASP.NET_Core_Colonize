using System.Collections.Generic;
using System.Linq;
using Colonize.Website.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Colonize.Website.Areas.Admin.Pages.Voyage
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public IEnumerable<Data.Entities.Voyage> Voyages { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
            Voyages = context.Voyage
                .Include(x => x.Destination)
                .Include(x => x.Ship)
                .ToList();
        }
    }
}

