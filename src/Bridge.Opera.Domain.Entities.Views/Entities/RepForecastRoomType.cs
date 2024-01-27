namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepForecastRoomType
{
    public DateTime? ConsideredDate { get; set; }
    public string DayDesc { get; set; }
    public string DayDescription { get; set; }
    public string RoomCategory { get; set; }
    public string Description { get; set; }
    public decimal? Avialability { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepForecastRoomType>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_FORECAST_ROOM_TYPE");

            entity.Property(e => e.Avialability)
                .HasColumnName("AVIALABILITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DayDesc)
                .HasColumnName("DAY_DESC")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.DayDescription)
                .HasColumnName("DAY_DESCRIPTION")
                .HasMaxLength(27)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
