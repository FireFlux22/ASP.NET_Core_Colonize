using Colonize.Website.Data;
using Colonize.Website.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Colonize.Website.ViewComponents
{
    public class HeroViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext context;
        public HeroViewComponent(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
            var voyages = context.Voyage.ToList();

            return View(voyages);
        }
    }
}
