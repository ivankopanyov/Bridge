namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofCountrystatsRecord
{
    public string? Resort { get; set; }
    public DateTime? TrxDate { get; set; }
    public string? StatisticCode { get; set; }
    public string? CountryCode { get; set; }
    public decimal? NoOfRooms { get; set; }
    public decimal? NoOfGuests { get; set; }
    public decimal? ArrPersons { get; set; }
    public decimal? NetRoomRevAmount { get; set; }
    public decimal? RoomTaxAmount { get; set; }
    public decimal? NetFoodRevAmount { get; set; }
    public decimal? FoodTaxAmount { get; set; }
    public decimal? NetOtherRevAmount { get; set; }
    public decimal? OtherTaxAmount { get; set; }
    public decimal? NetTotalRevAmount { get; set; }
    public decimal? TotalTaxAmount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofCountrystatsRecord>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_COUNTRYSTATS_RECORD");

            entity.Property(e => e.ArrPersons)
                .HasColumnName("ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.FoodTaxAmount)
                .HasColumnName("FOOD_TAX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetFoodRevAmount)
                .HasColumnName("NET_FOOD_REV_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetOtherRevAmount)
                .HasColumnName("NET_OTHER_REV_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetRoomRevAmount)
                .HasColumnName("NET_ROOM_REV_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetTotalRevAmount)
                .HasColumnName("NET_TOTAL_REV_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfGuests)
                .HasColumnName("NO_OF_GUESTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherTaxAmount)
                .HasColumnName("OTHER_TAX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.RoomTaxAmount)
                .HasColumnName("ROOM_TAX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatisticCode)
                .HasColumnName("STATISTIC_CODE")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.TotalTaxAmount)
                .HasColumnName("TOTAL_TAX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
