namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResortRooms
{
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public string? RoomCategory { get; set; }
    public string? Label { get; set; }
    public string? RoomClass { get; set; }
    public string? Description { get; set; }
    public string? RoomStatus { get; set; }
    public string? Floor { get; set; }
    public string? Feature { get; set; }
    public string? FoStatus { get; set; }
    public string? MeetingroomYn { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? OrderBy2 { get; set; }
    public decimal? OrderBy3 { get; set; }
    public decimal? OrderBy4 { get; set; }
    public decimal? OrderBy5 { get; set; }
    public string? PseudoYn { get; set; }
    public string? RoomCategoryPseudoYn { get; set; }
    public decimal? RoomReservationStatus { get; set; }
    public decimal? RoomImageId { get; set; }
    public decimal? RoomCategoryImageId { get; set; }
    public decimal? NoOfBeds { get; set; }
    public string? MeetingroomType { get; set; }
    public string? Building { get; set; }
    public string? ComboYn { get; set; }
    public string? ComboElementYn { get; set; }
    public string? ShareableYn { get; set; }
    public string? ForceAlternateYn { get; set; }
    public string? WebBookingYn { get; set; }
    public string? DiaryName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortRooms>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESORT_ROOMS");

            entity.Property(e => e.Building)
                .HasColumnName("BUILDING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ComboElementYn)
                .HasColumnName("COMBO_ELEMENT_YN")
                .IsUnicode(false);

            entity.Property(e => e.ComboYn)
                .HasColumnName("COMBO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DiaryName)
                .HasColumnName("DIARY_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Feature)
                .HasColumnName("FEATURE")
                .IsUnicode(false);

            entity.Property(e => e.Floor)
                .HasColumnName("FLOOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FoStatus)
                .HasColumnName("FO_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.ForceAlternateYn)
                .HasColumnName("FORCE_ALTERNATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MeetingroomType)
                .HasColumnName("MEETINGROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MeetingroomYn)
                .HasColumnName("MEETINGROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NoOfBeds)
                .HasColumnName("NO_OF_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy2)
                .HasColumnName("ORDER_BY2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy3)
                .HasColumnName("ORDER_BY3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy4)
                .HasColumnName("ORDER_BY4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy5)
                .HasColumnName("ORDER_BY5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryImageId)
                .HasColumnName("ROOM_CATEGORY_IMAGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategoryPseudoYn)
                .HasColumnName("ROOM_CATEGORY_PSEUDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .IsRequired()
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomImageId)
                .HasColumnName("ROOM_IMAGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomReservationStatus)
                .HasColumnName("ROOM_RESERVATION_STATUS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomStatus)
                .HasColumnName("ROOM_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.ShareableYn)
                .HasColumnName("SHAREABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
