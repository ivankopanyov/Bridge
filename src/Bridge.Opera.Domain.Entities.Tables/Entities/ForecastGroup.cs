namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ForecastGroup
{
    public string ForecastCode { get; set; }
    public string Description { get; set; }
    public decimal? Sequence { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ForecastGroup>(entity =>
        {
            entity.HasKey(e => e.ForecastCode)
                .HasName("FCODE_PK");

            entity.ToTable("FORECAST_GROUP");

            entity.Property(e => e.ForecastCode)
                .HasColumnName("FORECAST_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
                .HasColumnType("NUMBER");
        });
	}
}
