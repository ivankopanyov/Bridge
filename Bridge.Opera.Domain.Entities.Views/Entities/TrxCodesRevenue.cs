namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TrxCodesRevenue
{
    public string Resort { get; set; }
    public string TcGroup { get; set; }
    public string TcSubgroup { get; set; }
    public string TrxCode { get; set; }
    public string Description { get; set; }
    public decimal? DayRevenue { get; set; }
    public decimal? MonthRevenue { get; set; }
    public decimal? YearRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxCodesRevenue>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TRX_CODES_REVENUE");

            entity.Property(e => e.DayRevenue)
                .HasColumnName("DAY_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MonthRevenue)
                .HasColumnName("MONTH_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcGroup)
                .IsRequired()
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .IsRequired()
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YearRevenue)
                .HasColumnName("YEAR_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}
