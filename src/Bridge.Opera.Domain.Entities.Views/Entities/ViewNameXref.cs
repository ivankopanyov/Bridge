namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ViewNameXref
{
    public decimal? NameXrefId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? RelationToNameId { get; set; }
    public string? RelationshipType { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? PrimaryYn { get; set; }
    public string? RelationshipDesc { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? First { get; set; }
    public string? LastCompany { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ViewNameXref>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("VIEW_NAME_XREF");

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastCompany)
                .HasColumnName("LAST_COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameXrefId)
                .HasColumnName("NAME_XREF_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RelationToNameId)
                .HasColumnName("RELATION_TO_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RelationshipDesc)
                .HasColumnName("RELATIONSHIP_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipType)
                .IsRequired()
                .HasColumnName("RELATIONSHIP_TYPE")
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
