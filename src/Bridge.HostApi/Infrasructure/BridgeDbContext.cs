namespace Bridge.HostApi.Infrasructure;

public class BridgeDbContext : IdentityDbContext<User, Role, long>
{
    public virtual DbSet<Models.Host> Hosts { get; set; }

    public virtual DbSet<Models.Service> Services { get; set; }

    public virtual DbSet<Options> Options { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=bridge.db");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Models.Host>(entity => entity.HasKey(h => h.Name));

        builder.Entity<Models.Service>(entity =>
        {
            entity.HasKey(s => new { s.HostName, s.ServiceName });

            entity
                .HasOne(s => s.Host)
                .WithMany(h => h.Services)
                .HasForeignKey(h => h.HostName);

            entity
                .HasOne(s => s.Options)
                .WithOne(o => o.Service)
                .HasPrincipalKey<Models.Service>(s => new { s.HostName, s.ServiceName })
                .HasForeignKey<Options>(o => new { o.HostName, o.ServiceName })
                .IsRequired();
        });

        builder.Entity<Options>(entity =>
        {
            entity.HasKey(o => new { o.HostName, o.ServiceName });

            entity
                .HasOne(o => o.Host)
                .WithMany(h => h.Options)
                .HasForeignKey(o => o.HostName);
        });
    }
}
