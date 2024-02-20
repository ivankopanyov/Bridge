namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RateQueryRoomTypeView
{
    public string? RoomCategory { get; set; }
    public string? Label { get; set; }
    public string? ShortDescription { get; set; }
    public string? LongDescription { get; set; }
    public string? Available { get; set; }
    public string? AvailableLevel { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateQueryRoomTypeView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RATE_QUERY_ROOM_TYPE_VIEW");

            entity.Property(e => e.Available)
                .HasColumnName("AVAILABLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AvailableLevel)
                .HasColumnName("AVAILABLE_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LongDescription)
                .HasColumnName("LONG_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(75)
                .IsUnicode(false);
        });
	}
}
