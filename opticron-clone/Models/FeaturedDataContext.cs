using FeaturedData.Models;
using Microsoft.EntityFrameworkCore;

namespace FeaturedData;

public class FeaturedDataContext : DbContext
{
    public DbSet<FeaturedItem> Items { get; set; }

    public FeaturedDataContext(DbContextOptions options) : base(options)
    {
        
    }
}
