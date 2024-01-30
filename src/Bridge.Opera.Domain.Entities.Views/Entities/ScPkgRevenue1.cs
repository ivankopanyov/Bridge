namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScPkgRevenue1
{
    public decimal? ExpectedCost { get; set; }
    public decimal? ExpectedRevenue { get; set; }
    public decimal? ForecastRevenue { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? PkgEvLink { get; set; }
    public decimal? PkgPriceLink { get; set; }
    public string? RevenueGroup { get; set; }
    public string? RevenueType { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScPkgRevenue1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_PKG_REVENUE");

            entity.Property(e => e.ExpectedCost)
                .HasColumnName("EXPECTED_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpectedRevenue)
                .HasColumnName("EXPECTED_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ForecastRevenue)
                .HasColumnName("FORECAST_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PkgEvLink)
                .HasColumnName("PKG_EV_LINK")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PkgPriceLink)
                .HasColumnName("PKG_PRICE_LINK")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueGroup)
                .HasColumnName("REVENUE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueType)
                .IsRequired()
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
