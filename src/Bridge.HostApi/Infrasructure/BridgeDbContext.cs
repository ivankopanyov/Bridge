using Bridge.HostApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bridge.HostApi.Infrasructure;

public class BridgeDbContext : IdentityDbContext<User, Role, long>
{
    public virtual DbSet<Models.Host> Hosts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=bridge.db");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Models.Host>(e => e.HasKey(h => h.Name));
    }
}
