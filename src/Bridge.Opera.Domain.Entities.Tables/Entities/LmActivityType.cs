namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmActivityType
{
    public string? ActType { get; set; }
    public string? Resort { get; set; }
    public string? ActTypeDesc { get; set; }
    public string? ActTypeLongDesc { get; set; }
    public string? OutletType { get; set; }
    public string? InternalYn { get; set; }
    public decimal? ToleranceDurCheckin { get; set; }
    public decimal? ToleranceDurCheckout { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmActivityType>(entity =>
        {
            entity.HasKey(e => new { e.ActType, e.Resort })
                .HasName("LM_ACT_TYPE_PK");

            entity.ToTable("LM_ACTIVITY_TYPE");

            entity.Property(e => e.ActType)
                .HasColumnName("ACT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActTypeDesc)
                .IsRequired()
                .HasColumnName("ACT_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActTypeLongDesc)
                .HasColumnName("ACT_TYPE_LONG_DESC")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutletType)
                .HasColumnName("OUTLET_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToleranceDurCheckin)
                .HasColumnName("TOLERANCE_DUR_CHECKIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToleranceDurCheckout)
                .HasColumnName("TOLERANCE_DUR_CHECKOUT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
