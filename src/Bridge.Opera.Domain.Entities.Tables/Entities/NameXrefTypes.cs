namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameXrefTypes
{
    public string ToRelationship { get; set; }
    public string ToIndividualYn { get; set; }
    public string RelationCategory { get; set; }
    public string ToInheritRatesYn { get; set; }
    public string PrimaryYn { get; set; }
    public string Relationship { get; set; }
    public string RelationshipRole { get; set; }
    public string FromType { get; set; }
    public string ToDescription { get; set; }
    public decimal InsertUser { get; set; }
    public string ToType { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public string IndividualYn { get; set; }
    public string InheritRatesYn { get; set; }
    public string Description { get; set; }
    public string CanDeleteYn { get; set; }
    public string GlobalYn { get; set; }
    public string HierarchyYn { get; set; }
    public string ChainCode { get; set; }
    public string IgnoreProtectionYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameXrefTypes>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.Relationship, e.FromType, e.RelationCategory, e.ToType })
                .HasName("NAME$_XREF_TYPES_PK");

            entity.ToTable("NAME$_XREF_TYPES");

            entity.HasIndex(e => new { e.RelationCategory, e.Relationship, e.FromType, e.ToType, e.ChainCode })
                .HasName("NAME$_XREF_TYPE_RELATION_UIDX")
                .IsUnique();

            entity.HasIndex(e => new { e.RelationCategory, e.ToRelationship, e.FromType, e.ToType, e.ChainCode })
                .HasName("NAME$_XREF_TYPE_RELATION");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Relationship)
                .HasColumnName("RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FromType)
                .HasColumnName("FROM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RelationCategory)
                .HasColumnName("RELATION_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ToType)
                .HasColumnName("TO_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GlobalYn)
                .HasColumnName("GLOBAL_YN")
                .HasColumnType("CHAR(1)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HierarchyYn)
                .HasColumnName("HIERARCHY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IgnoreProtectionYn)
                .HasColumnName("IGNORE_PROTECTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IndividualYn)
                .IsRequired()
                .HasColumnName("INDIVIDUAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InheritRatesYn)
                .HasColumnName("INHERIT_RATES_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RelationshipRole)
                .HasColumnName("RELATIONSHIP_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ToDescription)
                .HasColumnName("TO_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ToIndividualYn)
                .HasColumnName("TO_INDIVIDUAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ToInheritRatesYn)
                .HasColumnName("TO_INHERIT_RATES_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ToRelationship)
                .HasColumnName("TO_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
