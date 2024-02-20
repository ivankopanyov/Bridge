namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BookingStatusChanges
{
    public decimal? ActionId { get; set; }
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? PriorStatus { get; set; }
    public string? CurrentStatus { get; set; }
    public decimal? TotalRooms { get; set; }
    public decimal? AvgRate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public byte? LaptopChange { get; set; }
    public decimal? NetRoomRevenue { get; set; }
    public decimal? NetFbRevenue { get; set; }
    public decimal? NetOtherRevenue { get; set; }
    public decimal? NetNonRevenue { get; set; }
    public decimal? TaxRoomRevenue { get; set; }
    public decimal? TaxFbRevenue { get; set; }
    public decimal? TaxOtherRevenue { get; set; }
    public decimal? TaxNonRevenue { get; set; }
    public decimal? BiAudioVisualRev { get; set; }
    public decimal? BiBeverageRev { get; set; }
    public decimal? BiFoodRev { get; set; }
    public decimal? BiOtherRev { get; set; }
    public decimal? BiRentalRev { get; set; }
    public decimal? BiGroupRev1 { get; set; }
    public decimal? BiGroupRev2 { get; set; }
    public decimal? BiGroupRev3 { get; set; }
    public decimal? BiGroupRev4 { get; set; }
    public decimal? BiGroupRev5 { get; set; }
    public string? CentralCurrencyCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookingStatusChanges>(entity =>
        {
            entity.HasKey(e => e.ActionId)
                .HasName("BOOKING_STATUS_CHANGES_PK");

            entity.ToTable("BOOKING_STATUS_CHANGES");

            entity.HasIndex(e => e.CurrentStatus)
                .HasName("BSC_STATUS_IDX");

            entity.HasIndex(e => e.InsertDate)
                .HasName("BSC_DATE_IDX");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort, e.InsertDate })
                .HasName("BSC_AH_ID_IDX");

            entity.HasIndex(e => new { e.Resort, e.CurrentStatus, e.InsertDate })
                .HasName("BSC_RES_STATUS_IDX");

            entity.HasIndex(e => new { e.Resort, e.InsertDate, e.CurrentStatus })
                .HasName("BSC_RESORT_IDX");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AvgRate)
                .HasColumnName("AVG_RATE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BiAudioVisualRev)
                .HasColumnName("BI_AUDIO_VISUAL_REV")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BiBeverageRev)
                .HasColumnName("BI_BEVERAGE_REV")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BiFoodRev)
                .HasColumnName("BI_FOOD_REV")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BiGroupRev1)
                .HasColumnName("BI_GROUP_REV1")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BiGroupRev2)
                .HasColumnName("BI_GROUP_REV2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BiGroupRev3)
                .HasColumnName("BI_GROUP_REV3")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BiGroupRev4)
                .HasColumnName("BI_GROUP_REV4")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BiGroupRev5)
                .HasColumnName("BI_GROUP_REV5")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BiOtherRev)
                .HasColumnName("BI_OTHER_REV")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BiRentalRev)
                .HasColumnName("BI_RENTAL_REV")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CentralCurrencyCode)
                .HasColumnName("CENTRAL_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrentStatus)
                .HasColumnName("CURRENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.NetFbRevenue)
                .HasColumnName("NET_FB_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NetNonRevenue)
                .HasColumnName("NET_NON_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NetOtherRevenue)
                .HasColumnName("NET_OTHER_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NetRoomRevenue)
                .HasColumnName("NET_ROOM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PriorStatus)
                .HasColumnName("PRIOR_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxFbRevenue)
                .HasColumnName("TAX_FB_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxNonRevenue)
                .HasColumnName("TAX_NON_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxOtherRevenue)
                .HasColumnName("TAX_OTHER_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxRoomRevenue)
                .HasColumnName("TAX_ROOM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
