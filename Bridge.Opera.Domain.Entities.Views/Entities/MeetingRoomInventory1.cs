namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MeetingRoomInventory1
{
    public decimal MriId { get; set; }
    public string Resort { get; set; }
    public string Room { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime? EventStart { get; set; }
    public DateTime? EventEnd { get; set; }
    public decimal? Attendees { get; set; }
    public string SharedYn { get; set; }
    public decimal ResvNameId { get; set; }
    public string ComboRoom { get; set; }
    public string DontMoveYn { get; set; }
    public string Status { get; set; }
    public decimal? EventId { get; set; }
    public string DeductInventory { get; set; }
    public string ShowdiaryYn { get; set; }
    public decimal BookId { get; set; }
    public string RoomResort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MeetingRoomInventory1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEETING_ROOM_INVENTORY");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ComboRoom)
                .HasColumnName("COMBO_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeductInventory)
                .HasColumnName("DEDUCT_INVENTORY")
                .IsUnicode(false);

            entity.Property(e => e.DontMoveYn)
                .HasColumnName("DONT_MOVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventEnd)
                .HasColumnName("EVENT_END")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventStart)
                .HasColumnName("EVENT_START")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MriId)
                .HasColumnName("MRI_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SharedYn)
                .HasColumnName("SHARED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShowdiaryYn)
                .HasColumnName("SHOWDIARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
