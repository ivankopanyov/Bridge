namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsBookingClassCodeDtls
{
    public string? Resort { get; set; }
    public string? YieldCategory { get; set; }
    public string? ClassCode { get; set; }
    public string? AttributeCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual OrmsBookingClassCodes OrmsBookingClassCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsBookingClassCodeDtls>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.YieldCategory, e.ClassCode, e.AttributeCode })
                .HasName("ORMS_BOOKING_CLASS_CDDTL_PK");

            entity.ToTable("ORMS_BOOKING_CLASS_CODE_DTLS");

            entity.HasIndex(e => new { e.Resort, e.AttributeCode })
                .HasName("ORMS_BOOKING_CLASSES_ATTR");

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

			if (!types.Contains(typeof(OrmsBookingClassCodes)))
				entity.Ignore(e => e.OrmsBookingClassCodes);
			else
	            entity.HasOne(d => d.OrmsBookingClassCodes)
	                .WithMany(p => p.OrmsBookingClassCodeDtls)
	                .HasForeignKey(d => new { d.Resort, d.YieldCategory, d.ClassCode })
	                .HasConstraintName("ORMS_BOOKING_CLASS_CDDTL_FK");
        });
	}
}
