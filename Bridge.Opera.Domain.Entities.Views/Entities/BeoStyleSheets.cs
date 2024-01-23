namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BeoStyleSheets
{
    public decimal AttachId { get; set; }
    public string Description { get; set; }
    public string Filename { get; set; }
    public string DefaultYn { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal InsertUser { get; set; }
    public decimal UpdateUser { get; set; }
    public string AttachmentOrigin { get; set; }
    public string AttachmentSize { get; set; }
    public string LinkedTo { get; set; }
    public string Resort { get; set; }
    public string LinkId { get; set; }
    public string AttachmentLocation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BeoStyleSheets>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BEO_STYLE_SHEETS");

            entity.Property(e => e.AttachId)
                .HasColumnName("ATTACH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttachmentLocation)
                .HasColumnName("ATTACHMENT_LOCATION")
                .IsUnicode(false);

            entity.Property(e => e.AttachmentOrigin)
                .HasColumnName("ATTACHMENT_ORIGIN")
                .IsUnicode(false);

            entity.Property(e => e.AttachmentSize)
                .HasColumnName("ATTACHMENT_SIZE")
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Filename)
                .IsRequired()
                .HasColumnName("FILENAME")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkId)
                .HasColumnName("LINK_ID")
                .IsUnicode(false);

            entity.Property(e => e.LinkedTo)
                .HasColumnName("LINKED_TO")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
