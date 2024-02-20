namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21FolioWin
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? FolioView { get; set; }
    public string? PaymentMethod { get; set; }
    public string? CcCode { get; set; }
    public string? ArNo { get; set; }
    public string? VoucherNumber { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21FolioWin>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_FOLIO_WIN");

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CcCode)
                .HasColumnName("CC_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VoucherNumber)
                .HasColumnName("VOUCHER_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
