namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PermanentFolioStorageView
{
    public string? Code { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PermanentFolioStorageView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PERMANENT_FOLIO_STORAGE_VIEW");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(21)
                .IsUnicode(false);
        });
	}
}
