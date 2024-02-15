namespace MutiTenancy.Tenant;

public class Tenant : ITenant, ITenantSetter
{
    public int Id { get; set; }
    public required string Title { get; set;}
}