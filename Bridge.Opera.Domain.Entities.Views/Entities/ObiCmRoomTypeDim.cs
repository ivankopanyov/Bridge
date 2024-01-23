namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCmRoomTypeDim
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string RoomClass { get; set; }
    public string RoomClassDesc { get; set; }
    public string RoomCategoryCode { get; set; }
    public string RoomCategoryDesc { get; set; }
    public string RoomCategoryLabel { get; set; }
    public string ShortDescription { get; set; }
    public string RoomClassCent { get; set; }
    public decimal? OrderBy { get; set; }
    public string PseudoYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCmRoomTypeDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CM_ROOM_TYPE_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryCode)
                .HasColumnName("ROOM_CATEGORY_CODE")
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

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .IsUnicode(false);
        });
	}
}
