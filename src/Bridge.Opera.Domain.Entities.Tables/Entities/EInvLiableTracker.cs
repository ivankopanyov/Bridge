namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EInvLiableTracker
{
    public string Resort { get; set; }
    public decimal TrxNo { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal FolioView { get; set; }
    public decimal NameId { get; set; }
    public decimal PayeeNameId { get; set; }
    public string Tax1No { get; set; }
    public string Tax2No { get; set; }
    public string EInvoiceLiableYn { get; set; }
    public DateTime TrxDate { get; set; }
    public decimal? TotalAttempts { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EInvLiableTracker>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("E_INV_LIABLE_TRACKER");

            entity.HasIndex(e => e.PayeeNameId)
                .HasName("E_INV_LIABLE_PAYEE_IDX");

            entity.HasIndex(e => e.Tax1No)
                .HasName("E_INV_LIABLE_TAX1_IDX");

            entity.Property(e => e.EInvoiceLiableYn)
                .HasColumnName("E_INVOICE_LIABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayeeNameId)
                .HasColumnName("PAYEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax1No)
                .IsRequired()
                .HasColumnName("TAX1_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Tax2No)
                .HasColumnName("TAX2_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TotalAttempts)
                .HasColumnName("TOTAL_ATTEMPTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
