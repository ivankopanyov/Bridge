namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ArCreditCardSettleJrnl
{
    public string Resort { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? InvoiceNo { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string UpdateType { get; set; }
    public string UpdateReason { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArCreditCardSettleJrnl>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AR_CREDIT_CARD_SETTLE_JRNL");

            entity.HasIndex(e => e.TrxNo)
                .HasName("AR_CREDIT_CARD_SETTLE_JRNL_IND");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateReason)
                .HasColumnName("UPDATE_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateType)
                .HasColumnName("UPDATE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
