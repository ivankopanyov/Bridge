namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AqOedsMessageQueueTableF
{
    public string? QName { get; set; }
    public string? RowId { get; set; }
    public Guid Msgid { get; set; }
    public string? Corrid { get; set; }
    public decimal? Priority { get; set; }
    public decimal? State { get; set; }
    public DateTime? Delay { get; set; }
    public decimal? Expiration { get; set; }
    public DateTime? EnqTime { get; set; }
    public string? EnqUid { get; set; }
    public string? EnqTid { get; set; }
    public DateTime? DeqTime { get; set; }
    public string? DeqUid { get; set; }
    public string? DeqTid { get; set; }
    public decimal? RetryCount { get; set; }
    public string? ExceptionQschema { get; set; }
    public string? ExceptionQueue { get; set; }
    public decimal? Cscn { get; set; }
    public decimal? Dscn { get; set; }
    public decimal? ChainNo { get; set; }
    public decimal? LocalOrderNo { get; set; }
    public DateTime? TimeManagerInfo { get; set; }
    public decimal? StepNo { get; set; }
    public string? SenderName { get; set; }
    public string? SenderAddress { get; set; }
    public decimal? SenderProtocol { get; set; }
    public Guid? DequeueMsgid { get; set; }
    public string? DeliveryMode { get; set; }
    public decimal? SequenceNum { get; set; }
    public decimal? MsgNum { get; set; }
    public decimal? QueueId { get; set; }
    public decimal? SubscriberId { get; set; }
    public string? SubscriberName { get; set; }
    public decimal? QueueEvtid { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AqOedsMessageQueueTableF>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AQ$_OEDS_MESSAGE_QUEUE_TABLE_F");

            entity.Property(e => e.ChainNo)
                .HasColumnName("CHAIN_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Corrid)
                .HasColumnName("CORRID")
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.Property(e => e.Cscn)
                .HasColumnName("CSCN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Delay)
                .HasColumnName("DELAY")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.DeliveryMode)
                .HasColumnName("DELIVERY_MODE")
                .HasColumnType("CHAR(10)");

            entity.Property(e => e.DeqTid)
                .HasColumnName("DEQ_TID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DeqTime)
                .HasColumnName("DEQ_TIME")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.DeqUid)
                .HasColumnName("DEQ_UID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DequeueMsgid).HasColumnName("DEQUEUE_MSGID");

            entity.Property(e => e.Dscn)
                .HasColumnName("DSCN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EnqTid)
                .HasColumnName("ENQ_TID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.EnqTime)
                .HasColumnName("ENQ_TIME")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.EnqUid)
                .HasColumnName("ENQ_UID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ExceptionQschema)
                .HasColumnName("EXCEPTION_QSCHEMA")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ExceptionQueue)
                .HasColumnName("EXCEPTION_QUEUE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Expiration)
                .HasColumnName("EXPIRATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocalOrderNo)
                .HasColumnName("LOCAL_ORDER_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MsgNum)
                .HasColumnName("MSG_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Msgid).HasColumnName("MSGID");

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QName)
                .HasColumnName("Q_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.QueueEvtid)
                .HasColumnName("QUEUE_EVTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueueId)
                .HasColumnName("QUEUE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RetryCount)
                .HasColumnName("RETRY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowId)
                .HasColumnName("ROW_ID")
                .HasColumnType("ROWID");

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

            entity.Property(e => e.SequenceNum)
                .HasColumnName("SEQUENCE_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StepNo)
                .HasColumnName("STEP_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SubscriberId)
                .HasColumnName("SUBSCRIBER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SubscriberName)
                .IsRequired()
                .HasColumnName("SUBSCRIBER_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TimeManagerInfo)
                .HasColumnName("TIME_MANAGER_INFO")
                .HasColumnType("TIMESTAMP(6)");
        });
	}
}
