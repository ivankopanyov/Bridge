namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArYearScale
{
    public string? Resort { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArYearScale>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_YEAR_SCALE");

            entity.Property(e => e.FromDate)
                .HasColumnName("FROM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.ToDate)
                .HasColumnName("TO_DATE")
                .HasColumnType("DATE");
        });
	}
}
