namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiFutureResFactVw
{
    public DateTime? StayDate { get; set; }
    public string Resort { get; set; }
    public string Market { get; set; }
    public string Rate { get; set; }
    public string SourceCode { get; set; }
    public string Channel { get; set; }
    public string ResInsertSource { get; set; }
    public decimal? OoRooms { get; set; }
    public decimal? CompRoomNts { get; set; }
    public decimal? Stays { get; set; }
    public decimal? Los { get; set; }
    public decimal? Adults { get; set; }
    public decimal? ArrPersons { get; set; }
    public decimal? ArrRooms { get; set; }
    public decimal? WlRooms { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? RoomsDed { get; set; }
    public decimal? RoomsNdd { get; set; }
    public decimal? RevenueDed { get; set; }
    public decimal? RevenueNdd { get; set; }
    public decimal? Crvd { get; set; }
    public decimal? Crvn { get; set; }
    public decimal? LeadDays { get; set; }
    public decimal? LeadCount { get; set; }
    public decimal? RoomsBlkDed { get; set; }
    public decimal? RevenueBlkDed { get; set; }
    public decimal? Crvbd { get; set; }
    public decimal? Rcnt { get; set; }
    public decimal? ArrAdults { get; set; }
    public decimal? ArrChildren { get; set; }
    public decimal? ArrResv { get; set; }
    public decimal? Children { get; set; }
    public decimal? Cancellations { get; set; }
    public decimal? CancelRooms { get; set; }
    public decimal? AvailRooms { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiFutureResFactVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_FUTURE_RES_FACT_VW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrAdults)
                .HasColumnName("ARR_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrChildren)
                .HasColumnName("ARR_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrPersons)
                .HasColumnName("ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrResv)
                .HasColumnName("ARR_RESV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrRooms)
                .HasColumnName("ARR_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailRooms)
                .HasColumnName("AVAIL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelRooms)
                .HasColumnName("CANCEL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cancellations)
                .HasColumnName("CANCELLATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRoomNts)
                .HasColumnName("COMP_ROOM_NTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Crvbd)
                .HasColumnName("CRVBD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Crvd)
                .HasColumnName("CRVD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Crvn)
                .HasColumnName("CRVN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadCount)
                .HasColumnName("LEAD_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadDays)
                .HasColumnName("LEAD_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Market)
                .HasColumnName("MARKET")
                .IsUnicode(false);

            entity.Property(e => e.OoRooms)
                .HasColumnName("OO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate)
                .HasColumnName("RATE")
                .IsUnicode(false);

            entity.Property(e => e.Rcnt)
                .HasColumnName("RCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResInsertSource)
                .HasColumnName("RES_INSERT_SOURCE")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.RevenueBlkDed)
                .HasColumnName("REVENUE_BLK_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueDed)
                .HasColumnName("REVENUE_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueNdd)
                .HasColumnName("REVENUE_NDD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsBlkDed)
                .HasColumnName("ROOMS_BLK_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsDed)
                .HasColumnName("ROOMS_DED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsNdd)
                .HasColumnName("ROOMS_NDD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Stays)
                .HasColumnName("STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WlRooms)
                .HasColumnName("WL_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
