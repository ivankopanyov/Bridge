namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConBlkRate
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? RateStartDateNum { get; set; }
    public decimal? RateEndDateNum { get; set; }
    public decimal? NumOfNights { get; set; }
    public decimal? NumOfGuests { get; set; }
    public decimal? RateAmtBefTax { get; set; }
    public decimal? RateAmtAftTax { get; set; }
    public decimal? CommissionInd { get; set; }
    public string RoomCategory { get; set; }
    public string RateCode { get; set; }
    public string CurrencyCode { get; set; }
    public string MarketCode { get; set; }
    public string MarketCodeDesc { get; set; }
    public DateTime? RateStartDate { get; set; }
    public DateTime? RateEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConBlkRate>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_BLK_RATE");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionInd)
                .HasColumnName("COMMISSION_IND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCodeDesc)
                .HasColumnName("MARKET_CODE_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NumOfGuests)
                .HasColumnName("NUM_OF_GUESTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumOfNights)
                .HasColumnName("NUM_OF_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmtAftTax)
                .HasColumnName("RATE_AMT_AFT_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmtBefTax)
                .HasColumnName("RATE_AMT_BEF_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateEndDate)
                .HasColumnName("RATE_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateEndDateNum)
                .HasColumnName("RATE_END_DATE_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateStartDate)
                .HasColumnName("RATE_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateStartDateNum)
                .HasColumnName("RATE_START_DATE_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
