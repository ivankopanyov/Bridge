namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ViewNameXrefTypes
{
    public string? Relationship { get; set; }
    public string? Description { get; set; }
    public string? ToRelationship { get; set; }
    public string? ToDescription { get; set; }
    public string? FromType { get; set; }
    public string? ToType { get; set; }
    public string? PrimaryYn { get; set; }
    public string? IndividualYn { get; set; }
    public string? ToInheritRatesYn { get; set; }
    public string? InheritRatesYn { get; set; }
    public string? CanDeleteYn { get; set; }
    public string? GlobalYn { get; set; }
    public string? HierarchyYn { get; set; }
    public string? IgnoreProtectionYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ViewNameXrefTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("VIEW_NAME_XREF_TYPES");

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FromType)
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

            entity.Property(e => e.IgnoreProtectionYn)
                .HasColumnName("IGNORE_PROTECTION_YN")
                .IsUnicode(false);

            entity.Property(e => e.IndividualYn)
                .HasColumnName("INDIVIDUAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InheritRatesYn)
                .HasColumnName("INHERIT_RATES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Relationship)
                .HasColumnName("RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToDescription)
                .HasColumnName("TO_DESCRIPTION")
                .HasMaxLength(2000)
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
                .HasColumnName("TO_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
