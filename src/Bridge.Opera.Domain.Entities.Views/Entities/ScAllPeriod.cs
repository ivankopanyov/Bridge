namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScAllPeriod
{
    public string Resort { get; set; }
    public DateTime PeriodStart { get; set; }
    public DateTime PeriodEnd { get; set; }
    public string Description { get; set; }
    public string Code { get; set; }
    public string PeriodType { get; set; }
    public decimal YearId { get; set; }
    public string YearDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScAllPeriod>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_ALL_PERIOD");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PeriodEnd)
                .HasColumnName("PERIOD_END")
                .HasColumnType("DATE");

            entity.Property(e => e.PeriodStart)
                .HasColumnName("PERIOD_START")
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

            entity.Property(e => e.YearDescription)
                .HasColumnName("YEAR_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.YearId)
                .HasColumnName("YEAR_ID")
                .HasColumnType("NUMBER");
        });
	}
}
