namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EmailAttachmentBlobs
{
    public decimal EmailId { get; set; }
    public decimal AttachId { get; set; }
    public byte[] Attachment { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EmailAttachmentBlobs>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EMAIL_ATTACHMENT_BLOBS");

            entity.Property(e => e.AttachId)
                .HasColumnName("ATTACH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attachment)
                .HasColumnName("ATTACHMENT")
                .HasColumnType("BLOB");

            entity.Property(e => e.EmailId)
                .HasColumnName("EMAIL_ID")
                .HasColumnType("NUMBER");
        });
	}
}
