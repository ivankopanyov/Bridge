namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventTypesTranslation
{
    public string? EventType { get; set; }
    public string? Language { get; set; }
    public string? Description { get; set; }
    public string? ChainCode { get; set; }

    public virtual EventTypes EventTypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventTypesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.EventType, e.Language })
                .HasName("ETT_PK");

            entity.ToTable("EVENT$TYPES_TRANSLATION");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventType)
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(50)
                .IsUnicode(false);

			if (!types.Contains(typeof(EventTypes)))
				entity.Ignore(e => e.EventTypes);
			else
	            entity.HasOne(d => d.EventTypes)
	                .WithMany(p => p.EventTypesTranslation)
	                .HasForeignKey(d => new { d.ChainCode, d.EventType })
	                .HasConstraintName("ETT_ET_FK");
        });
	}
}
