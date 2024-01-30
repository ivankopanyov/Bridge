namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InvItemsExtReferences
{
    public string? Resort { get; set; }
    public string? ParentType { get; set; }
    public decimal? ParentId { get; set; }
    public string? ExtReferenceType { get; set; }
    public string? ExternalReference { get; set; }
    public decimal? ExternalLegNo { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InvItemsExtReferences>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ParentType, e.ParentId, e.ExtReferenceType })
                .HasName("IIE_PK");

            entity.ToTable("INV_ITEMS_EXT_REFERENCES");

            entity.HasIndex(e => new { e.Resort, e.ParentType, e.ExtReferenceType, e.ExternalReference })
                .HasName("INV_ITEMS_EXT_REF_INDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParentType)
                .HasColumnName("PARENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParentId)
                .HasColumnName("PARENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtReferenceType)
                .HasColumnName("EXT_REFERENCE_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ExternalLegNo)
                .HasColumnName("EXTERNAL_LEG_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalReference)
                .IsRequired()
                .HasColumnName("EXTERNAL_REFERENCE")
                .HasMaxLength(50)
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
