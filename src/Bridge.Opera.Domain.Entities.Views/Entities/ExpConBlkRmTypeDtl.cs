namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConBlkRmTypeDtl
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? RoomTypeDtlStartDateNum { get; set; }
    public decimal? RoomTypeDtlEndDateNum { get; set; }
    public decimal? BlkdRooms { get; set; }
    public decimal? SellLimit { get; set; }
    public decimal? Released { get; set; }
    public string? RoomCategory { get; set; }
    public DateTime? RoomTypeDtlStartDate { get; set; }
    public DateTime? RoomTypeDtlEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConBlkRmTypeDtl>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_BLK_RM_TYPE_DTL");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkdRooms)
                .HasColumnName("BLKD_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Released)
                .HasColumnName("RELEASED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomTypeDtlEndDate)
                .HasColumnName("ROOM_TYPE_DTL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RoomTypeDtlEndDateNum)
                .HasColumnName("ROOM_TYPE_DTL_END_DATE_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomTypeDtlStartDate)
                .HasColumnName("ROOM_TYPE_DTL_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RoomTypeDtlStartDateNum)
                .HasColumnName("ROOM_TYPE_DTL_START_DATE_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SellLimit)
                .HasColumnName("SELL_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
