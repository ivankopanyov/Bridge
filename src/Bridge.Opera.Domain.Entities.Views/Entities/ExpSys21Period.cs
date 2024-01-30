namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21Period
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? PeriodSeq { get; set; }
    public string? Year { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21Period>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_PERIOD");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PeriodSeq)
                .HasColumnName("PERIOD_SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Year)
                .HasColumnName("YEAR")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
