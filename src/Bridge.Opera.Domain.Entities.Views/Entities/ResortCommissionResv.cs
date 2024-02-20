namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResortCommissionResv
{
    public string? Resort { get; set; }
    public string? CommissionCode { get; set; }
    public string? Description { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? SellSequence { get; set; }
    public decimal? VatAmount { get; set; }
    public string? ManualFlatPercentage { get; set; }
    public string? CommissionCalcRule { get; set; }
    public decimal? ManualCommission { get; set; }
    public string? ManualPerNight { get; set; }
    public string? ManualPerStay { get; set; }
    public string? CommissionType { get; set; }
    public string? HoldArYn { get; set; }
    public string? HoldPrepaidYn { get; set; }
    public string? HoldAlwaysYn { get; set; }
    public string? PerNight { get; set; }
    public string? PerStay { get; set; }
    public decimal? FlatAmount { get; set; }
    public string? CommFlatPercentage { get; set; }
    public decimal? WkndAmt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortCommissionResv>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESORT_COMMISSION_RESV");

            entity.Property(e => e.CommFlatPercentage)
                .HasColumnName("COMM_FLAT_PERCENTAGE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CommissionCalcRule)
                .HasColumnName("COMMISSION_CALC_RULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommissionCode)
                .IsRequired()
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommissionType)
                .HasColumnName("COMMISSION_TYPE")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FlatAmount)
                .HasColumnName("FLAT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HoldAlwaysYn)
                .HasColumnName("HOLD_ALWAYS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HoldArYn)
                .HasColumnName("HOLD_AR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HoldPrepaidYn)
                .HasColumnName("HOLD_PREPAID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ManualCommission)
                .HasColumnName("MANUAL_COMMISSION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ManualFlatPercentage)
                .HasColumnName("MANUAL_FLAT_PERCENTAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ManualPerNight)
                .HasColumnName("MANUAL_PER_NIGHT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ManualPerStay)
                .HasColumnName("MANUAL_PER_STAY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PerNight)
                .HasColumnName("PER_NIGHT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PerStay)
                .HasColumnName("PER_STAY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VatAmount)
                .HasColumnName("VAT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WkndAmt)
                .HasColumnName("WKND_AMT")
                .HasColumnType("NUMBER");
        });
	}
}
