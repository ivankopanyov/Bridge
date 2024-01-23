namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NaUnzipedFilesDir
{
    public string Resort { get; set; }
    public string DirName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NaUnzipedFilesDir>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.DirName })
                .HasName("NA_UNZIPED_FILES_DIR");

            entity.ToTable("NA_UNZIPED_FILES_DIR");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DirName)
                .HasColumnName("DIR_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
