namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpCountrystatsView
{
    public string Resort { get; set; }
    public string MonthYear { get; set; }
    public string StatisticCode { get; set; }
    public decimal? StayRooms { get; set; }
    public decimal? StayPersons { get; set; }
    public decimal? ArrPersons { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? StayPersonsK { get; set; }
    public decimal? StayPersonsY { get; set; }
    public decimal? StayPersonsF { get; set; }
    public decimal? LocalArrPersons { get; set; }
    public decimal? ForeignArrPersons { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpCountrystatsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_COUNTRYSTATS_VIEW");

            entity.Property(e => e.ArrPersons)
                .HasColumnName("ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForeignArrPersons)
                .HasColumnName("FOREIGN_ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocalArrPersons)
                .HasColumnName("LOCAL_ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthYear)
                .HasColumnName("MONTH_YEAR")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatisticCode)
                .HasColumnName("STATISTIC_CODE")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.StayPersons)
                .HasColumnName("STAY_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayPersonsF)
                .HasColumnName("STAY_PERSONS_F")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayPersonsK)
                .HasColumnName("STAY_PERSONS_K")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayPersonsY)
                .HasColumnName("STAY_PERSONS_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRooms)
                .HasColumnName("STAY_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
