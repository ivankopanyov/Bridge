namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SunUploadDetail
{
    public decimal? HeaderId { get; set; }
    public decimal? TrxId { get; set; }
    public string? MerchantReference { get; set; }
    public string? MerchantTerminal { get; set; }
    public string? TransactionCode { get; set; }
    public string? PurchaseDate { get; set; }
    public string? PurchaseTime { get; set; }
    public string? Amount { get; set; }
    public string? Ccnumber { get; set; }
    public string? CcStartDate { get; set; }
    public string? CcExpiryDate { get; set; }
    public string? AuthorisationCode { get; set; }
    public string? BudgetPeriod { get; set; }
    public string? OrgMerchantReference { get; set; }
    public string? ResultStatus { get; set; }
    public string? TransationStatus { get; set; }
    public string? CycleNumber { get; set; }
    public string? TraceNumber { get; set; }
    public string? ReconciliationStatus { get; set; }
    public string? PreauthorizationCode { get; set; }
    public string? PenaltyYn { get; set; }

    public virtual SunUploadHeader Header { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SunUploadDetail>(entity =>
        {
            entity.HasKey(e => new { e.HeaderId, e.TrxId })
                .HasName("SUN_UPLOAD_DETAIL_PK");

            entity.ToTable("SUN_UPLOAD_DETAIL");

            entity.HasIndex(e => e.MerchantReference)
                .HasName("SUN_UPLOAD_DETAIL_IDX1");

            entity.Property(e => e.HeaderId)
                .HasColumnName("HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxId)
                .HasColumnName("TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.AuthorisationCode)
                .HasColumnName("AUTHORISATION_CODE")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.BudgetPeriod)
                .HasColumnName("BUDGET_PERIOD")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CcExpiryDate)
                .HasColumnName("CC_EXPIRY_DATE")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.CcStartDate)
                .HasColumnName("CC_START_DATE")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.Ccnumber)
                .HasColumnName("CCNUMBER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CycleNumber)
                .HasColumnName("CYCLE_NUMBER")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.MerchantReference)
                .HasColumnName("MERCHANT_REFERENCE")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.MerchantTerminal)
                .HasColumnName("MERCHANT_TERMINAL")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.OrgMerchantReference)
                .HasColumnName("ORG_MERCHANT_REFERENCE")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.PenaltyYn)
                .HasColumnName("PENALTY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.PreauthorizationCode)
                .HasColumnName("PREAUTHORIZATION_CODE")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.PurchaseDate)
                .HasColumnName("PURCHASE_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.PurchaseTime)
                .HasColumnName("PURCHASE_TIME")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.ReconciliationStatus)
                .HasColumnName("RECONCILIATION_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ResultStatus)
                .HasColumnName("RESULT_STATUS")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.TraceNumber)
                .HasColumnName("TRACE_NUMBER")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.TransactionCode)
                .HasColumnName("TRANSACTION_CODE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.TransationStatus)
                .HasColumnName("TRANSATION_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

			if (!types.Contains(typeof(SunUploadHeader)))
				entity.Ignore(e => e.Header);
			else
	            entity.HasOne(d => d.Header)
	                .WithMany(p => p.SunUploadDetail)
	                .HasForeignKey(d => d.HeaderId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("SUN_UPLOAD_DETAIL_FK");
        });
	}
}
