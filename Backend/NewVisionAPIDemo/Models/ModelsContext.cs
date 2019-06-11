using Microsoft.EntityFrameworkCore;

namespace NewVisionAPIDemo.Models {
    public class ModelsContext : DbContext{
        public ModelsContext(DbContextOptions<ModelsContext> options) : base(options) { }

        public DbSet<Article> Articles { get; set; }
    }
}
