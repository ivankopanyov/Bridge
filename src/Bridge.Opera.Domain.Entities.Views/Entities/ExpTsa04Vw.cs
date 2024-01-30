namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpTsa04Vw
{
    public string? BusinessDate { get; set; }
    public string? Resort { get; set; }
    public string? Name { get; set; }
    public string? RoomClass { get; set; }
    public decimal? OccRoom { get; set; }
    public decimal? AvailRoom { get; set; }
    public decimal? OooRooms { get; set; }
    public decimal? OsRooms { get; set; }
    public decimal? CompRoom { get; set; }
    public decimal? HouseUseRoom { get; set; }
    public decimal? DayuseRoom { get; set; }
    public decimal? WalkinRoom { get; set; }
    public decimal? NoshowRoom { get; set; }
    public decimal? ArrivalRoom { get; set; }
    public decimal? DefArrivalsToday { get; set; }
    public decimal? EarlyDepRoom { get; set; }
    public decimal? ExtStayRoom { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodBevRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpTsa04Vw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_TSA04_VW");

            entity.Property(e => e.ArrivalRoom)
                .HasColumnName("ARRIVAL_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailRoom)
                .HasColumnName("AVAIL_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.CompRoom)
                .HasColumnName("COMP_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayuseRoom)
                .HasColumnName("DAYUSE_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefArrivalsToday)
                .HasColumnName("DEF_ARRIVALS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EarlyDepRoom)
                .HasColumnName("EARLY_DEP_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtStayRoom)
                .HasColumnName("EXT_STAY_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodBevRevenue)
                .HasColumnName("FOOD_BEV_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HouseUseRoom)
                .HasColumnName("HOUSE_USE_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NoshowRoom)
                .HasColumnName("NOSHOW_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccRoom)
                .HasColumnName("OCC_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OooRooms)
                .HasColumnName("OOO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OsRooms)
                .HasColumnName("OS_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .IsRequired()
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WalkinRoom)
                .HasColumnName("WALKIN_ROOM")
                .HasColumnType("NUMBER");
        });
	}
}
