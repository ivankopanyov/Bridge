namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OperaConstraints
{
    public string? TableName { get; set; }
    public string? ConstraintName { get; set; }
    public string? RConstraintName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaConstraints>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OPERA_CONSTRAINTS");

            entity.Property(e => e.ConstraintName)
                .HasColumnName("CONSTRAINT_NAME")
                .HasMaxLength(29)
                .IsUnicode(false);

            entity.Property(e => e.RConstraintName)
                .HasColumnName("R_CONSTRAINT_NAME")
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(28)
                .IsUnicode(false);
        });
	}
}
