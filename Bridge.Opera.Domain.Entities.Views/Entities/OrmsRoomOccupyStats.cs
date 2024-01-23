namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsRoomOccupyStats
{
    public string RoomCategory { get; set; }
    public decimal? Totalavailrooms { get; set; }
    public decimal? Physical { get; set; }
    public decimal? Logical { get; set; }
    public decimal? Phyoccnum { get; set; }
    public decimal? Logoccnum { get; set; }
    public decimal? Phyoccrate { get; set; }
    public decimal? Logoccrate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsRoomOccupyStats>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_ROOM_OCCUPY_STATS");

            entity.Property(e => e.Logical)
                .HasColumnName("LOGICAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Logoccnum)
                .HasColumnName("LOGOCCNUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Logoccrate)
                .HasColumnName("LOGOCCRATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Phyoccnum)
                .HasColumnName("PHYOCCNUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Phyoccrate)
                .HasColumnName("PHYOCCRATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Physical)
                .HasColumnName("PHYSICAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Totalavailrooms)
                .HasColumnName("TOTALAVAILROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
