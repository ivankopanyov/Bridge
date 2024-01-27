namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsBookingClassCodes
{
    public OrmsBookingClassCodes()
    {
        OrmsBookingClassCodeDtls = new HashSet<OrmsBookingClassCodeDtls>();
    }

    public string Resort { get; set; }
    public string YieldCategory { get; set; }
    public string ClassCode { get; set; }
    public string ClassDescription { get; set; }
    public string ClassType { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual ICollection<OrmsBookingClassCodeDtls> OrmsBookingClassCodeDtls { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsBookingClassCodes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.YieldCategory, e.ClassCode })
                .HasName("ORMS_BOOKING_CLASS_CODES_PK");

            entity.ToTable("ORMS_BOOKING_CLASS_CODES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
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

            entity.Property(e => e.ClassType)
                .IsRequired()
                .HasColumnName("CLASS_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'T'");

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
        
			if (!types.Contains(typeof(OrmsBookingClassCodeDtls)))
				entity.Ignore(e => e.OrmsBookingClassCodeDtls);
		});
	}
}
