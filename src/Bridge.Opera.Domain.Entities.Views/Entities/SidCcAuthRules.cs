namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidCcAuthRules
{
    public string? Resort { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? SourceCode { get; set; }
    public decimal? ApprovalAmountCalcMethod { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Percentage { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidCcAuthRules>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_CC_AUTH_RULES");

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

            entity.Property(e => e.Percentage)
                .HasColumnName("PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
