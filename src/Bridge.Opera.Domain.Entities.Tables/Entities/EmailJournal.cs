namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EmailJournal
{
    public EmailJournal()
    {
        EmailAttachment = new HashSet<EmailAttachment>();
    }

    public decimal EmailSeqno { get; set; }
    public string Origin { get; set; }
    public decimal OriginId { get; set; }
    public string SenderEmail { get; set; }
    public decimal? SenderId { get; set; }
    public string ToRecipients { get; set; }
    public string CcRecipients { get; set; }
    public string BccRecipients { get; set; }
    public string EmailSubject { get; set; }
    public string EmailBody { get; set; }
    public DateTime? SendDate { get; set; }
    public string Attachments { get; set; }
    public decimal? ResendForId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string PlainTextYn { get; set; }

    public virtual ICollection<EmailAttachment> EmailAttachment { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EmailJournal>(entity =>
        {
            entity.HasKey(e => e.EmailSeqno)
                .HasName("EMJ_PK");

            entity.ToTable("EMAIL_JOURNAL");

            entity.HasIndex(e => new { e.Origin, e.OriginId, e.EmailSeqno })
                .HasName("EMJ_ORIGIN_IDX");

            entity.Property(e => e.EmailSeqno)
                .HasColumnName("EMAIL_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attachments)
                .HasColumnName("ATTACHMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BccRecipients)
                .HasColumnName("BCC_RECIPIENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CcRecipients)
                .HasColumnName("CC_RECIPIENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EmailBody)
                .HasColumnName("EMAIL_BODY")
                .HasColumnType("CLOB");

            entity.Property(e => e.EmailSubject)
                .HasColumnName("EMAIL_SUBJECT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Origin)
                .IsRequired()
                .HasColumnName("ORIGIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OriginId)
                .HasColumnName("ORIGIN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PlainTextYn)
                .HasColumnName("PLAIN_TEXT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResendForId)
                .HasColumnName("RESEND_FOR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SendDate)
                .HasColumnName("SEND_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SenderEmail)
                .HasColumnName("SENDER_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SenderId)
                .HasColumnName("SENDER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToRecipients)
                .HasColumnName("TO_RECIPIENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(EmailAttachment)))
				entity.Ignore(e => e.EmailAttachment);
		});
	}
}
