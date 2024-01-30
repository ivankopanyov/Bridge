namespace Bridge.Opera.Domain.Entities.Tables;

public partial class VendorScanner
{
    public string? Resort { get; set; }
    public string? VendorName { get; set; }
    public string? VendorJarFileName { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? ActiveYn { get; set; }
    public string? VendorMode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<VendorScanner>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.VendorName })
                .HasName("VENDOR_SCANNER_PK");

            entity.ToTable("VENDOR_SCANNER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VendorName)
                .HasColumnName("VENDOR_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VendorJarFileName)
                .IsRequired()
                .HasColumnName("VENDOR_JAR_FILE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.VendorMode)
                .HasColumnName("VENDOR_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
