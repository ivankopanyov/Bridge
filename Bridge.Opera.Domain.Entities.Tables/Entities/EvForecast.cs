namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EvForecast
{
    public EvForecast()
    {
        EvForecastRevenue = new HashSet<EvForecastRevenue>();
    }

    public decimal EvForecastid { get; set; }
    public string EvType { get; set; }
    public string Resort { get; set; }
    public DateTime? FcBegin { get; set; }
    public DateTime? FcEnd { get; set; }

    public virtual Resort ResortNavigation { get; set; }
    public virtual ICollection<EvForecastRevenue> EvForecastRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EvForecast>(entity =>
        {
            entity.ToTable("EV$FORECAST");

            entity.HasIndex(e => e.EvType)
                .HasName("EFC_EVTYPE_IDX");

            entity.HasIndex(e => new { e.Resort, e.EvType })
                .HasName("RESORT_TYPE_IDX");

            entity.Property(e => e.EvForecastid)
                .HasColumnName("EV_FORECASTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EvType)
                .IsRequired()
                .HasColumnName("EV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.EvForecast)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EVFCAST_RESORT_FK");
        
			if (!types.Contains(typeof(EvForecastRevenue)))
				entity.Ignore(e => e.EvForecastRevenue);
		});
	}
}
