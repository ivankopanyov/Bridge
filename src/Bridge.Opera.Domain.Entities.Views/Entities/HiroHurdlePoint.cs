namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HiroHurdlePoint
{
    public DateTime HurdleDate { get; set; }
    public string CharHurdleDate { get; set; }
    public string ProductClass { get; set; }
    public decimal? HurdlePoint { get; set; }
    public decimal? SellToCapacity { get; set; }
    public decimal? TotalRoomsAvailable { get; set; }
    public decimal? IndivudualRoomSold { get; set; }
    public decimal? GroupRoomSold { get; set; }
    public decimal? Delta { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HiroHurdlePoint>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HIRO_HURDLE_POINT");

            entity.Property(e => e.CharHurdleDate)
                .HasColumnName("CHAR_HURDLE_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Delta)
                .HasColumnName("DELTA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupRoomSold)
                .HasColumnName("GROUP_ROOM_SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HurdleDate)
                .HasColumnName("HURDLE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HurdlePoint)
                .HasColumnName("HURDLE_POINT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndivudualRoomSold)
                .HasColumnName("INDIVUDUAL_ROOM_SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProductClass)
                .IsRequired()
                .HasColumnName("PRODUCT_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellToCapacity)
                .HasColumnName("SELL_TO_CAPACITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomsAvailable)
                .HasColumnName("TOTAL_ROOMS_AVAILABLE")
                .HasColumnType("NUMBER");
        });
	}
}
