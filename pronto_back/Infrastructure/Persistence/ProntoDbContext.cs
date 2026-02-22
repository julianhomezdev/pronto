using Microsoft.EntityFrameworkCore;
using pronto_back.Domain.Entities;

namespace pronto_back.Infrastructure.Persistence
{
    public class ProntoDbContext : DbContext
    {

        public ProntoDbContext(DbContextOptions<ProntoDbContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
