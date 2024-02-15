
using System.Security.Cryptography;

namespace MutiTenancy;

public class TenancyManager : ITenancyManager
{
    public Tenant.Tenant? GetTenant(string tenantName)
        => tenantName switch
        {
            "client1" => new Tenant.Tenant { Id = 1, Title = "Client1" },
            "client2" => new Tenant.Tenant { Id = 2, Title = "Client2" },
            "client3" => new Tenant.Tenant { Id = 3, Title = "Client3" },
            _ => null
        };
}