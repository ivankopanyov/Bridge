namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepResvMasterListVw
{
    public string ConfirmationNo { get; set; }
    public string Action { get; set; }
    public string Sname { get; set; }
    public string ResvStatus { get; set; }
    public string RateCode { get; set; }
    public string NameCode { get; set; }
    public DateTime? TruncActualCheckInDate { get; set; }
    public decimal? Nights { get; set; }
    public string RoomCategoryLabel { get; set; }
    public string ResInsertSource { get; set; }
    public string MarketCode { get; set; }
    public decimal? NoOfRooms { get; set; }
    public decimal InsertUser { get; set; }
    public decimal? EffectiveRateAmount { get; set; }
    public string Resort { get; set; }
    public string TravelAgentName { get; set; }
    public string OriginOfBooking { get; set; }
    public string OriginOfBookingDesc { get; set; }
    public string ResvContactName { get; set; }
    public DateTime InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepResvMasterListVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_RESV_MASTER_LIST_VW");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EffectiveRateAmount)
                .HasColumnName("EFFECTIVE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameCode)
                .HasColumnName("NAME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginOfBooking)
                .HasColumnName("ORIGIN_OF_BOOKING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OriginOfBookingDesc)
                .HasColumnName("ORIGIN_OF_BOOKING_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResInsertSource)
                .HasColumnName("RES_INSERT_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvContactName)
                .HasColumnName("RESV_CONTACT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.Sname)
                .IsRequired()
                .HasColumnName("SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentName)
                .HasColumnName("TRAVEL_AGENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TruncActualCheckInDate)
                .HasColumnName("TRUNC_ACTUAL_CHECK_IN_DATE")
                .HasColumnType("DATE");
        });
	}
}
