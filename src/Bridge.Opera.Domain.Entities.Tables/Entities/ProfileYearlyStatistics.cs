namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileYearlyStatistics
{
    public decimal NameId { get; set; }
    public string Resort { get; set; }
    public string NameType { get; set; }
    public string LocalCurrency { get; set; }
    public decimal StayYear { get; set; }
    public decimal? NumberStays { get; set; }
    public decimal? NumberNights { get; set; }
    public decimal? NumberCancels { get; set; }
    public decimal? NumberNoShows { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? RoomRevenueTax { get; set; }
    public decimal? FbRevenueTax { get; set; }
    public decimal? TotalRevenueTax { get; set; }
    public decimal? OtherRevenueTax { get; set; }
    public decimal? GrpNumberStays { get; set; }
    public decimal? GrpNumberNights { get; set; }
    public decimal? GrpNumberCancels { get; set; }
    public decimal? GrpNumberNoShows { get; set; }
    public decimal? GrpRoomRevenue { get; set; }
    public decimal? GrpFbRevenue { get; set; }
    public decimal? GrpTotalRevenue { get; set; }
    public decimal? GrpOtherRevenue { get; set; }
    public decimal? GrpRoomRevenueTax { get; set; }
    public decimal? GrpFbRevenueTax { get; set; }
    public decimal? GrpTotalRevenueTax { get; set; }
    public decimal? GrpOtherRevenueTax { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string CentralCurrencyCode { get; set; }
    public decimal? CcRoomRevenue { get; set; }
    public decimal? CcFbRevenue { get; set; }
    public decimal? CcTotalRevenue { get; set; }
    public decimal? CcMiscRevenue { get; set; }
    public decimal? CcOtherRevenue { get; set; }
    public decimal? CcRoomRevenueTax { get; set; }
    public decimal? CcFbRevenueTax { get; set; }
    public decimal? CcTotalRevenueTax { get; set; }
    public decimal? CcMiscRevenueTax { get; set; }
    public decimal? CcOtherRevenueTax { get; set; }
    public decimal? CcGrpRoomRevenue { get; set; }
    public decimal? CcGrpFbRevenue { get; set; }
    public decimal? CcGrpTotalRevenue { get; set; }
    public decimal? CcGrpMiscRevenue { get; set; }
    public decimal? CcGrpOtherRevenue { get; set; }
    public decimal? CcGrpRoomRevenueTax { get; set; }
    public decimal? CcGrpFbRevenueTax { get; set; }
    public decimal? CcGrpMiscRevenueTax { get; set; }
    public decimal? CcGrpOtherRevenueTax { get; set; }
    public decimal? CcGrpTotalRevenueTax { get; set; }
    public string StayedBooked { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileYearlyStatistics>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PROFILE_YEARLY_STATISTICS");

            entity.HasIndex(e => new { e.StayYear, e.StayedBooked })
                .HasName("PROF_YR_STAT_YEAR_IDX");

            entity.HasIndex(e => new { e.NameType, e.StayYear, e.StayedBooked })
                .HasName("PROF_YR_STAT_NT_IDX");

            entity.HasIndex(e => new { e.Resort, e.StayYear, e.StayedBooked })
                .HasName("PROF_YR_STAT_RESORT_IDX");

            entity.HasIndex(e => new { e.NameId, e.Resort, e.StayYear, e.StayedBooked })
                .HasName("PROF_YR_STAT_UK")
                .IsUnique();

            entity.Property(e => e.CcFbRevenue)
                .HasColumnName("CC_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcFbRevenueTax)
                .HasColumnName("CC_FB_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpFbRevenue)
                .HasColumnName("CC_GRP_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpFbRevenueTax)
                .HasColumnName("CC_GRP_FB_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpMiscRevenue)
                .HasColumnName("CC_GRP_MISC_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpMiscRevenueTax)
                .HasColumnName("CC_GRP_MISC_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpOtherRevenue)
                .HasColumnName("CC_GRP_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpOtherRevenueTax)
                .HasColumnName("CC_GRP_OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpRoomRevenue)
                .HasColumnName("CC_GRP_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpRoomRevenueTax)
                .HasColumnName("CC_GRP_ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpTotalRevenue)
                .HasColumnName("CC_GRP_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpTotalRevenueTax)
                .HasColumnName("CC_GRP_TOTAL_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcMiscRevenue)
                .HasColumnName("CC_MISC_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcMiscRevenueTax)
                .HasColumnName("CC_MISC_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcOtherRevenue)
                .HasColumnName("CC_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcOtherRevenueTax)
                .HasColumnName("CC_OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcRoomRevenue)
                .HasColumnName("CC_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcRoomRevenueTax)
                .HasColumnName("CC_ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTotalRevenue)
                .HasColumnName("CC_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTotalRevenueTax)
                .HasColumnName("CC_TOTAL_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CentralCurrencyCode)
                .HasColumnName("CENTRAL_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevenueTax)
                .HasColumnName("FB_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpFbRevenue)
                .HasColumnName("GRP_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpFbRevenueTax)
                .HasColumnName("GRP_FB_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpNumberCancels)
                .HasColumnName("GRP_NUMBER_CANCELS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpNumberNights)
                .HasColumnName("GRP_NUMBER_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpNumberNoShows)
                .HasColumnName("GRP_NUMBER_NO_SHOWS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpNumberStays)
                .HasColumnName("GRP_NUMBER_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpOtherRevenue)
                .HasColumnName("GRP_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpOtherRevenueTax)
                .HasColumnName("GRP_OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpRoomRevenue)
                .HasColumnName("GRP_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpRoomRevenueTax)
                .HasColumnName("GRP_ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpTotalRevenue)
                .HasColumnName("GRP_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpTotalRevenueTax)
                .HasColumnName("GRP_TOTAL_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocalCurrency)
                .IsRequired()
                .HasColumnName("LOCAL_CURRENCY")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NumberCancels)
                .HasColumnName("NUMBER_CANCELS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberNights)
                .HasColumnName("NUMBER_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberNoShows)
                .HasColumnName("NUMBER_NO_SHOWS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberStays)
                .HasColumnName("NUMBER_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueTax)
                .HasColumnName("OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueTax)
                .HasColumnName("ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayYear)
                .HasColumnName("STAY_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayedBooked)
                .HasColumnName("STAYED_BOOKED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueTax)
                .HasColumnName("TOTAL_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
