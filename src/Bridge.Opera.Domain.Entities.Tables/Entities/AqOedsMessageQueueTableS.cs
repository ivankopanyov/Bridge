namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AqOedsMessageQueueTableS
{
    public decimal SubscriberId { get; set; }
    public string QueueName { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public decimal? Protocol { get; set; }
    public decimal? SubscriberType { get; set; }
    public string RuleName { get; set; }
    public string TransName { get; set; }
    public string RulesetName { get; set; }
    public string NegativeRulesetName { get; set; }
    public DateTimeOffset? CreationTime { get; set; }
    public DateTimeOffset? ModificationTime { get; set; }
    public DateTimeOffset? DeletionTime { get; set; }
    public decimal? ScnAtRemove { get; set; }
    public decimal? ScnAtAdd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AqOedsMessageQueueTableS>(entity =>
        {
            entity.HasKey(e => e.SubscriberId)
                .HasName("SYS_C0037412");

            entity.ToTable("AQ$_OEDS_MESSAGE_QUEUE_TABLE_S");

            entity.Property(e => e.SubscriberId)
                .HasColumnName("SUBSCRIBER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Address)
                .HasColumnName("ADDRESS")
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.CreationTime)
                .HasColumnName("CREATION_TIME")
                .HasColumnType("TIMESTAMP(6) WITH TIME ZONE");

            entity.Property(e => e.DeletionTime)
                .HasColumnName("DELETION_TIME")
                .HasColumnType("TIMESTAMP(6) WITH TIME ZONE");

            entity.Property(e => e.ModificationTime)
                .HasColumnName("MODIFICATION_TIME")
                .HasColumnType("TIMESTAMP(6) WITH TIME ZONE");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.NegativeRulesetName)
                .HasColumnName("NEGATIVE_RULESET_NAME")
                .HasMaxLength(65)
                .IsUnicode(false);

            entity.Property(e => e.Protocol)
                .HasColumnName("PROTOCOL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueueName)
                .IsRequired()
                .HasColumnName("QUEUE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.RuleName)
                .HasColumnName("RULE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.RulesetName)
                .HasColumnName("RULESET_NAME")
                .HasMaxLength(65)
                .IsUnicode(false);

            entity.Property(e => e.ScnAtAdd)
                .HasColumnName("SCN_AT_ADD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScnAtRemove)
                .HasColumnName("SCN_AT_REMOVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SubscriberType)
                .HasColumnName("SUBSCRIBER_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransName)
                .HasColumnName("TRANS_NAME")
                .HasMaxLength(65)
                .IsUnicode(false);
        });
	}
}
