namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AqCachedMemcalQTabT
{
    public DateTime? NextDate { get; set; }
    public string? TxnId { get; set; }
    public Guid Msgid { get; set; }
    public decimal? Action { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AqCachedMemcalQTabT>(entity =>
        {
            entity.HasKey(e => new { e.NextDate, e.TxnId, e.Msgid })
                .HasName("SYS_IOT_TOP_142095");

            entity.ToTable("AQ$_CACHED$_MEMCAL_Q_TAB_T");

            entity.Property(e => e.NextDate)
                .HasColumnName("NEXT_DATE")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.TxnId)
                .HasColumnName("TXN_ID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Msgid).HasColumnName("MSGID");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasColumnType("NUMBER");
        });
	}
}
