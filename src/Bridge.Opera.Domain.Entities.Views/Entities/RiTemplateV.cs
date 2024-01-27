namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RiTemplateV
{
    public string Resort { get; set; }
    public decimal TemplateId { get; set; }
    public string TemplateName { get; set; }
    public string TemplateType { get; set; }
    public DateTime? LastRiDate { get; set; }
    public decimal? LastRiBy { get; set; }
    public string TemplateTypeDesc { get; set; }
    public string FullName { get; set; }
    public decimal? QuestionCount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RiTemplateV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RI_TEMPLATE_V");

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .IsUnicode(false);

            entity.Property(e => e.LastRiBy)
                .HasColumnName("LAST_RI_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastRiDate)
                .HasColumnName("LAST_RI_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QuestionCount)
                .HasColumnName("QUESTION_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TemplateId)
                .HasColumnName("TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TemplateName)
                .IsRequired()
                .HasColumnName("TEMPLATE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TemplateType)
                .IsRequired()
                .HasColumnName("TEMPLATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TemplateTypeDesc)
                .HasColumnName("TEMPLATE_TYPE_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
