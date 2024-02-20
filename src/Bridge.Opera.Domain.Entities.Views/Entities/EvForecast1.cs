namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EvForecast1
{
    public decimal? EvForecastid { get; set; }
    public string? Resort { get; set; }
    public string? EvType { get; set; }
    public DateTime? FcBegin { get; set; }
    public DateTime? FcEnd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EvForecast1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EV_FORECAST");

            entity.Property(e => e.EvForecastid)
                .HasColumnName("EV_FORECASTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EvType)
                .IsRequired()
                .HasColumnName("EV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FcBegin)
                .HasColumnName("FC_BEGIN")
                .HasColumnType("DATE");

            entity.Property(e => e.FcEnd)
                .HasColumnName("FC_END")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
