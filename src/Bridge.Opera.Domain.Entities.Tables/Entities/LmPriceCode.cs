namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmPriceCode
{
    public string? PriceCode { get; set; }
    public string? Resort { get; set; }
    public string? PriceDesc { get; set; }
    public string? DefaultYn { get; set; }
    public string? PriceShortDesc { get; set; }
    public string? PriceLongDesc { get; set; }
    public string? Color { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmPriceCode>(entity =>
        {
            entity.HasKey(e => new { e.PriceCode, e.Resort })
                .HasName("LM_PRICE_CODE_PK");

            entity.ToTable("LM_PRICE_CODE");

            entity.Property(e => e.PriceCode)
                .HasColumnName("PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Color)
                .HasColumnName("COLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .IsRequired()
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.PriceDesc)
                .IsRequired()
                .HasColumnName("PRICE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PriceLongDesc)
                .HasColumnName("PRICE_LONG_DESC")
                .IsUnicode(false);

            entity.Property(e => e.PriceShortDesc)
                .HasColumnName("PRICE_SHORT_DESC")
                .HasMaxLength(80)
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
