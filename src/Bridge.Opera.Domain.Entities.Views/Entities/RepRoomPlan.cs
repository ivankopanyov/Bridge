namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepRoomPlan
{
    public string? Room { get; set; }
    public string? RoomNo { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomStatus { get; set; }
    public string? Resort { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public string? Description { get; set; }
    public string? Guest { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepRoomPlan>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_ROOM_PLAN");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Guest)
                .HasColumnName("GUEST")
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

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(45)
                .IsUnicode(false);

            entity.Property(e => e.RoomStatus)
                .IsRequired()
                .HasColumnName("ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
