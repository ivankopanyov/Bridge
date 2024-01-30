namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemItemTranslation1
{
    public string? Resort { get; set; }
    public decimal? ItemId { get; set; }
    public string? Language { get; set; }
    public string? Field { get; set; }
    public string? Text { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemTranslation1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_ITEM_TRANSLATION");

            entity.Property(e => e.Field)
                .IsRequired()
                .HasColumnName("FIELD")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Language)
                .IsRequired()
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Text)
                .HasColumnName("TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
