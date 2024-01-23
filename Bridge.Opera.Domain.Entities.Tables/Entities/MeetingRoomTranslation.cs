namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MeetingRoomTranslation
{
    public string Resort { get; set; }
    public string Room { get; set; }
    public string Language { get; set; }
    public string Field { get; set; }
    public string Text { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MeetingRoomTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Room, e.Language, e.Field })
                .HasName("MRTR_PK");

            entity.ToTable("MEETING_ROOM$TRANSLATION");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

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
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
