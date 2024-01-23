namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiAccStatsFact
{
    public decimal? NameId { get; set; }
    public string Resort { get; set; }
    public string StayYear { get; set; }
    public string StayMonth { get; set; }
    public DateTime? StayDate { get; set; }
    public string NameType { get; set; }
    public string CurrencyCode { get; set; }
    public decimal? IndRoomNight { get; set; }
    public decimal? IndRoomRevNet { get; set; }
    public decimal? IndAvgRevNet { get; set; }
    public decimal? IndFbRevNet { get; set; }
    public decimal? IndOtherRevNet { get; set; }
    public decimal? IndTotalRevNet { get; set; }
    public decimal? GrpRoomNight { get; set; }
    public decimal? GrpRoomRevNet { get; set; }
    public decimal? GrpAvgRevNet { get; set; }
    public decimal? GrpFbRevNet { get; set; }
    public decimal? GrpOtherRevNet { get; set; }
    public decimal? GrpTotalRevNet { get; set; }
    public decimal? TotRoomNight { get; set; }
    public decimal? TotRoomRevNet { get; set; }
    public decimal? TotAvgRevNet { get; set; }
    public decimal? TotFbRevNet { get; set; }
    public decimal? TotOtherRevNet { get; set; }
    public decimal? TotTotalRevNet { get; set; }
    public decimal? IndRoomRevGross { get; set; }
    public decimal? IndAvgRevGross { get; set; }
    public decimal? IndFbRevGross { get; set; }
    public decimal? IndOtherRevGross { get; set; }
    public decimal? IndTotalRevGross { get; set; }
    public decimal? GrpRoomRevGross { get; set; }
    public decimal? GrpAvgRevGross { get; set; }
    public decimal? GrpFbRevGross { get; set; }
    public decimal? GrpOtherRevGross { get; set; }
    public decimal? GrpTotalRevGross { get; set; }
    public decimal? TotRoomRevGross { get; set; }
    public decimal? TotAvgRevGross { get; set; }
    public decimal? TotFbRevGross { get; set; }
    public decimal? TotOtherRevGross { get; set; }
    public decimal? TotTotalRevGross { get; set; }
    public string CentralCurrencyCode { get; set; }
    public decimal? CcIndRoomNight { get; set; }
    public decimal? CcIndRoomRevNet { get; set; }
    public decimal? CcIndAvgRevNet { get; set; }
    public decimal? CcIndFbRevNet { get; set; }
    public decimal? CcIndOtherRevNet { get; set; }
    public decimal? CcIndTotalRevNet { get; set; }
    public decimal? CcGrpRoomNight { get; set; }
    public decimal? CcGrpRoomRevNet { get; set; }
    public decimal? CcGrpAvgRevNet { get; set; }
    public decimal? CcGrpFbRevNet { get; set; }
    public decimal? CcGrpOtherRevNet { get; set; }
    public decimal? CcGrpTotalRevNet { get; set; }
    public decimal? CcTotRoomNight { get; set; }
    public decimal? CcTotRoomRevNet { get; set; }
    public decimal? CcTotAvgRevNet { get; set; }
    public decimal? CcTotFbRevNet { get; set; }
    public decimal? CcTotOtherRevNet { get; set; }
    public decimal? CcTotTotalRevNet { get; set; }
    public decimal? CcIndRoomRevGross { get; set; }
    public decimal? CcIndAvgRevGross { get; set; }
    public decimal? CcIndFbRevGross { get; set; }
    public decimal? CcIndOtherRevGross { get; set; }
    public decimal? CcIndTotalRevGross { get; set; }
    public decimal? CcGrpRoomRevGross { get; set; }
    public decimal? CcGrpAvgRevGross { get; set; }
    public decimal? CcGrpFbRevGross { get; set; }
    public decimal? CcGrpOtherRevGross { get; set; }
    public decimal? CcGrpTotalRevGross { get; set; }
    public decimal? CcTotRoomRevGross { get; set; }
    public decimal? CcTotAvgRevGross { get; set; }
    public decimal? CcTotFbRevGross { get; set; }
    public decimal? CcTotOtherRevGross { get; set; }
    public decimal? CcTotTotalRevGross { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiAccStatsFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ACC_STATS_FACT");

            entity.Property(e => e.CcGrpAvgRevGross)
                .HasColumnName("CC_GRP_AVG_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpAvgRevNet)
                .HasColumnName("CC_GRP_AVG_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpFbRevGross)
                .HasColumnName("CC_GRP_FB_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpFbRevNet)
                .HasColumnName("CC_GRP_FB_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpOtherRevGross)
                .HasColumnName("CC_GRP_OTHER_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpOtherRevNet)
                .HasColumnName("CC_GRP_OTHER_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpRoomNight)
                .HasColumnName("CC_GRP_ROOM_NIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpRoomRevGross)
                .HasColumnName("CC_GRP_ROOM_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpRoomRevNet)
                .HasColumnName("CC_GRP_ROOM_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpTotalRevGross)
                .HasColumnName("CC_GRP_TOTAL_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcGrpTotalRevNet)
                .HasColumnName("CC_GRP_TOTAL_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcIndAvgRevGross)
                .HasColumnName("CC_IND_AVG_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcIndAvgRevNet)
                .HasColumnName("CC_IND_AVG_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcIndFbRevGross)
                .HasColumnName("CC_IND_FB_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcIndFbRevNet)
                .HasColumnName("CC_IND_FB_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcIndOtherRevGross)
                .HasColumnName("CC_IND_OTHER_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcIndOtherRevNet)
                .HasColumnName("CC_IND_OTHER_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcIndRoomNight)
                .HasColumnName("CC_IND_ROOM_NIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcIndRoomRevGross)
                .HasColumnName("CC_IND_ROOM_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcIndRoomRevNet)
                .HasColumnName("CC_IND_ROOM_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcIndTotalRevGross)
                .HasColumnName("CC_IND_TOTAL_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcIndTotalRevNet)
                .HasColumnName("CC_IND_TOTAL_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTotAvgRevGross)
                .HasColumnName("CC_TOT_AVG_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTotAvgRevNet)
                .HasColumnName("CC_TOT_AVG_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTotFbRevGross)
                .HasColumnName("CC_TOT_FB_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTotFbRevNet)
                .HasColumnName("CC_TOT_FB_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTotOtherRevGross)
                .HasColumnName("CC_TOT_OTHER_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTotOtherRevNet)
                .HasColumnName("CC_TOT_OTHER_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTotRoomNight)
                .HasColumnName("CC_TOT_ROOM_NIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTotRoomRevGross)
                .HasColumnName("CC_TOT_ROOM_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTotRoomRevNet)
                .HasColumnName("CC_TOT_ROOM_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTotTotalRevGross)
                .HasColumnName("CC_TOT_TOTAL_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTotTotalRevNet)
                .HasColumnName("CC_TOT_TOTAL_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CentralCurrencyCode)
                .HasColumnName("CENTRAL_CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.GrpAvgRevGross)
                .HasColumnName("GRP_AVG_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpAvgRevNet)
                .HasColumnName("GRP_AVG_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpFbRevGross)
                .HasColumnName("GRP_FB_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpFbRevNet)
                .HasColumnName("GRP_FB_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpOtherRevGross)
                .HasColumnName("GRP_OTHER_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpOtherRevNet)
                .HasColumnName("GRP_OTHER_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpRoomNight)
                .HasColumnName("GRP_ROOM_NIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpRoomRevGross)
                .HasColumnName("GRP_ROOM_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpRoomRevNet)
                .HasColumnName("GRP_ROOM_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpTotalRevGross)
                .HasColumnName("GRP_TOTAL_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpTotalRevNet)
                .HasColumnName("GRP_TOTAL_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndAvgRevGross)
                .HasColumnName("IND_AVG_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndAvgRevNet)
                .HasColumnName("IND_AVG_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndFbRevGross)
                .HasColumnName("IND_FB_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndFbRevNet)
                .HasColumnName("IND_FB_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndOtherRevGross)
                .HasColumnName("IND_OTHER_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndOtherRevNet)
                .HasColumnName("IND_OTHER_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRoomNight)
                .HasColumnName("IND_ROOM_NIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRoomRevGross)
                .HasColumnName("IND_ROOM_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRoomRevNet)
                .HasColumnName("IND_ROOM_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndTotalRevGross)
                .HasColumnName("IND_TOTAL_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndTotalRevNet)
                .HasColumnName("IND_TOTAL_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(12)
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
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.StayYear)
                .HasColumnName("STAY_YEAR")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.TotAvgRevGross)
                .HasColumnName("TOT_AVG_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotAvgRevNet)
                .HasColumnName("TOT_AVG_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotFbRevGross)
                .HasColumnName("TOT_FB_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotFbRevNet)
                .HasColumnName("TOT_FB_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotOtherRevGross)
                .HasColumnName("TOT_OTHER_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotOtherRevNet)
                .HasColumnName("TOT_OTHER_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotRoomNight)
                .HasColumnName("TOT_ROOM_NIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotRoomRevGross)
                .HasColumnName("TOT_ROOM_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotRoomRevNet)
                .HasColumnName("TOT_ROOM_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotTotalRevGross)
                .HasColumnName("TOT_TOTAL_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotTotalRevNet)
                .HasColumnName("TOT_TOTAL_REV_NET")
                .HasColumnType("NUMBER");
        });
	}
}
