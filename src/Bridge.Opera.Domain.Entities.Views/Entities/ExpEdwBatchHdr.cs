namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEdwBatchHdr
{
    public decimal? ExportId { get; set; }
    public string? EdwType { get; set; }
    public string? PmsVersion { get; set; }
    public string? DataSource { get; set; }
    public string? BrandId { get; set; }
    public string? HotelCode { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? TotalRooms { get; set; }
    public decimal? TotalDayuse { get; set; }
    public decimal? TotalComp { get; set; }
    public decimal? TotalNetRevenue { get; set; }
    public decimal? TotalRoomAdj { get; set; }
    public decimal? TotalPhysicalRooms { get; set; }
    public decimal? TotalOooRooms { get; set; }
    public decimal? TotalPmsNoshows { get; set; }
    public decimal? TotalCrsNoshows { get; set; }
    public decimal? TotalPmsCancels { get; set; }
    public decimal? TotalCrsCancels { get; set; }
    public decimal? TotalFnsRooms { get; set; }
    public decimal? OccExclFns { get; set; }
    public decimal? OccInclFns { get; set; }
    public decimal? TotalRoomsExclFns { get; set; }
    public decimal? AdrExclFns { get; set; }
    public decimal? AdrInclFns { get; set; }
    public decimal? RoomRevenueFns { get; set; }
    public decimal? TotalCn { get; set; }
    public decimal? TotalEv { get; set; }
    public decimal? TotalTr { get; set; }
    public decimal? TotalTrxAmount { get; set; }
    public decimal? TotalCl { get; set; }
    public decimal? TotalJr { get; set; }
    public decimal? TotalTurnaways { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEdwBatchHdr>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_EDW_BATCH_HDR");

            entity.Property(e => e.AdrExclFns)
                .HasColumnName("ADR_EXCL_FNS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdrInclFns)
                .HasColumnName("ADR_INCL_FNS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BrandId)
                .HasColumnName("BRAND_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DataSource)
                .HasColumnName("DATA_SOURCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EdwType)
                .HasColumnName("EDW_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OccExclFns)
                .HasColumnName("OCC_EXCL_FNS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccInclFns)
                .HasColumnName("OCC_INCL_FNS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsVersion)
                .HasColumnName("PMS_VERSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenueFns)
                .HasColumnName("ROOM_REVENUE_FNS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCl)
                .HasColumnName("TOTAL_CL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCn)
                .HasColumnName("TOTAL_CN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalComp)
                .HasColumnName("TOTAL_COMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCrsCancels)
                .HasColumnName("TOTAL_CRS_CANCELS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCrsNoshows)
                .HasColumnName("TOTAL_CRS_NOSHOWS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalDayuse)
                .HasColumnName("TOTAL_DAYUSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalEv)
                .HasColumnName("TOTAL_EV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFnsRooms)
                .HasColumnName("TOTAL_FNS_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalJr)
                .HasColumnName("TOTAL_JR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNetRevenue)
                .HasColumnName("TOTAL_NET_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOooRooms)
                .HasColumnName("TOTAL_OOO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPhysicalRooms)
                .HasColumnName("TOTAL_PHYSICAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPmsCancels)
                .HasColumnName("TOTAL_PMS_CANCELS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPmsNoshows)
                .HasColumnName("TOTAL_PMS_NOSHOWS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomAdj)
                .HasColumnName("TOTAL_ROOM_ADJ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomsExclFns)
                .HasColumnName("TOTAL_ROOMS_EXCL_FNS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTr)
                .HasColumnName("TOTAL_TR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTrxAmount)
                .HasColumnName("TOTAL_TRX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTurnaways)
                .HasColumnName("TOTAL_TURNAWAYS")
                .HasColumnType("NUMBER");
        });
	}
}
