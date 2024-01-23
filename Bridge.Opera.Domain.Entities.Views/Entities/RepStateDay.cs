namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepStateDay
{
    public decimal? RoomsDay { get; set; }
    public decimal? PersonsDay { get; set; }
    public decimal? RevenueDay { get; set; }
    public string State { get; set; }
    public DateTime ReservationDate { get; set; }
    public decimal? ResMnth { get; set; }
    public decimal? ResYr { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepStateDay>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_STATE_DAY");

            entity.Property(e => e.PersonsDay)
                .HasColumnName("PERSONS_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResMnth)
                .HasColumnName("RES_MNTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResYr)
                .HasColumnName("RES_YR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RevenueDay)
                .HasColumnName("REVENUE_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsDay)
                .HasColumnName("ROOMS_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
