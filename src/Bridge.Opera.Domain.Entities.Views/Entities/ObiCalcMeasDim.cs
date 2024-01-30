namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCalcMeasDim
{
    public string? CalcMeasureId { get; set; }
    public string? CalcMeasureDesc { get; set; }
    public decimal? SortOrder { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCalcMeasDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CALC_MEAS_DIM");

            entity.Property(e => e.CalcMeasureDesc)
                .HasColumnName("CALC_MEASURE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CalcMeasureId)
                .IsRequired()
                .HasColumnName("CALC_MEASURE_ID")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.SortOrder)
                .HasColumnName("SORT_ORDER")
                .HasColumnType("NUMBER");
        });
	}
}
