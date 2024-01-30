namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntVersionDependency
{
    public string? Interfacename { get; set; }
    public string? Interfacetype { get; set; }
    public string? IntVersion { get; set; }
    public string? PmsVersion { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? Comments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntVersionDependency>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_VERSION_DEPENDENCY");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IntVersion)
                .IsRequired()
                .HasColumnName("INT_VERSION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Interfacename)
                .IsRequired()
                .HasColumnName("INTERFACENAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Interfacetype)
                .IsRequired()
                .HasColumnName("INTERFACETYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsVersion)
                .IsRequired()
                .HasColumnName("PMS_VERSION")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
