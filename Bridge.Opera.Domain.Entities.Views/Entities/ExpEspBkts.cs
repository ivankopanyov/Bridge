namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEspBkts
{
    public decimal? ExportId { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? FolioView { get; set; }
    public decimal? Amount { get; set; }
    public string BktIndicator { get; set; }
    public string BktCode { get; set; }
    public decimal? BillNo { get; set; }
    public string MemCurrCode { get; set; }
    public string MemExchType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEspBkts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_ESP_BKTS");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BktCode)
                .HasColumnName("BKT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BktIndicator)
                .HasColumnName("BKT_INDICATOR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemCurrCode)
                .HasColumnName("MEM_CURR_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MemExchType)
                .HasColumnName("MEM_EXCH_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
