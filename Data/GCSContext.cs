using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GCS.Models;

namespace GCS.Models
{
    public class GCSContext : DbContext
    {
        public GCSContext (DbContextOptions<GCSContext> options)
            : base(options)
        {
        }

        public DbSet<GCS.Models.User> Users { get; set; }

        public DbSet<GCS.Models.Company> Companies { get; set; }

        public DbSet<GCS.Models.Outcome> Outcome { get; set; }
    }
}
