namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LinkedAttachmentBlobs
{
    public decimal? AttachId { get; set; }
    public byte[] AttachmentBlob { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LinkedAttachmentBlobs>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LINKED_ATTACHMENT_BLOBS");

            entity.Property(e => e.AttachId)
                .HasColumnName("ATTACH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttachmentBlob)
                .HasColumnName("ATTACHMENT_BLOB")
                .HasColumnType("BLOB");
        });
	}
}
