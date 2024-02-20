namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DataElementTemp
{
    public string? Element { get; set; }
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }
    public string? Status { get; set; }
    public DateTime? ScopeFrom { get; set; }
    public DateTime? ScopeTo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DataElementTemp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("DATA_ELEMENT_TEMP");

            entity.Property(e => e.Element)
                .HasColumnName("ELEMENT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.OldValue)
                .HasColumnName("OLD_VALUE")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.ScopeFrom)
                .HasColumnName("SCOPE_FROM")
                .HasColumnType("DATE");

            entity.Property(e => e.ScopeTo)
                .HasColumnName("SCOPE_TO")
                .HasColumnType("DATE");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
