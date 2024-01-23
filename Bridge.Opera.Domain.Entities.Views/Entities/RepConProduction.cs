namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepConProduction
{
    public decimal? NameId { get; set; }
    public string MasterGrouping { get; set; }
    public string DetailGrouping { get; set; }
    public string BookedStayed { get; set; }
    public decimal? RoomNights { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepConProduction>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_CON_PRODUCTION");

            entity.Property(e => e.BookedStayed)
                .HasColumnName("BOOKED_STAYED")
                .HasColumnType("CHAR(6)");

            entity.Property(e => e.DetailGrouping)
                .HasColumnName("DETAIL_GROUPING")
                .IsUnicode(false);

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterGrouping)
                .HasColumnName("MASTER_GROUPING")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}
