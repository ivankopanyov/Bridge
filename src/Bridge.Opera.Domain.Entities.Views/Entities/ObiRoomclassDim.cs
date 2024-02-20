namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRoomclassDim
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomClassDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string? ResortId { get; set; }
    public string? RoomClassKey { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRoomclassDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ROOMCLASS_DIM");

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

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .IsUnicode(false);

            entity.Property(e => e.RoomClassDesc)
                .HasColumnName("ROOM_CLASS_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RoomClassKey)
                .HasColumnName("ROOM_CLASS_KEY")
                .IsUnicode(false);
        });
	}
}
