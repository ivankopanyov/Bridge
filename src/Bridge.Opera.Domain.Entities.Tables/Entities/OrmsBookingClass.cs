namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsBookingClass
{
    public OrmsBookingClass()
    {
        OrmsResvcnclDist = new HashSet<OrmsResvcnclDist>();
    }

    public decimal? BookingClassId { get; set; }
    public string? Resort { get; set; }
    public string? YieldCategory { get; set; }
    public string? ClassCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual YieldCategories YieldCategories { get; set; }
    public virtual ICollection<OrmsResvcnclDist> OrmsResvcnclDist { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsBookingClass>(entity =>
        {
            entity.HasKey(e => e.BookingClassId)
                .HasName("BOOKING_CLASS_PK");

            entity.ToTable("ORMS_BOOKING_CLASS");

            entity.HasIndex(e => new { e.Resort, e.YieldCategory, e.ClassCode })
                .HasName("BOOKING_CLASS_UK1")
                .IsUnique();

            entity.Property(e => e.BookingClassId)
                .HasColumnName("BOOKING_CLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClassCode)
                .IsRequired()
                .HasColumnName("CLASS_CODE")
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

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YieldCategory)
                .IsRequired()
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(YieldCategories)))
				entity.Ignore(e => e.YieldCategories);
			else
	            entity.HasOne(d => d.YieldCategories)
	                .WithMany(p => p.OrmsBookingClass)
	                .HasForeignKey(d => new { d.Resort, d.YieldCategory })
	                .HasConstraintName("BOOKING_CLASS_FK");
        
			if (!types.Contains(typeof(OrmsResvcnclDist)))
				entity.Ignore(e => e.OrmsResvcnclDist);
		});
	}
}
