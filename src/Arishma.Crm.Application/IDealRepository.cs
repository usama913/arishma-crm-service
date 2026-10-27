namespace Arishma.Crm.Application;
public interface IDealRepository
{
    Task<IReadOnlyList<DealDto>> ListAsync(CancellationToken ct = default);
}
