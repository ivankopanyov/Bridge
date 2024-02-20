namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LaptopConstraints
{
    public string? TableName { get; set; }
    public string? ConstraintName { get; set; }
    public string? ConstraintType { get; set; }
    public string? RefTableName { get; set; }
    public string? Ddl { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LaptopConstraints>(entity =>
        {
            entity.HasKey(e => new { e.TableName, e.ConstraintName })
                .HasName("LAPC_PK");

            entity.ToTable("LAPTOP$CONSTRAINTS");

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.ConstraintName)
                .HasColumnName("CONSTRAINT_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.ConstraintType)
                .HasColumnName("CONSTRAINT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Ddl)
                .HasColumnName("DDL")
                .IsUnicode(false);

            entity.Property(e => e.RefTableName)
                .HasColumnName("REF_TABLE_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);
        });
	}
}
