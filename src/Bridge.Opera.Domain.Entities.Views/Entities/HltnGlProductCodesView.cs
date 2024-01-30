namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HltnGlProductCodesView
{
    public string? ProductCode { get; set; }
    public string? ProductCodeDisplay { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HltnGlProductCodesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HLTN_GL_PRODUCT_CODES_VIEW");

            entity.Property(e => e.ProductCode)
                .HasColumnName("PRODUCT_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ProductCodeDisplay)
                .HasColumnName("PRODUCT_CODE_DISPLAY")
                .HasMaxLength(50)
                .IsUnicode(false);
        });
	}
}
