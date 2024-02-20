namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosCheckRegister
{
    public decimal? AccountId { get; set; }
    public string? Resort { get; set; }
    public decimal? BatchId { get; set; }
    public decimal? CheckAmt { get; set; }
    public DateTime? CheckDate { get; set; }
    public decimal? CheckNo { get; set; }
    public string? ChkCurrency { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string? Status { get; set; }
    public string? ClearedYn { get; set; }
    public decimal? PaymentId { get; set; }
    public decimal? AccountCode { get; set; }
    public DateTime? ActionDate { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? RefPaymentId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? PaymentMethod { get; set; }
    public string? EftFileName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosCheckRegister>(entity =>
        {
            entity.HasKey(e => e.PaymentId)
                .HasName("OCREG_PK");

            entity.ToTable("OVOS_CHECK_REGISTER");

            entity.HasIndex(e => new { e.BatchId, e.PaymentId })
                .HasName("OCREG_BATCH_IDX");

            entity.HasIndex(e => new { e.Resort, e.AccountId, e.Status, e.ClearedYn })
                .HasName("OCREG_IDX");

            entity.Property(e => e.PaymentId)
                .HasColumnName("PAYMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDate)
                .HasColumnName("ACTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckAmt)
                .HasColumnName("CHECK_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckDate)
                .HasColumnName("CHECK_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CheckNo)
                .HasColumnName("CHECK_NO")
                .HasColumnType("NUMBER(20)");

            entity.Property(e => e.ChkCurrency)
                .HasColumnName("CHK_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClearedYn)
                .HasColumnName("CLEARED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EftFileName)
                .HasColumnName("EFT_FILE_NAME")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.RefPaymentId)
                .HasColumnName("REF_PAYMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

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
