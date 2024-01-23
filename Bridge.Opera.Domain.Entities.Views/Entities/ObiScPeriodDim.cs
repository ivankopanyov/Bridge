namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiScPeriodDim
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Year { get; set; }
    public string PeriodCode { get; set; }
    public string Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiScPeriodDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SC_PERIOD_DIM");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PeriodCode)
                .IsRequired()
                .HasColumnName("PERIOD_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

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
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
