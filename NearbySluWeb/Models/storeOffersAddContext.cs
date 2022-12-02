using Microsoft.EntityFrameworkCore;

namespace NearbySluWeb.Models
{
    public class storeOffersAddContext:DbContext
    {
        public storeOffersAddContext(DbContextOptions<storeOffersAddContext> options) : base(options)
        { }

        public DbSet<storeOffersAdd> OffersDetails { get; set; }
    }
}
