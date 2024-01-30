namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LinkedAttachments
{
    public decimal? AttachId { get; set; }
    public string? AttachmentType { get; set; }
    public string? Description { get; set; }
    public string? Filename { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? Resort { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? LinkedTo { get; set; }
    public decimal? LinkId { get; set; }
    public decimal? AttachmentSize { get; set; }
    public byte[] BfileLocator { get; set; }
    public string? AttachmentOrigin { get; set; }
    public string? DefaultYn { get; set; }
    public string? AttachmentLocation { get; set; }
    public string? DatabaseId { get; set; }
    public string? GlobalYn { get; set; }
    public decimal? OriginLinkId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LinkedAttachments>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LINKED_ATTACHMENTS");

            entity.Property(e => e.AttachId)
                .HasColumnName("ATTACH_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AttachmentLocation)
                .HasColumnName("ATTACHMENT_LOCATION")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AttachmentOrigin)
                .HasColumnName("ATTACHMENT_ORIGIN")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AttachmentSize)
                .HasColumnName("ATTACHMENT_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttachmentType)
                .HasColumnName("ATTACHMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BfileLocator)
                .HasColumnName("BFILE_LOCATOR")
                .HasColumnType("BFILE");

            entity.Property(e => e.DatabaseId)
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Filename)
                .HasColumnName("FILENAME")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GlobalYn)
                .HasColumnName("GLOBAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LinkId)
                .HasColumnName("LINK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LinkedTo)
                .IsRequired()
                .HasColumnName("LINKED_TO")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OriginLinkId)
                .HasColumnName("ORIGIN_LINK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
