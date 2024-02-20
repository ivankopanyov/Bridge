namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiCalculatedMeasures
{
    public string? CalcMeasureId { get; set; }
    public string? CalcMeasureDesc { get; set; }
    public decimal? SortOrder { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCalculatedMeasures>(entity =>
        {
            entity.HasKey(e => e.CalcMeasureId)
                .HasName("OBI_CALCULATED_MEASURES_PK");

            entity.ToTable("OBI_CALCULATED_MEASURES");

            entity.Property(e => e.CalcMeasureId)
                .HasColumnName("CALC_MEASURE_ID")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.CalcMeasureDesc)
                .HasColumnName("CALC_MEASURE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.SortOrder)
                .HasColumnName("SORT_ORDER")
                .HasColumnType("NUMBER");
        });
	}
}
