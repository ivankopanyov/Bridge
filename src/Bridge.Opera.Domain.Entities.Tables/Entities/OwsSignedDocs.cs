namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsSignedDocs
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string Type { get; set; }
    public int? FolioView { get; set; }
    public string FileType { get; set; }
    public byte[] FileData { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsSignedDocs>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OWS_SIGNED_DOCS");

            entity.HasIndex(e => new { e.ResvNameId, e.Type, e.FolioView })
                .HasName("OWS_SIGNED_DOCS_IDX1")
                .IsUnique();

            entity.Property(e => e.FileData)
                .HasColumnName("FILE_DATA")
                .HasColumnType("BLOB");

            entity.Property(e => e.FileType)
                .HasColumnName("FILE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER(9)");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasMaxLength(20)
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
