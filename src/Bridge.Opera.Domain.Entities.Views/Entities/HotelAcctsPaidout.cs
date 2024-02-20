namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HotelAcctsPaidout
{
    public string? Resort { get; set; }
    public string? AcctCode { get; set; }
    public string? AcctDesc { get; set; }
    public decimal? DayPaidout { get; set; }
    public decimal? MonthPaidout { get; set; }
    public decimal? YearPaidout { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HotelAcctsPaidout>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HOTEL_ACCTS_PAIDOUT");

            entity.Property(e => e.AcctCode)
                .IsRequired()
                .HasColumnName("ACCT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AcctDesc)
                .HasColumnName("ACCT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DayPaidout)
                .HasColumnName("DAY_PAIDOUT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthPaidout)
                .HasColumnName("MONTH_PAIDOUT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YearPaidout)
                .HasColumnName("YEAR_PAIDOUT")
                .HasColumnType("NUMBER");
        });
	}
}
