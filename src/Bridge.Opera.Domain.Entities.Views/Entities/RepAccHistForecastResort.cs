namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepAccHistForecastResort
{
    public string Resort { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string CurrencyCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepAccHistForecastResort>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_ACC_HIST_FORECAST_RESORT");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
