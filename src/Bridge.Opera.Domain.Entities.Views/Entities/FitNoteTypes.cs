namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FitNoteTypes
{
    public string NoteCode { get; set; }
    public string Description { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FitNoteTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIT_NOTE_TYPES");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NoteCode)
                .IsRequired()
                .HasColumnName("NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
