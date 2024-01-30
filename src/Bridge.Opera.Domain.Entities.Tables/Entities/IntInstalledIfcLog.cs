namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntInstalledIfcLog
{
    public string? Interfacename { get; set; }
    public string? Interfacetype { get; set; }
    public string? Version { get; set; }
    public DateTime? InstalledDate { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntInstalledIfcLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_INSTALLED_IFC_LOG");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql(@"sysdate");

            entity.Property(e => e.InstalledDate)
                .HasColumnName("INSTALLED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Interfacename)
                .HasColumnName("INTERFACENAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Interfacetype)
                .HasColumnName("INTERFACETYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Version)
                .HasColumnName("VERSION")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
