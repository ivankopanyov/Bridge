namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GdsRateRoomView
{
    public string RoomCat { get; set; }
    public string RateCat { get; set; }
    public string RateCode { get; set; }
    public string NativeCurrencyCode { get; set; }
    public string TaxDescription { get; set; }
    public decimal? BookedAmount { get; set; }
    public decimal? TotalBookedAmount { get; set; }
    public decimal? HighRate { get; set; }
    public decimal? FirstNightRate { get; set; }
    public decimal? MostCommonRate { get; set; }
    public string RateChangeIndicator { get; set; }
    public string RateDescription { get; set; }
    public string RoomDescription { get; set; }
    public string RateFrequency { get; set; }
    public string CancelTime { get; set; }
    public DateTime? CnclTime { get; set; }
    public DateTime? CancelDate { get; set; }
    public string DepositDate { get; set; }
    public string MandatoryDeposit { get; set; }
    public string DepositGuaranteeFlag { get; set; }
    public string LateArrivalTime { get; set; }
    public decimal? CommissionAmount { get; set; }
    public string OnRequest { get; set; }
    public string HoldExists { get; set; }
    public string CorpAccountNumber { get; set; }
    public string FrequentGuestNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string CompanyName { get; set; }
    public string NegRateCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateRoomView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GDS_RATE_ROOM_VIEW");

            entity.Property(e => e.BookedAmount)
                .HasColumnName("BOOKED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelDate)
                .HasColumnName("CANCEL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelTime)
                .HasColumnName("CANCEL_TIME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CnclTime)
                .HasColumnName("CNCL_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.CommissionAmount)
                .HasColumnName("COMMISSION_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CorpAccountNumber)
                .HasColumnName("CORP_ACCOUNT_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepositDate)
                .HasColumnName("DEPOSIT_DATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepositGuaranteeFlag)
                .HasColumnName("DEPOSIT_GUARANTEE_FLAG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FirstNightRate)
                .HasColumnName("FIRST_NIGHT_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FrequentGuestNumber)
                .HasColumnName("FREQUENT_GUEST_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HighRate)
                .HasColumnName("HIGH_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HoldExists)
                .HasColumnName("HOLD_EXISTS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LateArrivalTime)
                .HasColumnName("LATE_ARRIVAL_TIME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MandatoryDeposit)
                .HasColumnName("MANDATORY_DEPOSIT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MiddleName)
                .HasColumnName("MIDDLE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MostCommonRate)
                .HasColumnName("MOST_COMMON_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NativeCurrencyCode)
                .HasColumnName("NATIVE_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NegRateCode)
                .HasColumnName("NEG_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OnRequest)
                .HasColumnName("ON_REQUEST")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateCat)
                .HasColumnName("RATE_CAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateChangeIndicator)
                .HasColumnName("RATE_CHANGE_INDICATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateDescription)
                .HasColumnName("RATE_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.RateFrequency)
                .HasColumnName("RATE_FREQUENCY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoomCat)
                .HasColumnName("ROOM_CAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomDescription)
                .HasColumnName("ROOM_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.TaxDescription)
                .HasColumnName("TAX_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.TotalBookedAmount)
                .HasColumnName("TOTAL_BOOKED_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}
