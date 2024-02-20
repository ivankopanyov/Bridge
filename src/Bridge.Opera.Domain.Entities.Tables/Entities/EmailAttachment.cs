namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EmailAttachment
{
    public decimal? EmailId { get; set; }
    public string? FileName { get; set; }
    public byte[] Attachment { get; set; }
    public decimal? AttachId { get; set; }
    public string? Description { get; set; }
    public byte[] BfileLocator { get; set; }
    public string? AttachmentLocation { get; set; }

    public virtual EmailJournal Email { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EmailAttachment>(entity =>
        {
            entity.HasKey(e => e.AttachId)
                .HasName("EMA_PK");

            entity.ToTable("EMAIL_ATTACHMENT");

            entity.HasIndex(e => new { e.EmailId, e.FileName })
                .HasName("EMA_ID_IDX")
                .IsUnique();

            entity.Property(e => e.AttachId)
                .HasColumnName("ATTACH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attachment)
                .HasColumnName("ATTACHMENT")
                .HasColumnType("BLOB");

            entity.Property(e => e.AttachmentLocation)
                .HasColumnName("ATTACHMENT_LOCATION")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.BfileLocator)
                .HasColumnName("BFILE_LOCATOR")
                .HasColumnType("BFILE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EmailId)
                .HasColumnName("EMAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FileName)
                .HasColumnName("FILE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

			if (!types.Contains(typeof(EmailJournal)))
				entity.Ignore(e => e.Email);
			else
	            entity.HasOne(d => d.Email)
	                .WithMany(p => p.EmailAttachment)
	                .HasForeignKey(d => d.EmailId)
	                .HasConstraintName("EMA_EMJ_FK");
        });
	}
}
