using Microsoft.EntityFrameworkCore;

namespace NearbySluWeb.Models
{
    public class addNewPlaceContext:DbContext
    {
        public addNewPlaceContext(DbContextOptions<addNewPlaceContext> options) : base(options)
        { }

        public DbSet<addNewPlace> PlaceDetails { get; set; }
    }
}
