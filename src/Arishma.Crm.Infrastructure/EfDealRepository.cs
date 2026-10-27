using Arishma.Crm.Application;
namespace Arishma.Crm.Infrastructure;
public class EfDealRepository : IDealRepository
{
    private readonly AppDbContext _db;
    public EfDealRepository(AppDbContext db) => _db = db;
    // Phase 0: scaffold returns no rows and never requires a live DB for /health.
    // Phase 1: replace with a real query over _db.Deals.
    public Task<IReadOnlyList<DealDto>> ListAsync(CancellationToken ct = default)
        => Task.FromResult<IReadOnlyList<DealDto>>(Array.Empty<DealDto>());
}
