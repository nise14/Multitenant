namespace MutiTenancy.Tenant;

public interface ITenant
{
    int Id { get; set; }
    string Title { get; }
}