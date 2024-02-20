namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepStatsView
{
    public string? MarketCode { get; set; }
    public string? ParentMarketCode { get; set; }
    public string? Description { get; set; }
    public decimal? DailyRoomRevenue { get; set; }
    public decimal? MonthlyRoomRevenue { get; set; }
    public decimal? YearlyRoomRevenue { get; set; }
    public decimal? DailyRooms { get; set; }
    public decimal? MonthlyRooms { get; set; }
    public decimal? YearlyRooms { get; set; }
    public decimal? DailyPersons { get; set; }
    public decimal? MonthlyPersons { get; set; }
    public decimal? YearlyPersons { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepStatsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_STATS_VIEW");

            entity.Property(e => e.DailyPersons)
                .HasColumnName("DAILY_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DailyRoomRevenue)
                .HasColumnName("DAILY_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DailyRooms)
                .HasColumnName("DAILY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .IsRequired()
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MonthlyPersons)
                .HasColumnName("MONTHLY_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthlyRoomRevenue)
                .HasColumnName("MONTHLY_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthlyRooms)
                .HasColumnName("MONTHLY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentMarketCode)
                .HasColumnName("PARENT_MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.YearlyPersons)
                .HasColumnName("YEARLY_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearlyRoomRevenue)
                .HasColumnName("YEARLY_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearlyRooms)
                .HasColumnName("YEARLY_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
