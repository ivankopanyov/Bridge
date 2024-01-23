namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventMenuTranslation
{
    public decimal MenuId { get; set; }
    public string Language { get; set; }
    public string Field { get; set; }
    public string Text { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventMenuTranslation>(entity =>
        {
            entity.HasKey(e => new { e.MenuId, e.Language, e.Field })
                .HasName("EVMT_PK");

            entity.ToTable("EVENT$MENU_TRANSLATION");

            entity.Property(e => e.MenuId)
                .HasColumnName("MENU_ID")
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
