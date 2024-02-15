namespace MutiTenancy.Tenant;

public interface ITenantSetter
{
    int Id { set; }
    string Title { set; }
}