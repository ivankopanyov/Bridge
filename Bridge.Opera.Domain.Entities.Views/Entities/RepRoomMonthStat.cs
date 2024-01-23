namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepRoomMonthStat
{
    public string Room { get; set; }
    public string RoomNo { get; set; }
    public DateTime? LastDayMonth { get; set; }
    public string RoomCategoryLabel { get; set; }
    public decimal? Arrival { get; set; }
    public decimal? Night { get; set; }
    public decimal? Rev { get; set; }
    public decimal? FixedCharges { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepRoomMonthStat>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_ROOM_MONTH_STAT");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FixedCharges)
                .HasColumnName("FIXED_CHARGES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastDayMonth)
                .HasColumnName("LAST_DAY_MONTH")
                .HasColumnType("DATE");

            entity.Property(e => e.Night)
                .HasColumnName("NIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rev)
                .HasColumnName("REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(45)
                .IsUnicode(false);
        });
	}
}
