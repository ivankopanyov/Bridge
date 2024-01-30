namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QbSegments
{
    public decimal? SegId { get; set; }
    public string? SegCode { get; set; }
    public string? SegSourceType { get; set; }
    public string? Resort { get; set; }
    public decimal? OcrmProfileId { get; set; }
    public string? EspReplyStatus { get; set; }
    public decimal? NameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbSegments>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QB_SEGMENTS");

            entity.Property(e => e.EspReplyStatus)
                .HasColumnName("ESP_REPLY_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OcrmProfileId)
                .HasColumnName("OCRM_PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SegCode)
                .IsRequired()
                .HasColumnName("SEG_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SegId)
                .HasColumnName("SEG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SegSourceType)
                .IsRequired()
                .HasColumnName("SEG_SOURCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
