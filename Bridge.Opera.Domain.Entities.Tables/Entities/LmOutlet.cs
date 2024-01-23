namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmOutlet
{
    public string OutletCode { get; set; }
    public string Resort { get; set; }
    public string OutletDesc { get; set; }
    public string OutletType { get; set; }
    public string OutletLongDesc { get; set; }
    public string TimePatternCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmOutlet>(entity =>
        {
            entity.HasKey(e => new { e.OutletCode, e.Resort })
                .HasName("LM_OUTLET_PK");

            entity.ToTable("LM_OUTLET");

            entity.Property(e => e.OutletCode)
                .HasColumnName("OUTLET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
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

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutletDesc)
                .IsRequired()
                .HasColumnName("OUTLET_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OutletLongDesc)
                .HasColumnName("OUTLET_LONG_DESC")
                .IsUnicode(false);

            entity.Property(e => e.OutletType)
                .IsRequired()
                .HasColumnName("OUTLET_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TimePatternCode)
                .HasColumnName("TIME_PATTERN_CODE")
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
        });
	}
}
