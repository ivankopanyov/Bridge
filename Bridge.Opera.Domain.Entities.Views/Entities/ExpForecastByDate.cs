namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpForecastByDate
{
    public string PropertyCode { get; set; }
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
    public string Code1 { get; set; }
    public decimal? F1 { get; set; }
    public string Code2 { get; set; }
    public decimal? F2 { get; set; }
    public string Code3 { get; set; }
    public decimal? F3 { get; set; }
    public string Code4 { get; set; }
    public decimal? F4 { get; set; }
    public string Code5 { get; set; }
    public decimal? F5 { get; set; }
    public string Code6 { get; set; }
    public decimal? F6 { get; set; }
    public string Code7 { get; set; }
    public decimal? F7 { get; set; }
    public string Code8 { get; set; }
    public decimal? F8 { get; set; }
    public string Code9 { get; set; }
    public decimal? F9 { get; set; }
    public string Code10 { get; set; }
    public decimal? F10 { get; set; }
    public decimal? DefRoomRevenue { get; set; }
    public decimal? GroupDefRoomRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpForecastByDate>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_FORECAST_BY_DATE");

            entity.Property(e => e.ArrivalPerson)
                .HasColumnName("ARRIVAL_PERSON")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalRoom)
                .HasColumnName("ARRIVAL_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Code1)
                .HasColumnName("CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code10)
                .HasColumnName("CODE10")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code2)
                .HasColumnName("CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code3)
                .HasColumnName("CODE3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code4)
                .HasColumnName("CODE4")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code5)
                .HasColumnName("CODE5")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code6)
                .HasColumnName("CODE6")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code7)
                .HasColumnName("CODE7")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code8)
                .HasColumnName("CODE8")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code9)
                .HasColumnName("CODE9")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DefBlocks)
                .HasColumnName("DEF_BLOCKS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefRoomRevenue)
                .HasColumnName("DEF_ROOM_REVENUE")
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

            entity.Property(e => e.F1).HasColumnType("NUMBER");

            entity.Property(e => e.F10).HasColumnType("NUMBER");

            entity.Property(e => e.F2).HasColumnType("NUMBER");

            entity.Property(e => e.F3).HasColumnType("NUMBER");

            entity.Property(e => e.F4).HasColumnType("NUMBER");

            entity.Property(e => e.F5).HasColumnType("NUMBER");

            entity.Property(e => e.F6).HasColumnType("NUMBER");

            entity.Property(e => e.F7).HasColumnType("NUMBER");

            entity.Property(e => e.F8).HasColumnType("NUMBER");

            entity.Property(e => e.F9).HasColumnType("NUMBER");

            entity.Property(e => e.GroupDefRoomRevenue)
                .HasColumnName("GROUP_DEF_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutOfOrder)
                .HasColumnName("OUT_OF_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutOfService)
                .HasColumnName("OUT_OF_SERVICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .IsUnicode(false);

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
