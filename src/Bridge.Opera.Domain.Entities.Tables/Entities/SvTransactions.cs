namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SvTransactions
{
    public decimal? IfcCtrlId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? AccountNumber { get; set; }
    public string? TransNumber { get; set; }
    public string? TransactionType { get; set; }
    public DateTime? TransactionDate { get; set; }
    public string? ActiveYn { get; set; }
    public decimal? FinTrxNo { get; set; }
    public decimal? Amount { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SvTransactions>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SV_TRANSACTIONS");

            entity.HasIndex(e => e.InsertDate)
                .HasName("SV_TRANSACTIONS_IDX2");

            entity.HasIndex(e => new { e.IfcCtrlId, e.AccountNumber })
                .HasName("SV_TRANSACTIONS_IDX");

            entity.Property(e => e.AccountNumber)
                .HasColumnName("ACCOUNT_NUMBER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinTrxNo)
                .HasColumnName("FIN_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransNumber)
                .HasColumnName("TRANS_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TransactionDate)
                .HasColumnName("TRANSACTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TransactionType)
                .HasColumnName("TRANSACTION_TYPE")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
