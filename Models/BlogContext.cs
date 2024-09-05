using Microsoft.EntityFrameworkCore;

namespace BlogApp.Models {
    public class BlogContext : DbContext {
        public DbSet<BlogPost> BlogPosts {get; set;}
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) {}
    }
}