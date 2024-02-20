namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OvosCheckRegisterEftBatch
{
    public decimal? AccountId { get; set; }
    public string? Resort { get; set; }
    public decimal? BatchId { get; set; }
    public decimal? BatchAmt { get; set; }
    public DateTime? BatchDate { get; set; }
    public string? BatchCurrency { get; set; }
    public string? Status { get; set; }
    public DateTime? ActionDate { get; set; }
    public string? EftFileName { get; set; }
    public string? ClearedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosCheckRegisterEftBatch>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OVOS_CHECK_REGISTER_EFT_BATCH");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDate)
                .HasColumnName("ACTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BatchAmt)
                .HasColumnName("BATCH_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BatchCurrency)
                .HasColumnName("BATCH_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BatchDate)
                .HasColumnName("BATCH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClearedYn)
                .HasColumnName("CLEARED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EftFileName)
                .HasColumnName("EFT_FILE_NAME")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
