namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExportRelationships
{
    public string RecordType { get; set; }
    public string SourceSystem { get; set; }
    public string BusinessDate { get; set; }
    public decimal NameId { get; set; }
    public string Udfc40 { get; set; }
    public string ProfileName { get; set; }
    public decimal RelationToNameId { get; set; }
    public string RelationToName { get; set; }
    public string RelationToDesc { get; set; }
    public string RelationToUdfc40 { get; set; }
    public string RelationshipType { get; set; }
    public string RelationshipDesc { get; set; }
    public string PrimaryYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExportRelationships>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXPORT_RELATIONSHIPS");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProfileName)
                .HasColumnName("PROFILE_NAME")
                .HasMaxLength(82)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.RelationToDesc)
                .HasColumnName("RELATION_TO_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RelationToName)
                .HasColumnName("RELATION_TO_NAME")
                .HasMaxLength(82)
                .IsUnicode(false);

            entity.Property(e => e.RelationToNameId)
                .HasColumnName("RELATION_TO_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RelationToUdfc40)
                .HasColumnName("RELATION_TO_UDFC40")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipDesc)
                .HasColumnName("RELATIONSHIP_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipType)
                .IsRequired()
                .HasColumnName("RELATIONSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.Udfc40)
                .HasColumnName("UDFC40")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
