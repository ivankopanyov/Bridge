namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeAllotmentHdr
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public string ExpGroupId { get; set; }
    public string Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string AllotmentCode { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GroupId { get; set; }
    public string GroupName { get; set; }
    public string MarketCode { get; set; }
    public string SourceCode { get; set; }
    public string Channel { get; set; }
    public string Status { get; set; }
    public string ReserveInventoryYn { get; set; }
    public string RateCode { get; set; }
    public string RateCodeDescription { get; set; }
    public DateTime? InvCutoffDate { get; set; }
    public decimal? InvCutoffDays { get; set; }
    public string GroupType { get; set; }
    public decimal? DepositPaidAmount { get; set; }
    public DateTime? DepositPaidDate { get; set; }
    public decimal? DepositDueAmount { get; set; }
    public DateTime? DepositDueDate { get; set; }
    public decimal? Rooms { get; set; }
    public decimal? Persons { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeAllotmentHdr>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_ALLOTMENT_HDR");

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepositDueAmount)
                .HasColumnName("DEPOSIT_DUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositDueDate)
                .HasColumnName("DEPOSIT_DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepositPaidAmount)
                .HasColumnName("DEPOSIT_PAID_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositPaidDate)
                .HasColumnName("DEPOSIT_PAID_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExpGroupId)
                .HasColumnName("EXP_GROUP_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GroupType)
                .HasColumnName("GROUP_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InvCutoffDate)
                .HasColumnName("INV_CUTOFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvCutoffDays)
                .HasColumnName("INV_CUTOFF_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeDescription)
                .HasColumnName("RATE_CODE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ReserveInventoryYn)
                .HasColumnName("RESERVE_INVENTORY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
