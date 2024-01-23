namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCustomLabels
{
    public string CustomVarName { get; set; }
    public string CustomVarLabel { get; set; }
    public string PresentationTable { get; set; }
    public string DimName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCustomLabels>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CUSTOM_LABELS");

            entity.Property(e => e.CustomVarLabel)
                .HasColumnName("CUSTOM_VAR_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.CustomVarName)
                .HasColumnName("CUSTOM_VAR_NAME")
                .HasMaxLength(85)
                .IsUnicode(false);

            entity.Property(e => e.DimName)
                .HasColumnName("DIM_NAME")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.PresentationTable)
                .HasColumnName("PRESENTATION_TABLE")
                .HasMaxLength(18)
                .IsUnicode(false);
        });
	}
}
