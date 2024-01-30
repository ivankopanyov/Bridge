namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FileSizesView
{
    public string? Code { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FileSizesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FILE_SIZES_VIEW");

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
