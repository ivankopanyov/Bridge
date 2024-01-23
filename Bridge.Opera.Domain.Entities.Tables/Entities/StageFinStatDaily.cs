namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageFinStatDaily
{
    public decimal StageRecordId { get; set; }
    public string InterfaceId { get; set; }
    public DateTime? ImportDate { get; set; }
    public string StageStatus { get; set; }
    public string StageSuspenseReason { get; set; }
    public decimal? SetId { get; set; }
    public string ConfirmationId { get; set; }
    public string ReservationId { get; set; }
    public decimal? MfConfirmationLegNo { get; set; }
    public string Resort { get; set; }
    public DateTime BusinessDate { get; set; }
    public string PmsResvNo { get; set; }
    public string PmsDeptCode { get; set; }
    public string PmsNameId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public string TrxCode { get; set; }
    public string TcSubgroup { get; set; }
    public string MarketCode { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? GrossAmount { get; set; }
    public string CentralCurrencyCode { get; set; }
    public decimal? CentralExchangeRate { get; set; }
    public decimal? CompanyId { get; set; }
    public string CheckNumber { get; set; }
    public string CheckNumberId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageFinStatDaily>(entity =>
        {
            entity.HasKey(e => e.StageRecordId)
                .HasName("STAGE_FIN_STAT_DAILY_PK");

            entity.ToTable("STAGE_FIN_STAT_DAILY");

            entity.HasIndex(e => new { e.ImportDate, e.Resort })
                .HasName("STAGE_FIN_STAT_DAILY_IND1");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.PmsResvNo, e.PmsDeptCode, e.MarketCode })
                .HasName("STAGE_FIN_STAT_DAILY_IND2");

            entity.Property(e => e.StageRecordId)
                .HasColumnName("STAGE_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CentralCurrencyCode)
                .HasColumnName("CENTRAL_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CentralExchangeRate)
                .HasColumnName("CENTRAL_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckNumber)
                .HasColumnName("CHECK_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CheckNumberId)
                .HasColumnName("CHECK_NUMBER_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationId)
                .HasColumnName("CONFIRMATION_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ImportDate)
                .HasColumnName("IMPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MfConfirmationLegNo)
                .HasColumnName("MF_CONFIRMATION_LEG_NO")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PmsDeptCode)
                .IsRequired()
                .HasColumnName("PMS_DEPT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsNameId)
                .HasColumnName("PMS_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsResvNo)
                .IsRequired()
                .HasColumnName("PMS_RESV_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ReservationId)
                .HasColumnName("RESERVATION_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetId)
                .HasColumnName("SET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StageStatus)
                .HasColumnName("STAGE_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StageSuspenseReason)
                .HasColumnName("STAGE_SUSPENSE_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
