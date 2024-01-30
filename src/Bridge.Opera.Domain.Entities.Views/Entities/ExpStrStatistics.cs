namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpStrStatistics
{
    public decimal? ExportId { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? ExpHotelCode { get; set; }
    public string? ResortName { get; set; }
    public decimal? PhysicalRooms { get; set; }
    public decimal? TotalRooms { get; set; }
    public decimal? TotalCompRooms { get; set; }
    public decimal? TotalRoomRevenue { get; set; }
    public decimal? TotalFbRevenue { get; set; }
    public decimal? TotalOtherRoomRevenue { get; set; }
    public decimal? TotalOtherRevenue { get; set; }
    public decimal? TransientRooms { get; set; }
    public decimal? TransientRoomRevenue { get; set; }
    public decimal? GroupRooms { get; set; }
    public decimal? GroupRoomRevenue { get; set; }
    public decimal? ContractRooms { get; set; }
    public decimal? ContractRoomRevenue { get; set; }
    public string? IsoCurrencyCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpStrStatistics>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_STR_STATISTICS");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ContractRoomRevenue)
                .HasColumnName("CONTRACT_ROOM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ContractRooms)
                .HasColumnName("CONTRACT_ROOMS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpHotelCode)
                .HasColumnName("EXP_HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GroupRoomRevenue)
                .HasColumnName("GROUP_ROOM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GroupRooms)
                .HasColumnName("GROUP_ROOMS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IsoCurrencyCode)
                .HasColumnName("ISO_CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PhysicalRooms)
                .HasColumnName("PHYSICAL_ROOMS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResortName)
                .HasColumnName("RESORT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalCompRooms)
                .HasColumnName("TOTAL_COMP_ROOMS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalFbRevenue)
                .HasColumnName("TOTAL_FB_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalOtherRevenue)
                .HasColumnName("TOTAL_OTHER_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalOtherRoomRevenue)
                .HasColumnName("TOTAL_OTHER_ROOM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalRoomRevenue)
                .HasColumnName("TOTAL_ROOM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransientRoomRevenue)
                .HasColumnName("TRANSIENT_ROOM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransientRooms)
                .HasColumnName("TRANSIENT_ROOMS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
