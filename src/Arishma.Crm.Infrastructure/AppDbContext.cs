using Microsoft.EntityFrameworkCore;
using Arishma.Crm.Domain;
namespace Arishma.Crm.Infrastructure;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Deal> Deals => Set<Deal>();
    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<Deal>().ToTable("deals");
        base.OnModelCreating(b);
    }
}
