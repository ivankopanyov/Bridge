namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmPrices
{
    public decimal? ServiceId { get; set; }
    public string? Resort { get; set; }
    public decimal? PriceId { get; set; }
    public string? PriceCode { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? BeginTimeHh24mi { get; set; }
    public string? EndTimeHh24mi { get; set; }
    public string? Dayofweek { get; set; }
    public decimal? Price { get; set; }
    public decimal? PriceDuration { get; set; }
    public decimal? AllowedOvertimePerc { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmPrices>(entity =>
        {
            entity.HasKey(e => new { e.ServiceId, e.Resort, e.PriceId, e.PriceCode })
                .HasName("LM_PRICES_PK");

            entity.ToTable("LM_PRICES");

            entity.HasIndex(e => new { e.Resort, e.BeginDate, e.EndDate, e.BeginTimeHh24mi, e.EndTimeHh24mi, e.Dayofweek })
                .HasName("LM_PRICES_IND");

            entity.Property(e => e.ServiceId)
                .HasColumnName("SERVICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PriceId)
                .HasColumnName("PRICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriceCode)
                .HasColumnName("PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllowedOvertimePerc)
                .HasColumnName("ALLOWED_OVERTIME_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BeginTimeHh24mi)
                .IsRequired()
                .HasColumnName("BEGIN_TIME_HH24MI")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Dayofweek)
                .HasColumnName("DAYOFWEEK")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndTimeHh24mi)
                .IsRequired()
                .HasColumnName("END_TIME_HH24MI")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriceDuration)
                .HasColumnName("PRICE_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
