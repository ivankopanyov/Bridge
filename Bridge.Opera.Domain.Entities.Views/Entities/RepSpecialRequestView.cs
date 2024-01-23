namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepSpecialRequestView
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string ComputedResvStatus { get; set; }
    public DateTime? Arrival { get; set; }
    public decimal? Nights { get; set; }
    public DateTime? Departure { get; set; }
    public string DepartureChar { get; set; }
    public string ArrivalChar { get; set; }
    public string FullName { get; set; }
    public decimal? Persons { get; set; }
    public decimal? CompanyId { get; set; }
    public string CompanyName { get; set; }
    public string GroupName { get; set; }
    public decimal? GroupId { get; set; }
    public string RoomCategory { get; set; }
    public string RoomCategoryLabel { get; set; }
    public decimal? NoOfRooms { get; set; }
    public string Room { get; set; }
    public string RoomNo { get; set; }
    public DateTime ReservationDate { get; set; }
    public string Vip { get; set; }
    public decimal? NoOfStays { get; set; }
    public decimal SpecialRequestId { get; set; }
    public string SpecialRequest { get; set; }
    public string SpecialRequestDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepSpecialRequestView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_SPECIAL_REQUEST_VIEW");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalChar)
                .HasColumnName("ARRIVAL_CHAR")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureChar)
                .HasColumnName("DEPARTURE_CHAR")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfStays)
                .HasColumnName("NO_OF_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.SpecialRequest)
                .IsRequired()
                .HasColumnName("SPECIAL_REQUEST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SpecialRequestDesc)
                .HasColumnName("SPECIAL_REQUEST_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SpecialRequestId)
                .HasColumnName("SPECIAL_REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
