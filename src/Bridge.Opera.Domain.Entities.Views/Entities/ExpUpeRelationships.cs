namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeRelationships
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? NameXrefId { get; set; }
    public string? Resort { get; set; }
    public string? RelationshipType { get; set; }
    public string? RelationshipDesc { get; set; }
    public string? PrimaryYn { get; set; }
    public string? RelationshipRole { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? LaptopChange { get; set; }
    public decimal? NameId { get; set; }
    public decimal? RelationToNameId { get; set; }
    public string? Name { get; set; }
    public string? RName { get; set; }
    public string? First { get; set; }
    public string? RFirst { get; set; }
    public string? NameType { get; set; }
    public string? RNameType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeRelationships>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_RELATIONSHIPS");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameXrefId)
                .HasColumnName("NAME_XREF_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RFirst)
                .HasColumnName("R_FIRST")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RName)
                .HasColumnName("R_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RNameType)
                .HasColumnName("R_NAME_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RelationToNameId)
                .HasColumnName("RELATION_TO_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RelationshipDesc)
                .HasColumnName("RELATIONSHIP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipRole)
                .HasColumnName("RELATIONSHIP_ROLE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipType)
                .HasColumnName("RELATIONSHIP_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
