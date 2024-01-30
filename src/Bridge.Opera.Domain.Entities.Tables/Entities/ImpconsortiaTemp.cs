namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ImpconsortiaTemp
{
    public string? ConsortiaCode { get; set; }
    public string? IataCode { get; set; }
    public string? ImportStatus { get; set; }
    public DateTime? ImportDate { get; set; }
    public DateTime? ProfileUpdateDate { get; set; }
    public decimal? NameId { get; set; }
    public string? ImportCode { get; set; }
    public string? ImportMsg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ImpconsortiaTemp>(entity =>
        {
            entity.HasKey(e => new { e.ConsortiaCode, e.IataCode })
                .HasName("ITP_PK");

            entity.ToTable("IMPCONSORTIA_TEMP");

            entity.HasIndex(e => e.IataCode)
                .HasName("IMPCONSORTIA_TEMP_IDX1");

            entity.HasIndex(e => new { e.ImportStatus, e.ConsortiaCode, e.ImportCode })
                .HasName("IMPCONSORTIA_TEMP_IDX2");

            entity.Property(e => e.ConsortiaCode)
                .HasColumnName("CONSORTIA_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.IataCode)
                .HasColumnName("IATA_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ImportCode)
                .HasColumnName("IMPORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ImportDate)
                .HasColumnName("IMPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ImportMsg)
                .HasColumnName("IMPORT_MSG")
                .IsUnicode(false);

            entity.Property(e => e.ImportStatus)
                .IsRequired()
                .HasColumnName("IMPORT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileUpdateDate)
                .HasColumnName("PROFILE_UPDATE_DATE")
                .HasColumnType("DATE");
        });
	}
}
