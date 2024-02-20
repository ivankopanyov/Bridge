namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CheckLedgersLog
{
    public string? Resort { get; set; }
    public string? TableUpdated { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? OriginalResvNameId { get; set; }
    public decimal? AccountCode { get; set; }
    public decimal? OriginalAccountCode { get; set; }
    public string? ChangeType { get; set; }
    public string? ChangeDescription { get; set; }
    public string? ProcedureName { get; set; }
    public decimal? ChangeUser { get; set; }
    public DateTime? ChangeDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CheckLedgersLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CHECK_LEDGERS_LOG");

            entity.HasIndex(e => new { e.Resort, e.ChangeDate })
                .HasName("CHECK_LEDGERS_LOG_IDX2");

            entity.HasIndex(e => new { e.Resort, e.TrxDate })
                .HasName("CHECK_LEDGERS_LOG_IDX1");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeDate)
                .HasColumnName("CHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChangeDescription)
                .HasColumnName("CHANGE_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.ChangeType)
                .HasColumnName("CHANGE_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ChangeUser)
                .HasColumnName("CHANGE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalAccountCode)
                .HasColumnName("ORIGINAL_ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalResvNameId)
                .HasColumnName("ORIGINAL_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcedureName)
                .HasColumnName("PROCEDURE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableUpdated)
                .HasColumnName("TABLE_UPDATED")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
