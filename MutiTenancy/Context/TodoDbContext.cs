using Microsoft.EntityFrameworkCore;
using MutiTenancy.Entities;
using MutiTenancy.Tenant;

namespace MutiTenancy.Context;

public class TodoDbContext : DbContext
{
    private readonly ITenant _tenant;

    public TodoDbContext(DbContextOptions<TodoDbContext> options, ITenant tenant) : base(options)
    {
        _tenant = tenant;
    }

    public DbSet<TodoItem> Todos => Set<TodoItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.Entity<TodoItem>().HasQueryFilter(t => t.TenantId == _tenant.Id);

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<TodoItem>())
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.TenantId = _tenant.Id;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}