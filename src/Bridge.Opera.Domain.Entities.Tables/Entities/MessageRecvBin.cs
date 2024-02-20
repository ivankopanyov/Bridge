namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MessageRecvBin
{
    public decimal? MessageId { get; set; }
    public string? Recipient { get; set; }
    public decimal? Sid { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MessageRecvBin>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MESSAGE_RECV_BIN");

            entity.HasIndex(e => new { e.MessageId, e.Recipient, e.Sid })
                .HasName("MSG_RECV_IND");

            entity.Property(e => e.MessageId)
                .HasColumnName("MESSAGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Recipient)
                .HasColumnName("RECIPIENT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");
        });
	}
}
