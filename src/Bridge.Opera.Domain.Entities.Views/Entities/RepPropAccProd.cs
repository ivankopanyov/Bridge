namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepPropAccProd
{
    public decimal? NameId { get; set; }
    public string? Resort { get; set; }
    public decimal? RoomNights { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepPropAccProd>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_PROP_ACC_PROD");

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}
