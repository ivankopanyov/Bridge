namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExternalReferences
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ExternalReferenceType { get; set; }
    public string? ExternalReference { get; set; }
    public decimal? ExternalLegNo { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? UpperExternalReference { get; set; }
    public string? ManualYn { get; set; }
    public string? ExternalStatus { get; set; }
    public string? ExtCancellationNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExternalReferences>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.ExternalReferenceType })
                .HasName("EXTERNAL_REFERENCES_PK");

            entity.ToTable("EXTERNAL_REFERENCES");

            entity.HasIndex(e => new { e.ExternalReference, e.Resort })
                .HasName("EXTERNAL_REFERENCE_EXT_RESORT");

            entity.HasIndex(e => new { e.UpperExternalReference, e.Resort })
                .HasName("EXTERNAL_REFERENCE_UPPER_EXT");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalReferenceType)
                .HasColumnName("EXTERNAL_REFERENCE_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ExtCancellationNo)
                .HasColumnName("EXT_CANCELLATION_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExternalLegNo)
                .HasColumnName("EXTERNAL_LEG_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalReference)
                .IsRequired()
                .HasColumnName("EXTERNAL_REFERENCE")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExternalStatus)
                .HasColumnName("EXTERNAL_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ManualYn)
                .HasColumnName("MANUAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpperExternalReference)
                .HasColumnName("UPPER_EXTERNAL_REFERENCE")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
