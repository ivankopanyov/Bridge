namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BookingLocalAttachments
{
    public decimal? AttachId { get; set; }
    public string AttachmentType { get; set; }
    public string Description { get; set; }
    public string Filename { get; set; }
    public string Resort { get; set; }
    public decimal? BookId { get; set; }
    public string AttachmentLocation { get; set; }
    public string GlobalYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookingLocalAttachments>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOOKING_LOCAL_ATTACHMENTS");

            entity.Property(e => e.AttachId)
                .HasColumnName("ATTACH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttachmentLocation)
                .HasColumnName("ATTACHMENT_LOCATION")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.AttachmentType)
                .HasColumnName("ATTACHMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.Filename)
                .HasColumnName("FILENAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GlobalYn)
                .HasColumnName("GLOBAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
