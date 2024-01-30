namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidTmplDepCancelRulesChn
{
    public string? RuleType { get; set; }
    public string? RuleCode { get; set; }
    public string? RuleDescription { get; set; }
    public decimal? DepDaysPriorToArrival { get; set; }
    public decimal? DepDaysAfterBooking { get; set; }
    public decimal? DepAmount { get; set; }
    public string? DepAmountType { get; set; }
    public decimal? CnclDaysPriorToArrival { get; set; }
    public DateTime? CnclBeforeTime { get; set; }
    public decimal? CnclPenltyAmount { get; set; }
    public string? CnclPnltyAmountType { get; set; }
    public string? ReservationType { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidTmplDepCancelRulesChn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_TMPL_DEP_CANCEL_RULES_CHN");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationType)
                .HasColumnName("RESERVATION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleCode)
                .IsRequired()
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleDescription)
                .HasColumnName("RULE_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RuleType)
                .IsRequired()
                .HasColumnName("RULE_TYPE")
                .HasMaxLength(10)
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
