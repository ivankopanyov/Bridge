namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepStatMarkSeg
{
    public string? RoomClass { get; set; }
    public string? MarketCode { get; set; }
    public string? ParentMarketCode { get; set; }
    public string? Description { get; set; }
    public decimal? RoomsDay { get; set; }
    public decimal? GuestDay { get; set; }
    public decimal? SingleOccDay { get; set; }
    public decimal? MultiOccDay { get; set; }
    public decimal? TotalRevDay { get; set; }
    public decimal? RoomRevDay { get; set; }
    public decimal? FbRevDay { get; set; }
    public decimal? OtherRevDay { get; set; }
    public decimal? PkgRevDay { get; set; }
    public decimal? PkgRoomRevDay { get; set; }
    public decimal? PkgFbRevDay { get; set; }
    public decimal? PkgOtherRevDay { get; set; }
    public decimal? TotalTaxDay { get; set; }
    public decimal? RoomTaxDay { get; set; }
    public decimal? FbTaxDay { get; set; }
    public decimal? OtherTaxDay { get; set; }
    public decimal? RoomsMtd { get; set; }
    public decimal? GuestMtd { get; set; }
    public decimal? SingleOccMtd { get; set; }
    public decimal? MultiOccMtd { get; set; }
    public decimal? TotalRevMtd { get; set; }
    public decimal? RoomRevMtd { get; set; }
    public decimal? FbRevMtd { get; set; }
    public decimal? OtherRevMtd { get; set; }
    public decimal? TotalPkgRevenueMtd { get; set; }
    public decimal? PkgRoomRevMtd { get; set; }
    public decimal? PkgFbRevMtd { get; set; }
    public decimal? PkgOtherRevMtd { get; set; }
    public decimal? TotalTaxMtd { get; set; }
    public decimal? RoomTaxMtd { get; set; }
    public decimal? FbTaxMtd { get; set; }
    public decimal? OtherTaxMtd { get; set; }
    public decimal? RoomsYtd { get; set; }
    public decimal? GuestYtd { get; set; }
    public decimal? SingleOccYtd { get; set; }
    public decimal? MultiOccYtd { get; set; }
    public decimal? TotalRevYtd { get; set; }
    public decimal? RoomRevYtd { get; set; }
    public decimal? FbRevYtd { get; set; }
    public decimal? OtherRevYtd { get; set; }
    public decimal? TotalPkgRevenueYtd { get; set; }
    public decimal? PkgRoomRevYtd { get; set; }
    public decimal? PkgFbRevYtd { get; set; }
    public decimal? PkgOtherRevYtd { get; set; }
    public decimal? TotalTaxYtd { get; set; }
    public decimal? RoomTaxYtd { get; set; }
    public decimal? FbTaxYtd { get; set; }
    public decimal? OtherTaxYtd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepStatMarkSeg>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_STAT_MARK_SEG");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FbRevDay)
                .HasColumnName("FB_REV_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevMtd)
                .HasColumnName("FB_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevYtd)
                .HasColumnName("FB_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbTaxDay)
                .HasColumnName("FB_TAX_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbTaxMtd)
                .HasColumnName("FB_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbTaxYtd)
                .HasColumnName("FB_TAX_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestDay)
                .HasColumnName("GUEST_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestMtd)
                .HasColumnName("GUEST_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestYtd)
                .HasColumnName("GUEST_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .IsRequired()
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MultiOccDay)
                .HasColumnName("MULTI_OCC_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultiOccMtd)
                .HasColumnName("MULTI_OCC_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultiOccYtd)
                .HasColumnName("MULTI_OCC_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevDay)
                .HasColumnName("OTHER_REV_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevMtd)
                .HasColumnName("OTHER_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevYtd)
                .HasColumnName("OTHER_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherTaxDay)
                .HasColumnName("OTHER_TAX_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherTaxMtd)
                .HasColumnName("OTHER_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherTaxYtd)
                .HasColumnName("OTHER_TAX_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentMarketCode)
                .IsRequired()
                .HasColumnName("PARENT_MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PkgFbRevDay)
                .HasColumnName("PKG_FB_REV_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgFbRevMtd)
                .HasColumnName("PKG_FB_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgFbRevYtd)
                .HasColumnName("PKG_FB_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgOtherRevDay)
                .HasColumnName("PKG_OTHER_REV_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgOtherRevMtd)
                .HasColumnName("PKG_OTHER_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgOtherRevYtd)
                .HasColumnName("PKG_OTHER_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgRevDay)
                .HasColumnName("PKG_REV_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgRoomRevDay)
                .HasColumnName("PKG_ROOM_REV_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgRoomRevMtd)
                .HasColumnName("PKG_ROOM_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgRoomRevYtd)
                .HasColumnName("PKG_ROOM_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevDay)
                .HasColumnName("ROOM_REV_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevMtd)
                .HasColumnName("ROOM_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevYtd)
                .HasColumnName("ROOM_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomTaxDay)
                .HasColumnName("ROOM_TAX_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomTaxMtd)
                .HasColumnName("ROOM_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomTaxYtd)
                .HasColumnName("ROOM_TAX_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsDay)
                .HasColumnName("ROOMS_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsMtd)
                .HasColumnName("ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsYtd)
                .HasColumnName("ROOMS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccDay)
                .HasColumnName("SINGLE_OCC_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccMtd)
                .HasColumnName("SINGLE_OCC_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccYtd)
                .HasColumnName("SINGLE_OCC_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgRevenueMtd)
                .HasColumnName("TOTAL_PKG_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgRevenueYtd)
                .HasColumnName("TOTAL_PKG_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevDay)
                .HasColumnName("TOTAL_REV_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevMtd)
                .HasColumnName("TOTAL_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevYtd)
                .HasColumnName("TOTAL_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTaxDay)
                .HasColumnName("TOTAL_TAX_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTaxMtd)
                .HasColumnName("TOTAL_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTaxYtd)
                .HasColumnName("TOTAL_TAX_YTD")
                .HasColumnType("NUMBER");
        });
	}
}
