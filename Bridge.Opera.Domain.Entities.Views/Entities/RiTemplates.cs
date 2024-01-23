namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RiTemplates
{
    public string Resort { get; set; }
    public decimal RiTemplateId { get; set; }
    public string RiTemplateName { get; set; }
    public string RiTemplateType { get; set; }
    public DateTime? LastRiDate { get; set; }
    public decimal? LastRiBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RiTemplates>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RI_TEMPLATES");

            entity.Property(e => e.LastRiBy)
                .HasColumnName("LAST_RI_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastRiDate)
                .HasColumnName("LAST_RI_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RiTemplateId)
                .HasColumnName("RI_TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiTemplateName)
                .IsRequired()
                .HasColumnName("RI_TEMPLATE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RiTemplateType)
                .IsRequired()
                .HasColumnName("RI_TEMPLATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
