namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCustomDimNames
{
    public string? DimName { get; set; }
    public string? DimView { get; set; }
    public string? DimKey { get; set; }
    public decimal? AttributeCount { get; set; }
    public string? DimLabel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCustomDimNames>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CUSTOM_DIM_NAMES");

            entity.Property(e => e.AttributeCount)
                .HasColumnName("ATTRIBUTE_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DimKey)
                .HasColumnName("DIM_KEY")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.DimLabel)
                .HasColumnName("DIM_LABEL")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.DimName)
                .HasColumnName("DIM_NAME")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.DimView)
                .HasColumnName("DIM_VIEW")
                .HasMaxLength(23)
                .IsUnicode(false);
        });
	}
}
