namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MessageBin
{
    public string? Resort { get; set; }
    public string? Recipient { get; set; }
    public DateTime? ExpireTime { get; set; }
    public string? Frequency { get; set; }
    public string? Message { get; set; }
    public string? Module { get; set; }
    public decimal? MessageId { get; set; }
    public decimal? Priority { get; set; }
    public string? ProcedureName { get; set; }
    public decimal? Sid { get; set; }
    public string? ExcludedSessions { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MessageBin>(entity =>
        {
            entity.HasKey(e => e.MessageId)
                .HasName("MESSAGE_BIN_PK");

            entity.ToTable("MESSAGE_BIN");

            entity.HasIndex(e => e.ExpireTime)
                .HasName("MESSAGE_BIN_IND1");

            entity.HasIndex(e => new { e.Recipient, e.Resort, e.ExpireTime })
                .HasName("MSG_IND");

            entity.Property(e => e.MessageId)
                .HasColumnName("MESSAGE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExcludedSessions)
                .HasColumnName("EXCLUDED_SESSIONS")
                .IsUnicode(false);

            entity.Property(e => e.ExpireTime)
                .HasColumnName("EXPIRE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Message)
                .HasColumnName("MESSAGE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcedureName)
                .HasColumnName("PROCEDURE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Recipient)
                .IsRequired()
                .HasColumnName("RECIPIENT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");
        });
	}
}
