namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameXref
{
    public decimal? NameXrefId { get; set; }
    public decimal? NameId { get; set; }
    public string? RelationshipType { get; set; }
    public string? RelationshipDesc { get; set; }
    public decimal? RelationToNameId { get; set; }
    public string? PrimaryYn { get; set; }
    public string? RelationshipRole { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? Resort { get; set; }
    public byte? LaptopChange { get; set; }

    public virtual Name Name { get; set; }
    public virtual Name RelationToName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameXref>(entity =>
        {
            entity.ToTable("NAME$XREF");

            entity.HasIndex(e => e.InactiveDate)
                .HasName("NAME_XREF_INACTIVE_DT_IDX");

            entity.HasIndex(e => e.NameId)
                .HasName("NAME_XREF_N2");

            entity.HasIndex(e => e.RelationToNameId)
                .HasName("NAME_XREF_N1");

            entity.HasIndex(e => e.RelationshipType)
                .HasName("NAME_XREF_TYPE_IDX");

            entity.Property(e => e.NameXrefId)
                .HasColumnName("NAME_XREF_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.RelationToNameId)
                .HasColumnName("RELATION_TO_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RelationshipDesc)
                .HasColumnName("RELATIONSHIP_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipRole)
                .HasColumnName("RELATIONSHIP_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipType)
                .IsRequired()
                .HasColumnName("RELATIONSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.NameXrefName)
	                .HasForeignKey(d => d.NameId)
	                .HasConstraintName("NAME_ID_FK8");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.RelationToName);
			else
	            entity.HasOne(d => d.RelationToName)
	                .WithMany(p => p.NameXrefRelationToName)
	                .HasForeignKey(d => d.RelationToNameId)
	                .HasConstraintName("NAME_TO_ID_FK");
        });
	}
}
