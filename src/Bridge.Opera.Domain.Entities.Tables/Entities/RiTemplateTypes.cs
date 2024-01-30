namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RiTemplateTypes
{
    public string? Resort { get; set; }
    public string? RiTemplateType { get; set; }
    public string? RiTemplateDescription { get; set; }
    public decimal? RiTemplateAccScore { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RiTemplateTypes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RiTemplateType })
                .HasName("RTT_PK");

            entity.ToTable("RI_TEMPLATE_TYPES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RiTemplateType)
                .HasColumnName("RI_TEMPLATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RiTemplateAccScore)
                .HasColumnName("RI_TEMPLATE_ACC_SCORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiTemplateDescription)
                .IsRequired()
                .HasColumnName("RI_TEMPLATE_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
