using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colonize.Website.Data.Entities
{
    public class VoyageIdentityUser
    {
        public int VoyageId { get; set; }
        public Guid IdentityUserId { get; set; }
    }
}
