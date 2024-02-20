namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FacilityForecastView
{
    public string? Type { get; set; }
    public decimal? Seq { get; set; }
    public string? FacilityTask { get; set; }
    public string? TaskCode { get; set; }
    public string? Multi { get; set; }
    public decimal? Day1 { get; set; }
    public decimal? Day2 { get; set; }
    public decimal? Day3 { get; set; }
    public decimal? Day4 { get; set; }
    public decimal? Day5 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FacilityForecastView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FACILITY_FORECAST_VIEW");

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FacilityTask)
                .HasColumnName("FACILITY_TASK")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Multi)
                .HasColumnName("MULTI")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Seq)
                .HasColumnName("SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasMaxLength(22)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasColumnType("CHAR(1)");
        });
	}
}
