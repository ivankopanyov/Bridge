namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpTransactionsDay
{
    public DateTime? TrxDate { get; set; }
    public string Description { get; set; }
    public string TrxCode { get; set; }
    public decimal? TrxAmount { get; set; }
    public decimal? Sequence { get; set; }
    public decimal? Covers { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpTransactionsDay>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_TRANSACTIONS_DAY");

            entity.Property(e => e.Covers)
                .HasColumnName("COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
