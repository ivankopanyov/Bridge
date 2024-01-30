namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameDocuments
{
    public decimal? DocumentId { get; set; }
    public decimal? NameId { get; set; }
    public string? Resort { get; set; }
    public string? IdType { get; set; }
    public string? IdNumber { get; set; }
    public DateTime? IdDate { get; set; }
    public string? IdPlace { get; set; }
    public string? IdCountry { get; set; }
    public decimal? IdDocumentAttachId { get; set; }
    public string? PrimaryYn { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? SIdNumber { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual Name Name { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameDocuments>(entity =>
        {
            entity.HasKey(e => e.DocumentId)
                .HasName("NAME_DOCUMENT_PK");

            entity.ToTable("NAME_DOCUMENTS");

            entity.HasIndex(e => e.IdNumber)
                .HasName("NAME_DOCUMENTS_ID_IDX");

            entity.HasIndex(e => e.InactiveDate)
                .HasName("INACTIVE_DATE_IDX");

            entity.HasIndex(e => e.SIdNumber)
                .HasName("S_ID_NUMBER_IDX");

            entity.HasIndex(e => new { e.NameId, e.Resort, e.IdType, e.IdNumber })
                .HasName("NAME_DOCUMENTS_UK")
                .IsUnique();

            entity.Property(e => e.DocumentId)
                .HasColumnName("DOCUMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IdCountry)
                .HasColumnName("ID_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IdDate)
                .HasColumnName("ID_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IdDocumentAttachId)
                .HasColumnName("ID_DOCUMENT_ATTACH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IdNumber)
                .IsRequired()
                .HasColumnName("ID_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IdPlace)
                .HasColumnName("ID_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IdType)
                .IsRequired()
                .HasColumnName("ID_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.NameDocuments)
	                .HasForeignKey(d => d.NameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("NAME_DOCUMENT_NAME_FK");
        });
	}
}
