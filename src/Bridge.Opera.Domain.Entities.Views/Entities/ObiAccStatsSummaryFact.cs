namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiAccStatsSummaryFact
{
    public decimal? NameId { get; set; }
    public string? NameType { get; set; }
    public string? Resort { get; set; }
    public DateTime? StayDate { get; set; }
    public decimal? ProdMonth { get; set; }
    public string? CurrencyCode { get; set; }
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

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiAccStatsSummaryFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ACC_STATS_SUMMARY_FACT");

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
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProdMonth)
                .HasColumnName("PROD_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

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
