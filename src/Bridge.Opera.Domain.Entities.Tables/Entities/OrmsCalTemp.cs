namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsCalTemp
{
    public decimal? Id { get; set; }
    public DateTime? Dt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsCalTemp>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Dt })
                .HasName("ORMS_CAL_TEMP_PK");

            entity.ToTable("ORMS_CAL_TEMP");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Dt)
                .HasColumnName("DT")
                .HasColumnType("DATE");
        });
	}
}
