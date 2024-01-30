namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileDocuments
{
    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? DocumentResort { get; set; }
    public string? IntIdType { get; set; }
    public string? IdNumber { get; set; }
    public string? IdType { get; set; }
    public string? SIdNumber { get; set; }
    public DateTime? IdDate { get; set; }
    public string? IdPlace { get; set; }
    public string? IdCountry { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? ValidYn { get; set; }
    public string? ErrorDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileDocuments>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResortNameId, e.DocumentResort, e.IntIdType, e.IdNumber })
                .HasName("STAGE_PROFILE_DOCUMENTS_PK");

            entity.ToTable("STAGE_PROFILE_DOCUMENTS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DocumentResort)
                .HasColumnName("DOCUMENT_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IntIdType)
                .HasColumnName("INT_ID_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.IdNumber)
                .HasColumnName("ID_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IdCountry)
                .HasColumnName("ID_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IdDate)
                .HasColumnName("ID_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IdPlace)
                .HasColumnName("ID_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.IdType)
                .HasColumnName("ID_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SIdNumber)
                .HasColumnName("S_ID_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
