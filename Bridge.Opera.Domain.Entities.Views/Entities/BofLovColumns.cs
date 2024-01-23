namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofLovColumns
{
    public string BofColumnName { get; set; }
    public string BofColumnType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofLovColumns>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_LOV_COLUMNS");

            entity.Property(e => e.BofColumnName)
                .IsRequired()
                .HasColumnName("BOF_COLUMN_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BofColumnType)
                .IsRequired()
                .HasColumnName("BOF_COLUMN_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
