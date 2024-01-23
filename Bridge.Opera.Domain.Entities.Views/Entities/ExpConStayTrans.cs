namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConStayTrans
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? TrxAmt { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? WindowNumber { get; set; }
    public decimal? BillNumber { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? CreditCardId { get; set; }
    public decimal? NetAmount { get; set; }
    public string RevType { get; set; }
    public string TrxReference { get; set; }
    public string TrxCode { get; set; }
    public string TrxDescription { get; set; }
    public string Printed { get; set; }
    public string RevenueYn { get; set; }
    public DateTime? TrxDate { get; set; }
    public DateTime? StayDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConStayTrans>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_STAY_TRANS");

            entity.Property(e => e.BillNumber)
                .HasColumnName("BILL_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Printed)
                .HasColumnName("PRINTED")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevType)
                .HasColumnName("REV_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RevenueYn)
                .HasColumnName("REVENUE_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxAmt)
                .HasColumnName("TRX_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxDescription)
                .HasColumnName("TRX_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxReference)
                .HasColumnName("TRX_REFERENCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WindowNumber)
                .HasColumnName("WINDOW_NUMBER")
                .HasColumnType("NUMBER");
        });
	}
}
