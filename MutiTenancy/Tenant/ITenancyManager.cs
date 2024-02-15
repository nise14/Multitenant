namespace MutiTenancy;

public interface ITenancyManager
{
    Tenant.Tenant? GetTenant(string tenantName);
}