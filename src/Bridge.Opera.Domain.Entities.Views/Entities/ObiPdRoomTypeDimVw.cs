namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiPdRoomTypeDimVw
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomClassDesc { get; set; }
    public string? RoomCategoryCode { get; set; }
    public string? RoomCategoryDesc { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public string? ShortDescription { get; set; }
    public string? RoomClassCent { get; set; }
    public decimal? OrderBy { get; set; }
    public string? PseudoYn { get; set; }
    public string? ResortId { get; set; }
    public string? RoomClassKey { get; set; }
    public string? RoomCategoryCodeKey { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiPdRoomTypeDimVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PD_ROOM_TYPE_DIM_VW");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryCode)
                .HasColumnName("ROOM_CATEGORY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryCodeKey)
                .HasColumnName("ROOM_CATEGORY_CODE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryDesc)
                .HasColumnName("ROOM_CATEGORY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .IsUnicode(false);

            entity.Property(e => e.RoomClassCent)
                .HasColumnName("ROOM_CLASS_CENT")
                .IsUnicode(false);

            entity.Property(e => e.RoomClassDesc)
                .HasColumnName("ROOM_CLASS_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RoomClassKey)
                .HasColumnName("ROOM_CLASS_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .IsUnicode(false);
        });
	}
}
