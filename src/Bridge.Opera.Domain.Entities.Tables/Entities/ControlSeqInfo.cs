namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ControlSeqInfo
{
    public decimal? IncrementValue { get; set; }
    public decimal? SeqValue { get; set; }
    public string? KeyValue { get; set; }
    public string? RoomClass { get; set; }
    public string? Resort { get; set; }
    public string? FolioType { get; set; }
    public string? PaymentType { get; set; }
    public string? PrefixSeqNo { get; set; }
    public decimal? MinValue { get; set; }
    public decimal? MaxValue { get; set; }
    public DateTime? SeqDate { get; set; }
    public string? ResetAtNewDateYn { get; set; }
    public string? InactiveYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ControlSeqInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CONTROL_SEQ_INFO");

            entity.HasIndex(e => new { e.Resort, e.KeyValue, e.RoomClass })
                .HasName("CONTROL_SEQ_INFO_IND");

            entity.HasIndex(e => new { e.Resort, e.KeyValue, e.FolioType, e.PaymentType })
                .HasName("CONTROL_SEQ_INFO_UK")
                .IsUnique();

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IncrementValue)
                .HasColumnName("INCREMENT_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
