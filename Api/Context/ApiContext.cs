using Microsoft.EntityFrameworkCore;
using Models;

namespace ApiInfra.Context
{
    public class ApiContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Post> Post { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options): base(options)
        { }
    }
}
