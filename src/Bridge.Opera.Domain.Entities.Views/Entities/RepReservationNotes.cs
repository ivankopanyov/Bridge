namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepReservationNotes
{
    public decimal? ResvNameId { get; set; }
    public string? Resort { get; set; }
    public decimal? NoteId { get; set; }
    public string? NoteCode { get; set; }
    public string? RepNoteCode { get; set; }
    public string? Notes { get; set; }
    public string? InternalYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Description { get; set; }
    public string? UserModifiableYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepReservationNotes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_RESERVATION_NOTES");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NoteCode)
                .HasColumnName("NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoteId)
                .HasColumnName("NOTE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .IsUnicode(false);

            entity.Property(e => e.RepNoteCode)
                .HasColumnName("REP_NOTE_CODE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserModifiableYn)
                .HasColumnName("USER_MODIFIABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
