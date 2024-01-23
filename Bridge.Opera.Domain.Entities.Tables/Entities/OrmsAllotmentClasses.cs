namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsAllotmentClasses
{
    public OrmsAllotmentClasses()
    {
        OrmsAllotmentClassesDetails = new HashSet<OrmsAllotmentClassesDetails>();
    }

    public string Resort { get; set; }
    public string ClassCode { get; set; }
    public string ClassDescription { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual ICollection<OrmsAllotmentClassesDetails> OrmsAllotmentClassesDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAllotmentClasses>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ClassCode })
                .HasName("ORMS_ALLOTMENT_CLASSES_PK");

            entity.ToTable("ORMS_ALLOTMENT_CLASSES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClassCode)
                .HasColumnName("CLASS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClassDescription)
                .IsRequired()
                .HasColumnName("CLASS_DESCRIPTION")
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
        
			if (!types.Contains(typeof(OrmsAllotmentClassesDetails)))
				entity.Ignore(e => e.OrmsAllotmentClassesDetails);
		});
	}
}
