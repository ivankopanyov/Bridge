namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FolioStyles
{
    public string? Code { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FolioStyles>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FOLIO_STYLES");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);
        });
	}
}
