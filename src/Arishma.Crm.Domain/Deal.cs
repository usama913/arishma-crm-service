namespace Arishma.Crm.Domain;
public class Deal
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Title { get; set; } = "";
    public string Stage { get; set; } = "New";
    public decimal ValueUsd { get; set; }
}
