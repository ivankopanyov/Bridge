namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CcAuthRulesV
{
    public string Resort { get; set; }
    public string GuaranteeCode { get; set; }
    public string SourceCode { get; set; }
    public decimal? ApprovalAmountCalcMethod { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Percentage { get; set; }
    public decimal? MaxDaysToAuthorize { get; set; }
    public string IgnoreDepositsYn { get; set; }
    public string RoomCategory { get; set; }
    public string RoomClass { get; set; }
    public string RateCode { get; set; }
    public string RateCategory { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CcAuthRulesV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CC_AUTH_RULES_V");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApprovalAmountCalcMethod)
                .HasColumnName("APPROVAL_AMOUNT_CALC_METHOD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IgnoreDepositsYn)
                .HasColumnName("IGNORE_DEPOSITS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MaxDaysToAuthorize)
                .HasColumnName("MAX_DAYS_TO_AUTHORIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Percentage)
                .HasColumnName("PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
