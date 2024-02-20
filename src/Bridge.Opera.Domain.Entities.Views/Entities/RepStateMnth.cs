namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepStateMnth
{
    public decimal? RoomsMnth { get; set; }
    public decimal? PersonsMnth { get; set; }
    public decimal? RevenueMnth { get; set; }
    public string? State { get; set; }
    public string? ReservationDate { get; set; }
    public decimal? ResMnth { get; set; }
    public decimal? ResYr { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepStateMnth>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_STATE_MNTH");

            entity.Property(e => e.PersonsMnth)
                .HasColumnName("PERSONS_MNTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResMnth)
                .HasColumnName("RES_MNTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResYr)
                .HasColumnName("RES_YR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.RevenueMnth)
                .HasColumnName("REVENUE_MNTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsMnth)
                .HasColumnName("ROOMS_MNTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
