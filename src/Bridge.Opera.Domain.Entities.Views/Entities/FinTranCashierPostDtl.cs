namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FinTranCashierPostDtl
{
    public string Resort { get; set; }
    public decimal? CashierId { get; set; }
    public string TrxCode { get; set; }
    public string FtSubtype { get; set; }
    public string Currency { get; set; }
    public decimal? NoRecord { get; set; }
    public decimal? Amount { get; set; }
    public decimal? ClosureNo { get; set; }
    public string TrxCodeDescription { get; set; }
    public string IndCash { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinTranCashierPostDtl>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIN_TRAN_CASHIER_POST_DTL");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClosureNo)
                .HasColumnName("CLOSURE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .IsRequired()
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FtSubtype)
                .IsRequired()
                .HasColumnName("FT_SUBTYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.IndCash)
                .HasColumnName("IND_CASH")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NoRecord)
                .HasColumnName("NO_RECORD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeDescription)
                .HasColumnName("TRX_CODE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
