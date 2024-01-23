namespace Bridge.Opera.Domain.Entities.Tables;

public partial class KioskIfcSetup
{
    public string Resort { get; set; }
    public string ExtCcAuthorizationYn { get; set; }
    public string AdvanceBillAtCheckinYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string AllowCheckoutWindows { get; set; }
    public string CheckoutPayeeGuestYn { get; set; }
    public string AllowCheckinYn { get; set; }
    public string AllowCheckoutYn { get; set; }
    public string NameValidationYn { get; set; }
    public string AllowedRateCodes { get; set; }
    public string ReportGenerationType { get; set; }
    public DateTime? CheckinStartTime { get; set; }
    public DateTime? CheckinStopTime { get; set; }
    public DateTime? CheckoutStartTime { get; set; }
    public DateTime? CheckoutStopTime { get; set; }
    public string DefaultMarketCode { get; set; }
    public string DefaultSourceCode { get; set; }
    public string AvailablePackageCodes { get; set; }
    public string RmtyUpdRateChngYn { get; set; }
    public string RmtyUpdMultRateYn { get; set; }
    public byte? PriceDeltaUpPct { get; set; }
    public byte? PriceDeltaLowPct { get; set; }
    public string CkinPaymentMethods { get; set; }
    public string PrintPayeeGuestYn { get; set; }
    public string ChannelCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<KioskIfcSetup>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ChannelCode })
                .HasName("KIS_PK");

            entity.ToTable("KIOSK_IFC_SETUP");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChannelCode)
                .HasColumnName("CHANNEL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'KIOSK'");

            entity.Property(e => e.AdvanceBillAtCheckinYn)
                .HasColumnName("ADVANCE_BILL_AT_CHECKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AllowCheckinYn)
                .HasColumnName("ALLOW_CHECKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AllowCheckoutWindows)
                .HasColumnName("ALLOW_CHECKOUT_WINDOWS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AllowCheckoutYn)
                .HasColumnName("ALLOW_CHECKOUT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AllowedRateCodes)
                .HasColumnName("ALLOWED_RATE_CODES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AvailablePackageCodes)
                .HasColumnName("AVAILABLE_PACKAGE_CODES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CheckinStartTime)
                .HasColumnName("CHECKIN_START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.CheckinStopTime)
                .HasColumnName("CHECKIN_STOP_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.CheckoutPayeeGuestYn)
                .HasColumnName("CHECKOUT_PAYEE_GUEST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CheckoutStartTime)
                .HasColumnName("CHECKOUT_START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.CheckoutStopTime)
                .HasColumnName("CHECKOUT_STOP_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.CkinPaymentMethods)
                .HasColumnName("CKIN_PAYMENT_METHODS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DefaultMarketCode)
                .HasColumnName("DEFAULT_MARKET_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DefaultSourceCode)
                .HasColumnName("DEFAULT_SOURCE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ExtCcAuthorizationYn)
                .HasColumnName("EXT_CC_AUTHORIZATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameValidationYn)
                .HasColumnName("NAME_VALIDATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PriceDeltaLowPct)
                .HasColumnName("PRICE_DELTA_LOW_PCT")
                .HasColumnType("NUMBER(4)");

            entity.Property(e => e.PriceDeltaUpPct)
                .HasColumnName("PRICE_DELTA_UP_PCT")
                .HasColumnType("NUMBER(4)");

            entity.Property(e => e.PrintPayeeGuestYn)
                .HasColumnName("PRINT_PAYEE_GUEST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ReportGenerationType)
                .HasColumnName("REPORT_GENERATION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmtyUpdMultRateYn)
                .HasColumnName("RMTY_UPD_MULT_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RmtyUpdRateChngYn)
                .HasColumnName("RMTY_UPD_RATE_CHNG_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
