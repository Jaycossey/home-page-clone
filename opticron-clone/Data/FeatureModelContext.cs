using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using opticron_clone.Models;

namespace opticron_clone.Data
{
    public class FeatureModelContext : DbContext
    {
        public FeatureModelContext (DbContextOptions<FeatureModelContext> options)
            : base(options)
        {
        }

        public DbSet<opticron_clone.Models.FeatureModel> FeatureModel { get; set; } = default!;
    }
}
