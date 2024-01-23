namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IntBeQueueTableVw
{
    public string Queue { get; set; }
    public Guid MsgId { get; set; }
    public string CorrId { get; set; }
    public decimal? MsgPriority { get; set; }
    public string MsgState { get; set; }
    public DateTime? Delay { get; set; }
    public DateTime? DelayTimestamp { get; set; }
    public decimal? Expiration { get; set; }
    public DateTime? EnqTime { get; set; }
    public DateTime? EnqTimestamp { get; set; }
    public string EnqUserId { get; set; }
    public string EnqTxnId { get; set; }
    public DateTime? DeqTime { get; set; }
    public DateTime? DeqTimestamp { get; set; }
    public string DeqUserId { get; set; }
    public string DeqTxnId { get; set; }
    public decimal? RetryCount { get; set; }
    public string ExceptionQueueOwner { get; set; }
    public string ExceptionQueue { get; set; }
    public Guid? PropagatedMsgid { get; set; }
    public string SenderName { get; set; }
    public string SenderAddress { get; set; }
    public decimal? SenderProtocol { get; set; }
    public Guid? OriginalMsgid { get; set; }
    public string OriginalQueueName { get; set; }
    public string OriginalQueueOwner { get; set; }
    public string ExpirationReason { get; set; }
    public string ConsumerName { get; set; }
    public string Address { get; set; }
    public decimal? Protocol { get; set; }
    public string InterfaceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntBeQueueTableVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INT_BE_QUEUE_TABLE_VW");

            entity.Property(e => e.Address)
                .HasColumnName("ADDRESS")
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.ConsumerName)
                .HasColumnName("CONSUMER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CorrId)
                .HasColumnName("CORR_ID")
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.Property(e => e.Delay)
                .HasColumnName("DELAY")
                .HasColumnType("DATE");

            entity.Property(e => e.DelayTimestamp)
                .HasColumnName("DELAY_TIMESTAMP")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.DeqTime)
                .HasColumnName("DEQ_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.DeqTimestamp)
                .HasColumnName("DEQ_TIMESTAMP")
                .HasColumnType("TIMESTAMP(9)");

            entity.Property(e => e.DeqTxnId)
                .HasColumnName("DEQ_TXN_ID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DeqUserId)
                .HasColumnName("DEQ_USER_ID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.EnqTime)
                .HasColumnName("ENQ_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.EnqTimestamp)
                .HasColumnName("ENQ_TIMESTAMP")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.EnqTxnId)
                .HasColumnName("ENQ_TXN_ID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.EnqUserId)
                .HasColumnName("ENQ_USER_ID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ExceptionQueue)
                .HasColumnName("EXCEPTION_QUEUE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ExceptionQueueOwner)
                .HasColumnName("EXCEPTION_QUEUE_OWNER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Expiration)
                .HasColumnName("EXPIRATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpirationReason)
                .HasColumnName("EXPIRATION_REASON")
                .HasMaxLength(31)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MsgId).HasColumnName("MSG_ID");

            entity.Property(e => e.MsgPriority)
                .HasColumnName("MSG_PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MsgState)
                .HasColumnName("MSG_STATE")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.OriginalMsgid).HasColumnName("ORIGINAL_MSGID");

            entity.Property(e => e.OriginalQueueName)
                .HasColumnName("ORIGINAL_QUEUE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.OriginalQueueOwner)
                .HasColumnName("ORIGINAL_QUEUE_OWNER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PropagatedMsgid).HasColumnName("PROPAGATED_MSGID");

            entity.Property(e => e.Protocol)
                .HasColumnName("PROTOCOL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Queue)
                .HasColumnName("QUEUE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.RetryCount)
                .HasColumnName("RETRY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SenderAddress)
                .HasColumnName("SENDER_ADDRESS")
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.SenderName)
                .HasColumnName("SENDER_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.SenderProtocol)
                .HasColumnName("SENDER_PROTOCOL")
                .HasColumnType("NUMBER");
        });
	}
}
