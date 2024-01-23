namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpNationalityStats
{
    public DateTime? BusinessDate { get; set; }
    public string Nationality { get; set; }
    public string Description { get; set; }
    public decimal? NoOfRooms { get; set; }
    public decimal? NoOfAdults { get; set; }
    public decimal? NoOfChildren { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? ArrivalRooms { get; set; }
    public decimal? DepartRooms { get; set; }
    public decimal? DepartPersons { get; set; }
    public decimal? ArrivalPersons { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpNationalityStats>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_NATIONALITY_STATS");

            entity.Property(e => e.ArrivalPersons)
                .HasColumnName("ARRIVAL_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalRooms)
                .HasColumnName("ARRIVAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartPersons)
                .HasColumnName("DEPART_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartRooms)
                .HasColumnName("DEPART_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoOfAdults)
                .HasColumnName("NO_OF_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfChildren)
                .HasColumnName("NO_OF_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}
