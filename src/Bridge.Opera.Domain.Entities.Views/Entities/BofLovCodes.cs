namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofLovCodes
{
    public string? BofColumnName { get; set; }
    public string? BofColumnType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofLovCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_LOV_CODES");

            entity.Property(e => e.BofColumnName)
                .HasColumnName("BOF_COLUMN_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.BofColumnType)
                .HasColumnName("BOF_COLUMN_TYPE")
                .HasMaxLength(106)
                .IsUnicode(false);
        });
	}
}
