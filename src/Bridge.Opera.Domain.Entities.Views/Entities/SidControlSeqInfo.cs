namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidControlSeqInfo
{
    public decimal? IncrementValue { get; set; }
    public decimal? SeqValue { get; set; }
    public string? KeyValue { get; set; }
    public string? RoomClass { get; set; }
    public string? Resort { get; set; }
    public decimal? MinValue { get; set; }
    public decimal? MaxValue { get; set; }
    public DateTime? SeqDate { get; set; }
    public string? ResetAtNewDateYn { get; set; }
    public string? PaymentType { get; set; }
    public string? FolioType { get; set; }
    public string? PrefixSeqNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidControlSeqInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_CONTROL_SEQ_INFO");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IncrementValue)
                .HasColumnName("INCREMENT_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyValue)
                .IsRequired()
                .HasColumnName("KEY_VALUE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MaxValue)
                .HasColumnName("MAX_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinValue)
                .HasColumnName("MIN_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.PrefixSeqNo)
                .HasColumnName("PREFIX_SEQ_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResetAtNewDateYn)
                .HasColumnName("RESET_AT_NEW_DATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeqDate)
                .HasColumnName("SEQ_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SeqValue)
                .HasColumnName("SEQ_VALUE")
                .HasColumnType("NUMBER");
        });
	}
}
