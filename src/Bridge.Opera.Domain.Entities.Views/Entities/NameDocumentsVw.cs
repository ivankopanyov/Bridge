namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameDocumentsVw
{
    public decimal? DocumentId { get; set; }
    public decimal? NameId { get; set; }
    public string? Resort { get; set; }
    public string? IdType { get; set; }
    public string? IdNumber { get; set; }
    public string? IdNumberStr { get; set; }
    public string? EncryptedIdNumber { get; set; }
    public string? IdNumberColumn { get; set; }
    public DateTime? IdDate { get; set; }
    public string? IdPlace { get; set; }
    public string? IdCountry { get; set; }
    public decimal? IdDocumentAttachId { get; set; }
    public string? Attachment { get; set; }
    public string? PrimaryYn { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? SIdNumber { get; set; }
    public string? DocumentRole { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameDocumentsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_DOCUMENTS_VW");

            entity.Property(e => e.Attachment)
                .HasColumnName("ATTACHMENT")
                .IsUnicode(false);

            entity.Property(e => e.DocumentId)
                .HasColumnName("DOCUMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DocumentRole)
                .HasColumnName("DOCUMENT_ROLE")
                .IsUnicode(false);

            entity.Property(e => e.EncryptedIdNumber)
                .IsRequired()
                .HasColumnName("ENCRYPTED_ID_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IdCountry)
                .HasColumnName("ID_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IdDate)
                .HasColumnName("ID_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IdDocumentAttachId)
                .HasColumnName("ID_DOCUMENT_ATTACH_ID")
                .HasColumnType("NUMBER");

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
                .IsRequired()
                .HasColumnName("ID_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SIdNumber)
                .HasColumnName("S_ID_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
