namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SpgTranslationView
{
    public decimal? FieldId { get; set; }
    public string FieldName { get; set; }
    public string OriginalValue { get; set; }
    public string TranslatedValue { get; set; }
    public string SameAsOriginalYn { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SpgTranslationView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SPG_TRANSLATION_VIEW");

            entity.Property(e => e.FieldId)
                .HasColumnName("FIELD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalValue)
                .HasColumnName("ORIGINAL_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SameAsOriginalYn)
                .HasColumnName("SAME_AS_ORIGINAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TranslatedValue)
                .HasColumnName("TRANSLATED_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
