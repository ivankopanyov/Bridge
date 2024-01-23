namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppIndicatorHeader
{
    public string IndicatorCode { get; set; }
    public string IndicatorType { get; set; }
    public string Description { get; set; }
    public string DisplayName { get; set; }
    public string CanDeleteYn { get; set; }
    public string Bgcolor { get; set; }
    public string Fgcolor { get; set; }
    public string StatusLov { get; set; }
    public string Indcolor { get; set; }
    public string Action { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppIndicatorHeader>(entity =>
        {
            entity.HasKey(e => e.IndicatorCode)
                .HasName("AIR_PK");

            entity.ToTable("APP_INDICATOR_HEADER");

            entity.Property(e => e.IndicatorCode)
                .HasColumnName("INDICATOR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .IsUnicode(false);

            entity.Property(e => e.Bgcolor)
                .HasColumnName("BGCOLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Fgcolor)
                .HasColumnName("FGCOLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Indcolor)
                .HasColumnName("INDCOLOR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.IndicatorType)
                .IsRequired()
                .HasColumnName("INDICATOR_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatusLov)
                .HasColumnName("STATUS_LOV")
                .IsUnicode(false);
        });
	}
}
