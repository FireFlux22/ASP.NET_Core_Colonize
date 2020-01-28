using Colonize.Website.Data;
using Colonize.Website.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Colonize.Website.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Voyage> VoyageList = new List<Voyage>();

        private readonly ILogger<IndexModel> logger;
        private readonly ApplicationDbContext context;

        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            this.logger = logger;
            this.context = context;
        }

        public void OnGet()
        {
            VoyageList = context.Voyage
                .Include(x => x.Destination)
                .ToList();

            //ViewData["VoyageList"] = context.Voyage
            //    .Include(x => x.Destination)
            //    .ToList();

        }
    }
}
