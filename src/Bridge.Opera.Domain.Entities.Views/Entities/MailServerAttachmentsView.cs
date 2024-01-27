namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MailServerAttachmentsView
{
    public string Id { get; set; }
    public string AttachmentName { get; set; }
    public string AttachmentId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailServerAttachmentsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MAIL_SERVER_ATTACHMENTS_VIEW");

            entity.Property(e => e.AttachmentId)
                .HasColumnName("ATTACHMENT_ID")
                .IsUnicode(false);

            entity.Property(e => e.AttachmentName)
                .HasColumnName("ATTACHMENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .IsUnicode(false);
        });
	}
}
