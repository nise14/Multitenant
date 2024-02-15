using MutiTenancy.Tenant;

namespace MutiTenancy;

public static class Extensions
{
    public static IServiceCollection AddMultiTenancy(this IServiceCollection services)
    {
        services.AddScoped<ITenancyManager, TenancyManager>();
        services.AddScoped<Tenant.Tenant>();
        services.AddScoped<ITenant>(s => s.GetRequiredService<Tenant.Tenant>());
        services.AddScoped<ITenantSetter>(s => s.GetRequiredService<Tenant.Tenant>());

        return services;
    }
}