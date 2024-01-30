namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpAwardsByDateRange
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? IsNoShowYn { get; set; }
    public DateTime? AwardFromDate { get; set; }
    public DateTime? AwardToDate { get; set; }
    public string? AwardVoucher1 { get; set; }
    public string? LoyaltyMemberNo { get; set; }
    public string? LoyaltyMemberType { get; set; }
    public string? PropertyCode { get; set; }
    public string? PropertyCurrencyCode { get; set; }
    public string? InstAwardCode { get; set; }
    public string? InstAwardAmount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpAwardsByDateRange>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_AWARDS_BY_DATE_RANGE");

            entity.Property(e => e.AwardFromDate)
                .HasColumnName("AWARD_FROM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AwardToDate)
                .HasColumnName("AWARD_TO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AwardVoucher1)
                .HasColumnName("AWARD_VOUCHER_1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InstAwardAmount)
                .HasColumnName("INST_AWARD_AMOUNT")
                .IsUnicode(false);

            entity.Property(e => e.InstAwardCode)
                .HasColumnName("INST_AWARD_CODE")
                .IsUnicode(false);

            entity.Property(e => e.IsNoShowYn)
                .HasColumnName("IS_NO_SHOW_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.LoyaltyMemberNo)
                .HasColumnName("LOYALTY_MEMBER_NO")
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyMemberType)
                .HasColumnName("LOYALTY_MEMBER_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCurrencyCode)
                .HasColumnName("PROPERTY_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
