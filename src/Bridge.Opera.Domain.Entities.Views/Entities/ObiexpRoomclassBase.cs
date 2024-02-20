namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpRoomclassBase
{
    public string? RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string? Resort { get; set; }
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
		modelBuilder.Entity<ObiexpRoomclassBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_ROOMCLASS_BASE");

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

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .IsRequired()
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .IsRequired()
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClassDesc)
                .HasColumnName("ROOM_CLASS_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomClassKey)
                .HasColumnName("ROOM_CLASS_KEY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(41)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");
        });
	}
}
