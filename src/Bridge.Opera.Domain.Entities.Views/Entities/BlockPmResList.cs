namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BlockPmResList
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? RoomResort { get; set; }
    public string? ComputedResvStatus { get; set; }
    public string? ResvStatus { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string? ConfirmationNo { get; set; }
    public decimal? EventId { get; set; }
    public decimal? BlockId { get; set; }
    public string? BlockResort { get; set; }
    public string? GuestName { get; set; }
    public string? GuestFirstName { get; set; }
    public decimal? Adults { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public decimal? ShareAmount { get; set; }
    public string? PostingAllowedYn { get; set; }
    public string? Room { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BlockPmResList>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BLOCK_PM_RES_LIST");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockId)
                .HasColumnName("BLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockResort)
                .HasColumnName("BLOCK_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PostingAllowedYn)
                .HasColumnName("POSTING_ALLOWED_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.RoomResort)
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShareAmount)
                .HasColumnName("SHARE_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}
