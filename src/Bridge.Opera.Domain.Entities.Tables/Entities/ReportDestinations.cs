namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReportDestinations
{
    public string? ReportId { get; set; }
    public decimal? Destseq { get; set; }
    public string? Desttype { get; set; }
    public string? Destname { get; set; }
    public string? Desturl { get; set; }
    public decimal? Copies { get; set; }
    public string? Format { get; set; }
    public string? DeliveryType { get; set; }
    public string? Subject { get; set; }
    public string? BodyText { get; set; }
    public string? DeliveryResort { get; set; }
    public string? ProcessedYn { get; set; }
    public string? AttachmentName { get; set; }
    public string? FromEmail { get; set; }
    public string? WatermarkMode { get; set; }
    public string? WatermarkText { get; set; }
    public decimal? WatermarkXpos { get; set; }
    public decimal? WatermarkYpos { get; set; }
    public decimal? WatermarkAngle { get; set; }
    public decimal? WatermarkColorR { get; set; }
    public decimal? WatermarkColorG { get; set; }
    public decimal? WatermarkColorB { get; set; }
    public string? WatermarkFont { get; set; }
    public decimal? WatermarkFontSize { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReportDestinations>(entity =>
        {
            entity.HasKey(e => new { e.ReportId, e.Destseq })
                .HasName("REPORT_DESTINATIONS_PK");

            entity.ToTable("REPORT_DESTINATIONS");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Destseq)
                .HasColumnName("DESTSEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttachmentName)
                .HasColumnName("ATTACHMENT_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BodyText)
                .HasColumnName("BODY_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.Copies)
                .HasColumnName("COPIES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeliveryResort)
                .HasColumnName("DELIVERY_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryType)
                .HasColumnName("DELIVERY_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Destname)
                .HasColumnName("DESTNAME")
                .IsUnicode(false);

            entity.Property(e => e.Desttype)
                .IsRequired()
                .HasColumnName("DESTTYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Desturl)
                .HasColumnName("DESTURL")
                .IsUnicode(false);

            entity.Property(e => e.Format)
                .HasColumnName("FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FromEmail)
                .HasColumnName("FROM_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ProcessedYn)
                .HasColumnName("PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Subject)
                .HasColumnName("SUBJECT")
                .IsUnicode(false);

            entity.Property(e => e.WatermarkAngle)
                .HasColumnName("WATERMARK_ANGLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WatermarkColorB)
                .HasColumnName("WATERMARK_COLOR_B")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WatermarkColorG)
                .HasColumnName("WATERMARK_COLOR_G")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WatermarkColorR)
                .HasColumnName("WATERMARK_COLOR_R")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WatermarkFont)
                .HasColumnName("WATERMARK_FONT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.WatermarkFontSize)
                .HasColumnName("WATERMARK_FONT_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WatermarkMode)
                .HasColumnName("WATERMARK_MODE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WatermarkText)
                .HasColumnName("WATERMARK_TEXT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.WatermarkXpos)
                .HasColumnName("WATERMARK_XPOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WatermarkYpos)
                .HasColumnName("WATERMARK_YPOS")
                .HasColumnType("NUMBER");
        });
	}
}
