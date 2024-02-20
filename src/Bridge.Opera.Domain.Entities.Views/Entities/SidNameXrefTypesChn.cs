namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidNameXrefTypesChn
{
    public string? IndividualYn { get; set; }
    public string? Relationship { get; set; }
    public string? Description { get; set; }
    public string? InheritRatesYn { get; set; }
    public string? ToDescription { get; set; }
    public string? ToIndividualYn { get; set; }
    public string? ToInheritRatesYn { get; set; }
    public string? ToRelationship { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? RelationCategory { get; set; }
    public string? FromType { get; set; }
    public string? ToType { get; set; }
    public string? RelationshipRole { get; set; }
    public string? PrimaryYn { get; set; }
    public string? CanDeleteYn { get; set; }
    public string? HierarchyYn { get; set; }
    public string? ChainCode { get; set; }
    public string? GlobalYn { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidNameXrefTypesChn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_NAME$_XREF_TYPES_CHN");

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FromType)
                .IsRequired()
                .HasColumnName("FROM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GlobalYn)
                .HasColumnName("GLOBAL_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.HierarchyYn)
                .HasColumnName("HIERARCHY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IndividualYn)
                .IsRequired()
                .HasColumnName("INDIVIDUAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InheritRatesYn)
                .HasColumnName("INHERIT_RATES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RelationCategory)
                .IsRequired()
                .HasColumnName("RELATION_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Relationship)
                .IsRequired()
                .HasColumnName("RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipRole)
                .HasColumnName("RELATIONSHIP_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToDescription)
                .HasColumnName("TO_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ToIndividualYn)
                .HasColumnName("TO_INDIVIDUAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ToInheritRatesYn)
                .HasColumnName("TO_INHERIT_RATES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ToRelationship)
                .HasColumnName("TO_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToType)
                .IsRequired()
                .HasColumnName("TO_TYPE")
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
