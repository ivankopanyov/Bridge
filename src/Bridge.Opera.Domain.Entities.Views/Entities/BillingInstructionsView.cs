namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BillingInstructionsView
{
    public string? Resort { get; set; }
    public string? ArrangementId { get; set; }
    public string? ArrangementCode { get; set; }
    public string? TrxCode { get; set; }
    public string? Description { get; set; }
    public string? Blltype { get; set; }
    public string? TrxCodeType { get; set; }
    public string? CompYn { get; set; }
    public string? TcTransactionType { get; set; }
    public string? IsManualPostAllowed { get; set; }
    public string? SearchCode { get; set; }
    public string? ExportBucket { get; set; }
    public string? GroupFolio { get; set; }
    public string? AdjTrxCode { get; set; }
    public string? AdjIsManualPostAllowed { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? RoutingAmount { get; set; }
    public decimal? RoutingPercent { get; set; }
    public decimal? RoutingCovers { get; set; }
    public string? Day1 { get; set; }
    public string? Day2 { get; set; }
    public string? Day3 { get; set; }
    public string? Day4 { get; set; }
    public string? Day5 { get; set; }
    public string? Day6 { get; set; }
    public string? Day7 { get; set; }
    public string? DailyYn { get; set; }
    public string? DepositPostingOnlyYn { get; set; }
    public string? InhDepositYn { get; set; }
    public string? InhPayYn { get; set; }
    public string? InhSalesYn { get; set; }
    public string? IndRevenueGp { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BillingInstructionsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BILLING_INSTRUCTIONS_VIEW");

            entity.Property(e => e.AdjIsManualPostAllowed)
                .HasColumnName("ADJ_IS_MANUAL_POST_ALLOWED")
                .IsUnicode(false);

            entity.Property(e => e.AdjTrxCode)
                .HasColumnName("ADJ_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementCode)
                .HasColumnName("ARRANGEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementId)
                .HasColumnName("ARRANGEMENT_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Blltype)
                .HasColumnName("BLLTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompYn)
                .HasColumnName("COMP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DailyYn)
                .HasColumnName("DAILY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day6)
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day7)
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepositPostingOnlyYn)
                .HasColumnName("DEPOSIT_POSTING_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucket)
                .HasColumnName("EXPORT_BUCKET")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GroupFolio)
                .HasColumnName("GROUP_FOLIO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IndRevenueGp)
                .HasColumnName("IND_REVENUE_GP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InhDepositYn)
                .HasColumnName("INH_DEPOSIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InhPayYn)
                .HasColumnName("INH_PAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InhSalesYn)
                .HasColumnName("INH_SALES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IsManualPostAllowed)
                .HasColumnName("IS_MANUAL_POST_ALLOWED")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoutingAmount)
                .HasColumnName("ROUTING_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoutingCovers)
                .HasColumnName("ROUTING_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoutingPercent)
                .HasColumnName("ROUTING_PERCENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SearchCode)
                .HasColumnName("SEARCH_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcTransactionType)
                .HasColumnName("TC_TRANSACTION_TYPE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeType)
                .HasColumnName("TRX_CODE_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);
        });
	}
}
