namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationUpsale
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? OriginalRoomCategory { get; set; }
    public DateTime? BusinessDateCreated { get; set; }
    public string? OriginalRateCode { get; set; }
    public decimal? OriginalTotalAmount { get; set; }
    public decimal? OriginalNights { get; set; }
    public string? OriginalProducts { get; set; }
    public string? OriginalCurrencyCode { get; set; }
    public string? UpsellRoomCategory { get; set; }
    public decimal? FirstNightUpsellAmt { get; set; }
    public decimal? TotalUpsellMoneyAmt { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpsellRuleId { get; set; }
    public decimal? OriginalAllotmentHeaderId { get; set; }
    public decimal? FirstNightUpsellCharge { get; set; }
    public decimal? TotalUpsellCharge { get; set; }
    public string? OriginalFixedRateYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationUpsale>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId })
                .HasName("RESERVATION_UPSALE_PK");

            entity.ToTable("RESERVATION_UPSALE");

            entity.HasIndex(e => new { e.BusinessDateCreated, e.Resort })
                .HasName("RESERVATION_UPSALE_IDX2");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.FirstNightUpsellAmt)
                .HasColumnName("FIRST_NIGHT_UPSELL_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstNightUpsellCharge)
                .HasColumnName("FIRST_NIGHT_UPSELL_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalAllotmentHeaderId)
                .HasColumnName("ORIGINAL_ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalCurrencyCode)
                .HasColumnName("ORIGINAL_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OriginalFixedRateYn)
                .HasColumnName("ORIGINAL_FIXED_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OriginalNights)
                .HasColumnName("ORIGINAL_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalProducts)
                .HasColumnName("ORIGINAL_PRODUCTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OriginalRateCode)
                .HasColumnName("ORIGINAL_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OriginalRoomCategory)
                .HasColumnName("ORIGINAL_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OriginalTotalAmount)
                .HasColumnName("ORIGINAL_TOTAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalUpsellCharge)
                .HasColumnName("TOTAL_UPSELL_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalUpsellMoneyAmt)
                .HasColumnName("TOTAL_UPSELL_MONEY_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpsellRoomCategory)
                .HasColumnName("UPSELL_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpsellRuleId)
                .HasColumnName("UPSELL_RULE_ID")
                .HasColumnType("NUMBER");
        });
	}
}
