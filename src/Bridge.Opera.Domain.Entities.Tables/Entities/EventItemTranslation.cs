namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventItemTranslation
{
    public decimal EventItemId { get; set; }
    public string Language { get; set; }
    public string Field { get; set; }
    public string Text { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventItemTranslation>(entity =>
        {
            entity.HasKey(e => new { e.EventItemId, e.Language, e.Field })
                .HasName("EVITMT_PK");

            entity.ToTable("EVENT$ITEM_TRANSLATION");

            entity.Property(e => e.EventItemId)
                .HasColumnName("EVENT_ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Field)
                .HasColumnName("FIELD")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Text)
                .HasColumnName("TEXT")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
