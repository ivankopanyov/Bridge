namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DocumentTemplates
{
    public decimal? DocId { get; set; }
    public string? DocumentTag { get; set; }
    public string? DocumentName { get; set; }
    public string? Description { get; set; }
    public byte[] DocumentBlob { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? DefaultYn { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DocumentTemplates>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.DocId })
                .HasName("DOCTMP_PK");

            entity.ToTable("DOCUMENT_TEMPLATES");

            entity.HasIndex(e => new { e.DocumentTag, e.DocumentName, e.ChainCode })
                .HasName("DOCTMP_UK")
                .IsUnique();

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DocId)
                .HasColumnName("DOC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DocumentBlob)
                .HasColumnName("DOCUMENT_BLOB")
                .HasColumnType("BLOB");

            entity.Property(e => e.DocumentName)
                .IsRequired()
                .HasColumnName("DOCUMENT_NAME")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.DocumentTag)
                .IsRequired()
                .HasColumnName("DOCUMENT_TAG")
                .HasMaxLength(200)
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
        });
	}
}
