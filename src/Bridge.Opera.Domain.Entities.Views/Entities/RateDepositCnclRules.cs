namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RateDepositCnclRules
{
    public decimal? RateSetId { get; set; }
    public decimal? RateDcSeq { get; set; }
    public decimal? DepDaysPriorToArrival { get; set; }
    public decimal? DepDaysAfterBooking { get; set; }
    public decimal? DepAmount { get; set; }
    public string? DepAmountType { get; set; }
    public decimal? CnclDaysPriorToArrival { get; set; }
    public DateTime? CnclBeforeTime { get; set; }
    public decimal? CnclPenltyAmount { get; set; }
    public string? CnclPnltyAmountType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateDepositCnclRules>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RATE_DEPOSIT_CNCL_RULES");

            entity.Property(e => e.CnclBeforeTime)
                .HasColumnName("CNCL_BEFORE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.CnclDaysPriorToArrival)
                .HasColumnName("CNCL_DAYS_PRIOR_TO_ARRIVAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclPenltyAmount)
                .HasColumnName("CNCL_PENLTY_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CnclPnltyAmountType)
                .HasColumnName("CNCL_PNLTY_AMOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepAmount)
                .HasColumnName("DEP_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepAmountType)
                .HasColumnName("DEP_AMOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepDaysAfterBooking)
                .HasColumnName("DEP_DAYS_AFTER_BOOKING")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepDaysPriorToArrival)
                .HasColumnName("DEP_DAYS_PRIOR_TO_ARRIVAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateDcSeq)
                .HasColumnName("RATE_DC_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateSetId)
                .HasColumnName("RATE_SET_ID")
                .HasColumnType("NUMBER");
        });
	}
}
