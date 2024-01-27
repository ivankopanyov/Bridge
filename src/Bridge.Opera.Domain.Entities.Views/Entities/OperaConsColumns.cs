namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OperaConsColumns
{
    public string ColumnName { get; set; }
    public string ConstraintName { get; set; }
    public decimal? Position { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaConsColumns>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OPERA_CONS_COLUMNS");

            entity.Property(e => e.ColumnName)
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(22)
                .IsUnicode(false);

            entity.Property(e => e.ConstraintName)
                .HasColumnName("CONSTRAINT_NAME")
                .HasMaxLength(29)
                .IsUnicode(false);

            entity.Property(e => e.Position)
                .HasColumnName("POSITION")
                .HasColumnType("NUMBER");
        });
	}
}
