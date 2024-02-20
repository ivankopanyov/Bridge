namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InstalledAppLog
{
    public string? Application { get; set; }
    public string? Version { get; set; }
    public DateTime? InstalledDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? Epatchlevel { get; set; }
    public string? Client { get; set; }
    public string? NextVersion { get; set; }
    public string? NextVersion2 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InstalledAppLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INSTALLED_APP_LOG");

            entity.Property(e => e.Application)
                .IsRequired()
                .HasColumnName("APPLICATION")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Client)
                .HasColumnName("CLIENT")
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Epatchlevel)
                .HasColumnName("EPATCHLEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InstalledDate)
                .HasColumnName("INSTALLED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NextVersion)
                .HasColumnName("NEXT_VERSION")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.NextVersion2)
                .HasColumnName("NEXT_VERSION2")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Version)
                .IsRequired()
                .HasColumnName("VERSION")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
