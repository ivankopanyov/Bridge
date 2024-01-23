namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AvailabilityView
{
    public DateTime? ConsideredDate { get; set; }
    public decimal? TotalRooms { get; set; }
    public decimal? OutOfOrder { get; set; }
    public decimal? OutOfService { get; set; }
    public string Event { get; set; }
    public decimal? DefBlocks { get; set; }
    public decimal? TotGrpRooms { get; set; }
    public decimal? TentBlocks { get; set; }
    public decimal? DefiniteRoom { get; set; }
    public decimal? DefiniteAdult { get; set; }
    public decimal? DefiniteChildren { get; set; }
    public decimal? TentativeRoom { get; set; }
    public decimal? ArrivalRoom { get; set; }
    public decimal? ArrivalPerson { get; set; }
    public decimal? DepartureRoom { get; set; }
    public decimal? DeparturePerson { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AvailabilityView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AVAILABILITY_VIEW");

            entity.Property(e => e.ArrivalPerson)
                .HasColumnName("ARRIVAL_PERSON")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalRoom)
                .HasColumnName("ARRIVAL_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DefBlocks)
                .HasColumnName("DEF_BLOCKS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefiniteAdult)
                .HasColumnName("DEFINITE_ADULT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefiniteChildren)
                .HasColumnName("DEFINITE_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefiniteRoom)
                .HasColumnName("DEFINITE_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeparturePerson)
                .HasColumnName("DEPARTURE_PERSON")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureRoom)
                .HasColumnName("DEPARTURE_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Event)
                .HasColumnName("EVENT")
                .IsUnicode(false);

            entity.Property(e => e.OutOfOrder)
                .HasColumnName("OUT_OF_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutOfService)
                .HasColumnName("OUT_OF_SERVICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TentBlocks)
                .HasColumnName("TENT_BLOCKS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TentativeRoom)
                .HasColumnName("TENTATIVE_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotGrpRooms)
                .HasColumnName("TOT_GRP_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
