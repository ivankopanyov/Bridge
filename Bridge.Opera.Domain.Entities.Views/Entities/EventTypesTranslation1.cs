namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventTypesTranslation1
{
    public string EventType { get; set; }
    public string Language { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventTypesTranslation1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_TYPES_TRANSLATION");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EventType)
                .IsRequired()
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Language)
                .IsRequired()
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
