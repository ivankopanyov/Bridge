namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmEspTemplateCodes
{
    public string? TemplateCode { get; set; }
    public string? Resort { get; set; }
    public string? EspTemplateCode { get; set; }
    public string? EspCode { get; set; }
    public string? TemplateUrl { get; set; }
    public string? LanguageCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmEspTemplateCodes>(entity =>
        {
            entity.HasKey(e => new { e.TemplateCode, e.Resort })
                .HasName("TCE_PK");

            entity.ToTable("OCRM_ESP_TEMPLATE_CODES");

            entity.Property(e => e.TemplateCode)
                .HasColumnName("TEMPLATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EspCode)
                .IsRequired()
                .HasColumnName("ESP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EspTemplateCode)
                .IsRequired()
                .HasColumnName("ESP_TEMPLATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TemplateUrl)
                .HasColumnName("TEMPLATE_URL")
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
