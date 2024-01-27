namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpAllGroupResvDay
{
    public DateTime? BusinessDate { get; set; }
    public string GroupName { get; set; }
    public decimal? NoOfRooms { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? Sequence { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpAllGroupResvDay>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_ALL_GROUP_RESV_DAY");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
                .HasColumnType("NUMBER");
        });
	}
}
