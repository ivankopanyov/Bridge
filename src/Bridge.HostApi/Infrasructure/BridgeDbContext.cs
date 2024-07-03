namespace Bridge.HostApi.Infrasructure;

public class BridgeDbContext : IdentityDbContext<User, Role, long>
{
    private static readonly string _host = Environment.GetEnvironmentVariable("POSTGRES_HOST") ?? "postgres";
    private static readonly string _port = Environment.GetEnvironmentVariable("POSTGRES_PORT") ?? "5432";
    private static readonly string _user = Environment.GetEnvironmentVariable("POSTGRES_USER") ?? "postgres";
    private static readonly string _db = Environment.GetEnvironmentVariable("POSTGRES_DB") ?? "bridge";
    private static readonly string? _password = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD");
    private static readonly string _connectionString = $"Host={_host};Port={_port};Database={_db};User ID={_user};{(_password != null ? $"Password={_password};" : string.Empty)}";

    public virtual DbSet<Models.Host> Hosts { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<AppOptions> Options { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(_connectionString);

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

        builder.Entity<AppOptions>(entity => entity.HasKey(o => o.Id));
    }
}
