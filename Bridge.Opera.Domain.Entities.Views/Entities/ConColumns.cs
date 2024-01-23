namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ConColumns
{
    public string ColumnName { get; set; }
    public string DataType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ConColumns>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CON_COLUMNS");

            entity.Property(e => e.ColumnName)
                .IsRequired()
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(106)
                .IsUnicode(false);
        });
	}
}
