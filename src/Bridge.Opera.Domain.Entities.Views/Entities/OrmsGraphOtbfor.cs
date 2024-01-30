namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsGraphOtbfor
{
    public decimal? Id { get; set; }
    public string? SeriesCode { get; set; }
    public string? SeriesVal { get; set; }
    public DateTime? RecordDate { get; set; }
    public decimal? YValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsGraphOtbfor>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_GRAPH_OTBFOR");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordDate)
                .HasColumnName("RECORD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SeriesCode)
                .HasColumnName("SERIES_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SeriesVal)
                .HasColumnName("SERIES_VAL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.YValue)
                .HasColumnName("Y_VALUE")
                .HasColumnType("NUMBER");
        });
	}
}
