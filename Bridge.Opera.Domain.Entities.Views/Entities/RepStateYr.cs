namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepStateYr
{
    public decimal? RoomsYr { get; set; }
    public decimal? PersonsYr { get; set; }
    public decimal? RevenueYr { get; set; }
    public string State { get; set; }
    public string ReservationDate { get; set; }
    public decimal? ResYr { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepStateYr>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_STATE_YR");

            entity.Property(e => e.PersonsYr)
                .HasColumnName("PERSONS_YR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResYr)
                .HasColumnName("RES_YR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.RevenueYr)
                .HasColumnName("REVENUE_YR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsYr)
                .HasColumnName("ROOMS_YR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
