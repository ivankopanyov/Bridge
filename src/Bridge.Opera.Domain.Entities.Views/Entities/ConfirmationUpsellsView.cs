namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ConfirmationUpsellsView
{
    public decimal? ResvNameId { get; set; }
    public decimal? UpsellOfferId { get; set; }
    public string? ToRateCode { get; set; }
    public string? FromRoomCategory { get; set; }
    public string? ToRoomCategory { get; set; }
    public string? ToRoomCategoryLabel { get; set; }
    public string? FromRoomClass { get; set; }
    public string? ToRoomClass { get; set; }
    public decimal? FirstNightRateAmt { get; set; }
    public decimal? TotalStayAmt { get; set; }
    public decimal? FirstNightUpsell { get; set; }
    public decimal? TotUpsellMoneyAmt { get; set; }
    public decimal? TotalRankingValue { get; set; }
    public string? RateSourceType { get; set; }
    public string? RateSource { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public string? Channel { get; set; }
    public string? GuaranteeType { get; set; }
    public string? MarketCode { get; set; }
    public decimal? UpsellRuleId { get; set; }
    public string? UpsellCode { get; set; }
    public string? InConfResort { get; set; }
    public decimal? FirstNightUpsellCharge { get; set; }
    public decimal? TotalUpsellCharge { get; set; }
    public string? RoomCategoryDescription { get; set; }
    public string? RoomFeatures { get; set; }
    public string? VFirstNightAmtFmt { get; set; }
    public string? VTotalStayAmtFmt { get; set; }
    public string? VFirstNgtUpsellFmt { get; set; }
    public string? VTotUpsellMoneyFmt { get; set; }
    public string? VFirstNightChrgFmt { get; set; }
    public string? VTotUpsellChrgFmt { get; set; }
    public string? CurrencyCode { get; set; }
    public string? RoomCategoryDescriptionLong { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ConfirmationUpsellsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CONFIRMATION_UPSELLS_VIEW");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FirstNightRateAmt)
                .HasColumnName("FIRST_NIGHT_RATE_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstNightUpsell)
                .HasColumnName("FIRST_NIGHT_UPSELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstNightUpsellCharge)
                .HasColumnName("FIRST_NIGHT_UPSELL_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromRoomCategory)
                .HasColumnName("FROM_ROOM_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FromRoomClass)
                .HasColumnName("FROM_ROOM_CLASS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeType)
                .HasColumnName("GUARANTEE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InConfResort)
                .HasColumnName("IN_CONF_RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateSource)
                .HasColumnName("RATE_SOURCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateSourceType)
                .HasColumnName("RATE_SOURCE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategoryDescription)
                .HasColumnName("ROOM_CATEGORY_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryDescriptionLong)
                .HasColumnName("ROOM_CATEGORY_DESCRIPTION_LONG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomFeatures)
                .HasColumnName("ROOM_FEATURES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ToRateCode)
                .HasColumnName("TO_RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ToRoomCategory)
                .HasColumnName("TO_ROOM_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ToRoomCategoryLabel)
                .HasColumnName("TO_ROOM_CATEGORY_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ToRoomClass)
                .HasColumnName("TO_ROOM_CLASS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TotUpsellMoneyAmt)
                .HasColumnName("TOT_UPSELL_MONEY_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRankingValue)
                .HasColumnName("TOTAL_RANKING_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalStayAmt)
                .HasColumnName("TOTAL_STAY_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalUpsellCharge)
                .HasColumnName("TOTAL_UPSELL_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpsellCode)
                .HasColumnName("UPSELL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpsellOfferId)
                .HasColumnName("UPSELL_OFFER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpsellRuleId)
                .HasColumnName("UPSELL_RULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VFirstNgtUpsellFmt)
                .HasColumnName("V_FIRST_NGT_UPSELL_FMT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.VFirstNightAmtFmt)
                .HasColumnName("V_FIRST_NIGHT_AMT_FMT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.VFirstNightChrgFmt)
                .HasColumnName("V_FIRST_NIGHT_CHRG_FMT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.VTotUpsellChrgFmt)
                .HasColumnName("V_TOT_UPSELL_CHRG_FMT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.VTotUpsellMoneyFmt)
                .HasColumnName("V_TOT_UPSELL_MONEY_FMT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.VTotalStayAmtFmt)
                .HasColumnName("V_TOTAL_STAY_AMT_FMT")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
