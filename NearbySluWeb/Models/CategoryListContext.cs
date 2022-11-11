using Microsoft.EntityFrameworkCore;

namespace NearbySluWeb.Models
{
    public class CategoryListContext: DbContext
    {

        public CategoryListContext(DbContextOptions<CategoryListContext> options) : base(options)
        { }

        public DbSet<CategoryList> CategoryList { get; set; }
    }
}
