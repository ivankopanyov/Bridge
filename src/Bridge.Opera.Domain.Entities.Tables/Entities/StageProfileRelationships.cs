namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileRelationships
{
    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? RelationshipType { get; set; }
    public string? RelatedToNameType { get; set; }
    public decimal? RelatedToNameId { get; set; }
    public string? RelatedToName { get; set; }
    public string? PrimaryYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? ValidYn { get; set; }
    public string? ErrorDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileRelationships>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_PROFILE_RELATIONSHIPS");

            entity.HasIndex(e => new { e.Resort, e.ResortNameId })
                .HasName("STAGE_PROF_REL_IND1");

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RelatedToName)
                .HasColumnName("RELATED_TO_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RelatedToNameId)
                .HasColumnName("RELATED_TO_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RelatedToNameType)
                .HasColumnName("RELATED_TO_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipType)
                .IsRequired()
                .HasColumnName("RELATIONSHIP_TYPE")
                .HasMaxLength(20)
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

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
