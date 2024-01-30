namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RateCodeLov
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? RateCategory { get; set; }
    public string? RateClass { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Description { get; set; }
    public string? Label { get; set; }
    public decimal? SellSequence { get; set; }
    public string? AsbRateCycle { get; set; }
    public string? VoucherBenefitRateYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateCodeLov>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RATE_CODE_LOV");

            entity.Property(e => e.AsbRateCycle)
                .HasColumnName("ASB_RATE_CYCLE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCategory)
                .IsRequired()
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateClass)
                .IsRequired()
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VoucherBenefitRateYn)
                .HasColumnName("VOUCHER_BENEFIT_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
