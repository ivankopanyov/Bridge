namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DitCopyTables
{
    public string ObjectName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DitCopyTables>(entity =>
        {
            entity.HasKey(e => e.ObjectName)
                .HasName("DIT_COPY_TABLES_PK");

            entity.ToTable("DIT_COPY_TABLES");

            entity.Property(e => e.ObjectName)
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
