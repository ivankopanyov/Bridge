namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepChannelView
{
    public string? Channel { get; set; }
    public string? Description { get; set; }
    public decimal? MonthYear { get; set; }
    public decimal? RoomsRev { get; set; }
    public decimal? Rooms { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepChannelView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_CHANNEL_VIEW");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MonthYear)
                .HasColumnName("MONTH_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsRev)
                .HasColumnName("ROOMS_REV")
                .HasColumnType("NUMBER");
        });
	}
}
