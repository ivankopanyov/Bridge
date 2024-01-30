namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BiImportFiles
{
    public string? Filename { get; set; }
    public string? FileType { get; set; }
    public DateTime? LastAccess { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BiImportFiles>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BI_IMPORT_FILES");

            entity.Property(e => e.FileType)
                .HasColumnName("FILE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Filename)
                .HasColumnName("FILENAME")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.LastAccess)
                .HasColumnName("LAST_ACCESS")
                .HasColumnType("DATE");
        });
	}
}
