using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OktaExample.Models
{
    public class OktaExampleContext : DbContext
    {
        public OktaExampleContext (DbContextOptions<OktaExampleContext> options)
            : base(options)
        {
        }

        public DbSet<OktaExample.Models.Prescription> Prescription { get; set; }
    }
}
