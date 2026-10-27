namespace Arishma.Crm.Application;
public record DealDto(Guid Id, string Name);
public record ServiceInfoDto(string Service, string Subdomain, string Status, string DatabaseProvider);
