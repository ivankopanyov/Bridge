namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiTurnawayFactVw
{
    public string? Resort { get; set; }
    public DateTime? CreateDate { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public string? Hour { get; set; }
    public string? Turnaway { get; set; }
    public string? Market { get; set; }
    public string? Rate { get; set; }
    public string? InsertUser { get; set; }
    public decimal? RateAmount { get; set; }
    public decimal? Nights { get; set; }
    public decimal? Rooms { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? CRateAmount { get; set; }
    public decimal? Revenue { get; set; }
    public decimal? CRevenue { get; set; }
    public decimal? Rcnt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiTurnawayFactVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_TURNAWAY_FACT_VW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CRateAmount)
                .HasColumnName("C_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRevenue)
                .HasColumnName("C_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreateDate)
                .HasColumnName("CREATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Hour)
                .HasColumnName("HOUR")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .IsUnicode(false);

            entity.Property(e => e.Market)
                .HasColumnName("MARKET")
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate)
                .HasColumnName("RATE")
                .IsUnicode(false);

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rcnt)
                .HasColumnName("RCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Turnaway)
                .HasColumnName("TURNAWAY")
                .IsUnicode(false);
        });
	}
}
