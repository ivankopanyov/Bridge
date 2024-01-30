namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidYearSetup
{
    public string? Description { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Resort { get; set; }
    public DateTime? StartDate { get; set; }
    public decimal? YearId { get; set; }
    public decimal? Year { get; set; }
    public string? YearType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidYearSetup>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_YEAR$SETUP");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Year)
                .HasColumnName("YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearId)
                .HasColumnName("YEAR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearType)
                .IsRequired()
                .HasColumnName("YEAR_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
