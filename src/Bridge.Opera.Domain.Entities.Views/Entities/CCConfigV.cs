namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CCConfigV
{
    public string Resort { get; set; }
    public string HotelId { get; set; }
    public decimal? TimeOut { get; set; }
    public decimal? ApprovalAmountCalcMethod { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Percentage { get; set; }
    public decimal? CCInterfaceSetupId { get; set; }
    public decimal? CCReaderDeviceId { get; set; }
    public string CcOverHttpEnabledYn { get; set; }
    public string CcHttpServiceProvider { get; set; }
    public string CcHttpServiceUrl { get; set; }
    public decimal? CcDefaultCashier { get; set; }
    public string SdcLocationYn { get; set; }
    public string SdcTerminalYn { get; set; }
    public string CcAmexDirectYn { get; set; }
    public string CcEodYn { get; set; }
    public string AutoAuthActiveYn { get; set; }
    public decimal? AutoAuthInterval { get; set; }
    public decimal? AuthorizationValidForDays { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CCConfigV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("C_C_CONFIG_V");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApprovalAmountCalcMethod)
                .HasColumnName("APPROVAL_AMOUNT_CALC_METHOD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AuthorizationValidForDays)
                .HasColumnName("AUTHORIZATION_VALID_FOR_DAYS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AutoAuthActiveYn)
                .HasColumnName("AUTO_AUTH_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AutoAuthInterval)
                .HasColumnName("AUTO_AUTH_INTERVAL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CCInterfaceSetupId)
                .HasColumnName("C_C_INTERFACE_SETUP_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CCReaderDeviceId)
                .HasColumnName("C_C_READER_DEVICE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcAmexDirectYn)
                .HasColumnName("CC_AMEX_DIRECT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcDefaultCashier)
                .HasColumnName("CC_DEFAULT_CASHIER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcEodYn)
                .HasColumnName("CC_EOD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CcHttpServiceProvider)
                .HasColumnName("CC_HTTP_SERVICE_PROVIDER")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcHttpServiceUrl)
                .HasColumnName("CC_HTTP_SERVICE_URL")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcOverHttpEnabledYn)
                .HasColumnName("CC_OVER_HTTP_ENABLED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HotelId)
                .HasColumnName("HOTEL_ID")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Percentage)
                .HasColumnName("PERCENTAGE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.SdcLocationYn)
                .HasColumnName("SDC_LOCATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SdcTerminalYn)
                .HasColumnName("SDC_TERMINAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TimeOut)
                .HasColumnName("TIME_OUT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
