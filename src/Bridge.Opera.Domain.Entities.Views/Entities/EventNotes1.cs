namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventNotes1
{
    public decimal? NoteId { get; set; }
    public decimal? EventId { get; set; }
    public string? NoteCode { get; set; }
    public string? NoteTitle { get; set; }
    public string? InternalYn { get; set; }
    public string? Notes { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventNotes1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_NOTES");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoteCode)
                .HasColumnName("NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoteId)
                .HasColumnName("NOTE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoteTitle)
                .HasColumnName("NOTE_TITLE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
