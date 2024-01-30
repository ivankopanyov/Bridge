namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ProfileProdStatistics
{
    public string? Resort { get; set; }
    public decimal? NameId { get; set; }
    public string? NameType { get; set; }
    public decimal? MasterNameId { get; set; }
    public DateTime? StayDate { get; set; }
    public decimal? StayMonth { get; set; }
    public decimal? StayYear { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? IndRoomNights { get; set; }
    public decimal? IndRoomRevenue { get; set; }
    public decimal? IndFoodRevenue { get; set; }
    public decimal? IndOtherRevenue { get; set; }
    public decimal? IndTotalRevenue { get; set; }
    public decimal? BlkRoomNights { get; set; }
    public decimal? BlkRoomRevenue { get; set; }
    public decimal? BlkFoodRevenue { get; set; }
    public decimal? BlkOtherRevenue { get; set; }
    public decimal? BlkTotalRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileProdStatistics>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PROFILE_PROD_STATISTICS");

            entity.Property(e => e.BlkFoodRevenue)
                .HasColumnName("BLK_FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkOtherRevenue)
                .HasColumnName("BLK_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkRoomNights)
                .HasColumnName("BLK_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkRoomRevenue)
                .HasColumnName("BLK_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkTotalRevenue)
                .HasColumnName("BLK_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IndFoodRevenue)
                .HasColumnName("IND_FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndOtherRevenue)
                .HasColumnName("IND_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRoomNights)
                .HasColumnName("IND_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRoomRevenue)
                .HasColumnName("IND_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndTotalRevenue)
                .HasColumnName("IND_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterNameId)
                .HasColumnName("MASTER_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StayMonth)
                .HasColumnName("STAY_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayYear)
                .HasColumnName("STAY_YEAR")
                .HasColumnType("NUMBER");
        });
	}
}
