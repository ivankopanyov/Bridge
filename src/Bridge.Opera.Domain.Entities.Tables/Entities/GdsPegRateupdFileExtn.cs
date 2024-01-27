namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsPegRateupdFileExtn
{
    public string Resort { get; set; }
    public string FileExtension { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsPegRateupdFileExtn>(entity =>
        {
            entity.HasKey(e => e.Resort)
                .HasName("GDS_PEG_RATEUPD_FILE_EXTN_PK");

            entity.ToTable("GDS_PEG_RATEUPD_FILE_EXTN");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FileExtension)
                .IsRequired()
                .HasColumnName("FILE_EXTENSION")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
