namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AllotmentRoomtypes
{
    public string Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string RoomCategory { get; set; }
    public string Label { get; set; }
    public string ShortDescription { get; set; }
    public decimal? Priority { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentRoomtypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ALLOTMENT_ROOMTYPES");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
