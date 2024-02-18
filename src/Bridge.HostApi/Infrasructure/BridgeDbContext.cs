namespace Bridge.HostApi.Infrasructure;

public class BridgeDbContext : IdentityDbContext<User, Role, long>
{
    public virtual DbSet<Models.Host> Hosts { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=bridge.db");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Models.Host>(entity => entity.HasKey(h => h.Name));

        builder.Entity<Service>(entity =>
        {
            entity.HasKey(s => new { s.HostName, s.ServiceName });

            entity
                .HasOne(s => s.Host)
                .WithMany(h => h.Services)
                .HasForeignKey(h => h.HostName);
        });
    }
}
