namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TaCommissionView
{
    public string? Resort { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? AccountId { get; set; }
    public string? TaName { get; set; }
    public string? StaName { get; set; }
    public string? City { get; set; }
    public string? IataNo { get; set; }
    public string? HoldCode { get; set; }
    public string? Ptype { get; set; }
    public string? CommissionCode { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? CommissionAmt { get; set; }
    public decimal? ARAmt { get; set; }
    public decimal? PrepaidComm { get; set; }
    public decimal? HoldAmt { get; set; }
    public decimal? FcCommissionAmt { get; set; }
    public decimal? FcHoldAmt { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? DecimalPositions { get; set; }
    public string? Tax1No { get; set; }
    public decimal? HoldCounter { get; set; }
    public decimal? RecordCounter { get; set; }
    public decimal? JoinedArHoldCounter { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaCommissionView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TA_COMMISSION_VIEW");

            entity.Property(e => e.ARAmt)
                .HasColumnName("A_R_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CommissionAmt)
                .HasColumnName("COMMISSION_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.DecimalPositions)
                .HasColumnName("DECIMAL_POSITIONS")
                .HasColumnType("NUMBER(30)");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcCommissionAmt)
                .HasColumnName("FC_COMMISSION_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcHoldAmt)
                .HasColumnName("FC_HOLD_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HoldAmt)
                .HasColumnName("HOLD_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HoldCode)
                .HasColumnName("HOLD_CODE")
                .IsUnicode(false);

            entity.Property(e => e.HoldCounter)
                .HasColumnName("HOLD_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IataNo)
                .HasColumnName("IATA_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.JoinedArHoldCounter)
                .HasColumnName("JOINED_AR_HOLD_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrepaidComm)
                .HasColumnName("PREPAID_COMM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ptype)
                .HasColumnName("PTYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.RecordCounter)
                .HasColumnName("RECORD_COUNTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StaName)
                .IsRequired()
                .HasColumnName("STA_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaName)
                .HasColumnName("TA_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Tax1No)
                .HasColumnName("TAX1_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");
        });
	}
}
