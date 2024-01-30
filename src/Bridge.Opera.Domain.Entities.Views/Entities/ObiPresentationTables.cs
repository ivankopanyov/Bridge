namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiPresentationTables
{
    public string? PresentationTable { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiPresentationTables>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PRESENTATION_TABLES");

            entity.Property(e => e.PresentationTable)
                .HasColumnName("PRESENTATION_TABLE")
                .HasMaxLength(18)
                .IsUnicode(false);
        });
	}
}
