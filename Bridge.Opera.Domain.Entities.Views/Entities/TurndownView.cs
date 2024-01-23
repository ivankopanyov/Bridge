namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TurndownView
{
    public string Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string FullGuestName { get; set; }
    public string ResvStatus { get; set; }
    public string ComputedResvStatus { get; set; }
    public string Room { get; set; }
    public string RoomClass { get; set; }
    public string RoomCategory { get; set; }
    public string RoomCategoryLabel { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string TurndownStatus { get; set; }
    public string TurndownStatusDesc { get; set; }
    public string RoomStatus { get; set; }
    public string RoomStatusDesc { get; set; }
    public string SharedYn { get; set; }
    public string DisplayResvStatus { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string Vip { get; set; }
    public string ArrivalTime { get; set; }
    public string DepartureTime { get; set; }
    public string RoomInstructions { get; set; }
    public string TurndownYn { get; set; }
    public decimal? ShareId { get; set; }
    public string HkSectionCode { get; set; }
    public string HkEveningSection { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TurndownView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TURNDOWN_VIEW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalTime)
                .HasColumnName("ARRIVAL_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepartureTime)
                .HasColumnName("DEPARTURE_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.DisplayResvStatus)
                .HasColumnName("DISPLAY_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FullGuestName)
                .HasColumnName("FULL_GUEST_NAME")
                .HasMaxLength(162)
                .IsUnicode(false);

            entity.Property(e => e.HkEveningSection)
                .HasColumnName("HK_EVENING_SECTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HkSectionCode)
                .HasColumnName("HK_SECTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomInstructions)
                .HasColumnName("ROOM_INSTRUCTIONS")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.RoomStatus)
                .HasColumnName("ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomStatusDesc)
                .HasColumnName("ROOM_STATUS_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ShareId)
                .HasColumnName("SHARE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SharedYn)
                .HasColumnName("SHARED_YN")
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.TurndownStatus)
                .HasColumnName("TURNDOWN_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.TurndownStatusDesc)
                .HasColumnName("TURNDOWN_STATUS_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TurndownYn)
                .HasColumnName("TURNDOWN_YN")
                .IsUnicode(false);

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
