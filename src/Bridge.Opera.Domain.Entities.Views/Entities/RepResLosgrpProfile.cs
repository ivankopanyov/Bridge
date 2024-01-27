namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepResLosgrpProfile
{
    public decimal? NameId { get; set; }
    public decimal? MasterNameId { get; set; }
    public DateTime? FirstOfMonth { get; set; }
    public decimal? LosTier { get; set; }
    public decimal? NoRooms { get; set; }
    public decimal? Persons { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? TotrevPerProfile { get; set; }
    public decimal? TotroomsPerProfile { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepResLosgrpProfile>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_RES_LOSGRP_PROFILE");

            entity.Property(e => e.FirstOfMonth)
                .HasColumnName("FIRST_OF_MONTH")
                .HasColumnType("DATE");

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LosTier)
                .HasColumnName("LOS_TIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterNameId)
                .HasColumnName("MASTER_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoRooms)
                .HasColumnName("NO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotrevPerProfile)
                .HasColumnName("TOTREV_PER_PROFILE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotroomsPerProfile)
                .HasColumnName("TOTROOMS_PER_PROFILE")
                .HasColumnType("NUMBER");
        });
	}
}
