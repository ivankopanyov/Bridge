namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class StageProfileDocumentsVw
{
    public string? Rowidx { get; set; }
    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? IntIdType { get; set; }
    public string? IdType { get; set; }
    public string? IdNumber { get; set; }
    public string? IdNumberStr { get; set; }
    public string? EncryptedIdNumber { get; set; }
    public string? IdNumberColumn { get; set; }
    public DateTime? IdDate { get; set; }
    public string? IdPlace { get; set; }
    public string? IdCountry { get; set; }
    public string? DocumentResort { get; set; }
    public string? SIdNumber { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? ValidYn { get; set; }
    public string? ErrorDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileDocumentsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("STAGE_PROFILE_DOCUMENTS_VW");

            entity.Property(e => e.DocumentResort)
                .IsRequired()
                .HasColumnName("DOCUMENT_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EncryptedIdNumber)
                .HasColumnName("ENCRYPTED_ID_NUMBER")
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

            entity.Property(e => e.IdNumber)
                .HasColumnName("ID_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IdNumberColumn)
                .IsRequired()
                .HasColumnName("ID_NUMBER_COLUMN")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IdNumberStr)
                .HasColumnName("ID_NUMBER_STR")
                .HasMaxLength(200)
                .IsUnicode(false);

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

            entity.Property(e => e.IntIdType)
                .IsRequired()
                .HasColumnName("INT_ID_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .IsRequired()
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Rowidx)
                .HasColumnName("ROWIDX")
                .HasColumnType("ROWID");

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
