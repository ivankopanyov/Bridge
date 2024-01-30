namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntResyncParameters
{
    public decimal? Id { get; set; }
    public string? Name { get; set; }
    public string? Value { get; set; }
    public string? DataType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntResyncParameters>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_RESYNC_PARAMETERS");

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.Value)
                .HasColumnName("VALUE")
                .HasMaxLength(64)
                .IsUnicode(false);
        });
	}
}
