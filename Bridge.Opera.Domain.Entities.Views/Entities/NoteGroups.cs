namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NoteGroups
{
    public string NoteType { get; set; }
    public string Desc1 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NoteGroups>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NOTE_GROUPS");

            entity.Property(e => e.Desc1)
                .HasColumnName("DESC1")
                .HasMaxLength(1500)
                .IsUnicode(false);

            entity.Property(e => e.NoteType)
                .HasColumnName("NOTE_TYPE")
                .HasMaxLength(9)
                .IsUnicode(false);
        });
	}
}
