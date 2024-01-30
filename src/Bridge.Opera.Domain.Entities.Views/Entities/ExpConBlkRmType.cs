namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConBlkRmType
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? RoomTypeStartDateNum { get; set; }
    public decimal? RoomTypeEndDateNum { get; set; }
    public string? RoomTypeLabel { get; set; }
    public string? RoomCategory { get; set; }
    public DateTime? RoomTypeStartDate { get; set; }
    public DateTime? RoomTypeEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConBlkRmType>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_BLK_RM_TYPE");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomTypeEndDate)
                .HasColumnName("ROOM_TYPE_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RoomTypeEndDateNum)
                .HasColumnName("ROOM_TYPE_END_DATE_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomTypeLabel)
                .HasColumnName("ROOM_TYPE_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomTypeStartDate)
                .HasColumnName("ROOM_TYPE_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RoomTypeStartDateNum)
                .HasColumnName("ROOM_TYPE_START_DATE_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
