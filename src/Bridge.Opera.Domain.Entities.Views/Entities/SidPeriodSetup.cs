namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidPeriodSetup
{
    public string? Code { get; set; }
    public string? Description { get; set; }
    public DateTime? EndDate { get; set; }
    public string? PeriodType { get; set; }
    public string? Resort { get; set; }
    public DateTime? StartDate { get; set; }
    public decimal? YearId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidPeriodSetup>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_PERIOD$SETUP");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PeriodType)
                .IsRequired()
                .HasColumnName("PERIOD_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.YearId)
                .HasColumnName("YEAR_ID")
                .HasColumnType("NUMBER");
        });
	}
}
