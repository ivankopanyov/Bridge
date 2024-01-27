namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameRelationsView
{
    public decimal? NameXrefId { get; set; }
    public string NameType { get; set; }
    public decimal? NameId { get; set; }
    public string XrefName { get; set; }
    public string RelationshipType { get; set; }
    public string RelationshipDesc { get; set; }
    public string InheritRatesYn { get; set; }
    public string ToNameType { get; set; }
    public decimal? RelationToNameId { get; set; }
    public string RelatedToName { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string ToRelationship { get; set; }
    public string ToDescription { get; set; }
    public string PrimaryYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameRelationsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_RELATIONS_VIEW");

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

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameXrefId)
                .HasColumnName("NAME_XREF_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RelatedToName)
                .HasColumnName("RELATED_TO_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.RelationToNameId)
                .HasColumnName("RELATION_TO_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RelationshipDesc)
                .HasColumnName("RELATIONSHIP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipType)
                .HasColumnName("RELATIONSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToDescription)
                .HasColumnName("TO_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ToNameType)
                .HasColumnName("TO_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToRelationship)
                .HasColumnName("TO_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.XrefName)
                .HasColumnName("XREF_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);
        });
	}
}
