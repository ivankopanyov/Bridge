namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QroomsStatView
{
    public decimal? QuerySort { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public string? ShortDescription { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? TotalCount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QroomsStatView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QROOMS_STAT_VIEW");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QuerySort)
                .HasColumnName("QUERY_SORT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TotalCount)
                .HasColumnName("TOTAL_COUNT")
                .HasColumnType("NUMBER");
        });
	}
}
