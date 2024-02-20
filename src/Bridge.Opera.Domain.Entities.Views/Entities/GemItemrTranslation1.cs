namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemItemrTranslation1
{
    public decimal? ItemrateId { get; set; }
    public string? Language { get; set; }
    public string? Field { get; set; }
    public string? Text { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemrTranslation1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_ITEMR_TRANSLATION");

            entity.Property(e => e.Field)
                .IsRequired()
                .HasColumnName("FIELD")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ItemrateId)
                .HasColumnName("ITEMRATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Language)
                .IsRequired()
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Text)
                .HasColumnName("TEXT")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
