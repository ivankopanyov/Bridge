namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArTranPostSumm
{
    public string? Resort { get; set; }
    public decimal? NameId { get; set; }
    public decimal? ArNumber { get; set; }
    public string? Terminal { get; set; }
    public string? Machine { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? FolioNo { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? FinActionId { get; set; }
    public string? FinActionDesc { get; set; }
    public string? FinActionEvent { get; set; }
    public string? ReasonCode { get; set; }
    public DateTime? InsDateTz { get; set; }
    public DateTime? InsTimeTz { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArTranPostSumm>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_TRAN_POST_SUMM");

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinActionDesc)
                .HasColumnName("FIN_ACTION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FinActionEvent)
                .HasColumnName("FIN_ACTION_EVENT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FinActionId)
                .HasColumnName("FIN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsDateTz)
                .HasColumnName("INS_DATE_TZ")
                .HasColumnType("DATE");

            entity.Property(e => e.InsTimeTz)
                .HasColumnName("INS_TIME_TZ")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
