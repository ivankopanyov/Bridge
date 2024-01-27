namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsAllotmentClassesDetails
{
    public string Resort { get; set; }
    public string ClassCode { get; set; }
    public string AttributeCode { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual OrmsAllotmentClasses OrmsAllotmentClasses { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAllotmentClassesDetails>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ClassCode, e.AttributeCode })
                .HasName("ORMS_ALLOTMENT_CLASSES_DTLS_PK");

            entity.ToTable("ORMS_ALLOTMENT_CLASSES_DETAILS");

            entity.HasIndex(e => new { e.Resort, e.AttributeCode })
                .HasName("ORMS_ALLOTMENT_CLASSES_ATTR");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClassCode)
                .HasColumnName("CLASS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AttributeCode)
                .HasColumnName("ATTRIBUTE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(OrmsAllotmentClasses)))
				entity.Ignore(e => e.OrmsAllotmentClasses);
			else
	            entity.HasOne(d => d.OrmsAllotmentClasses)
	                .WithMany(p => p.OrmsAllotmentClassesDetails)
	                .HasForeignKey(d => new { d.Resort, d.ClassCode })
	                .HasConstraintName("ORMS_ALLOTMENT_CLASSES_DTLS_FK");
        });
	}
}
