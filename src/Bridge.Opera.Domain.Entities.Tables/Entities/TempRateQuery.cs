namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempRateQuery
{
    public string? Col { get; set; }
    public string? GdsOnRequest { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempRateQuery>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_RATE_QUERY");

            entity.HasIndex(e => e.Col)
                .HasName("TRQ_IDX");

            entity.Property(e => e.Col)
                .HasColumnName("COL")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.GdsOnRequest)
                .HasColumnName("GDS_ON_REQUEST")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
