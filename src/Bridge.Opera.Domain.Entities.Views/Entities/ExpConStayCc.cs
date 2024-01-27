namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConStayCc
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? CreditCardId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? BillNumber { get; set; }
    public decimal? WindowNumber { get; set; }
    public string IfcCcType { get; set; }
    public string PaymentType { get; set; }
    public string CcNumber { get; set; }
    public string CcExpyDt { get; set; }
    public DateTime? StayDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConStayCc>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_STAY_CC");

            entity.Property(e => e.BillNumber)
                .HasColumnName("BILL_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcExpyDt)
                .HasColumnName("CC_EXPY_DT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CcNumber)
                .HasColumnName("CC_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IfcCcType)
                .HasColumnName("IFC_CC_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WindowNumber)
                .HasColumnName("WINDOW_NUMBER")
                .HasColumnType("NUMBER");
        });
	}
}
