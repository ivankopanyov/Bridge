namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InstalledApp
{
    public string Application { get; set; }
    public string Version { get; set; }
    public DateTime? InstalledDate { get; set; }
    public string Configuration { get; set; }
    public string AppType { get; set; }
    public string Epatchlevel { get; set; }
    public string NextVersion { get; set; }
    public string NextVersion2 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InstalledApp>(entity =>
        {
            entity.HasKey(e => e.Application)
                .HasName("INST_APP_PK");

            entity.ToTable("INSTALLED_APP");

            entity.Property(e => e.Application)
                .HasColumnName("APPLICATION")
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("'OPERA_PMS'");

            entity.Property(e => e.AppType)
                .HasColumnName("APP_TYPE")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.Configuration)
                .HasColumnName("CONFIGURATION")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Epatchlevel)
                .HasColumnName("EPATCHLEVEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InstalledDate)
                .HasColumnName("INSTALLED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

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
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
