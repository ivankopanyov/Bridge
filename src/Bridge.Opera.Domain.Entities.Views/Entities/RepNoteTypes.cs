namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepNoteTypes
{
    public string NoteGroup { get; set; }
    public string Description { get; set; }
    public string RepNoteCode { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepNoteTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_NOTE_TYPES");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.NoteGroup)
                .HasColumnName("NOTE_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepNoteCode)
                .HasColumnName("REP_NOTE_CODE")
                .HasMaxLength(22)
                .IsUnicode(false);
        });
	}
}
