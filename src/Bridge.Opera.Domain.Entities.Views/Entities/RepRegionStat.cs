namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepRegionStat
{
    public string? RegionCode { get; set; }
    public string? Description { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? Rooms { get; set; }
    public decimal? Persons { get; set; }
    public decimal? ShareAmount { get; set; }
    public decimal? Arrivals { get; set; }
    public decimal? MonthNo { get; set; }
    public string? Month { get; set; }
    public decimal? YearNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepRegionStat>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_REGION_STAT");

            entity.Property(e => e.Arrivals)
                .HasColumnName("ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Month)
                .HasColumnName("MONTH")
                .IsUnicode(false);

            entity.Property(e => e.MonthNo)
                .HasColumnName("MONTH_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareAmount)
                .HasColumnName("SHARE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearNo)
                .HasColumnName("YEAR_NO")
                .HasColumnType("NUMBER");
        });
	}
}
