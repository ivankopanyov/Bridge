namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RepProdRmsCatRows
{
    public string Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? EventId { get; set; }
    public string BbStatus { get; set; }
    public string BbCreditStatusYn { get; set; }
    public string BbStatusChgDate { get; set; }
    public string EvStatus { get; set; }
    public string EvCreditStatusYn { get; set; }
    public string EvStatusChgDate { get; set; }
    public decimal? BbNigthsTot { get; set; }
    public decimal? BbNigthsChg { get; set; }
    public decimal? BbRevenueTot { get; set; }
    public decimal? BbRevenueChg { get; set; }
    public decimal? RevenueTypes1Tot { get; set; }
    public decimal? RevenueTypes1Chg { get; set; }
    public decimal? RevenueTypes2Tot { get; set; }
    public decimal? RevenueTypes2Chg { get; set; }
    public decimal? RevenueTypes3Tot { get; set; }
    public decimal? RevenueTypes3Chg { get; set; }
    public decimal? RevenueTypes4Tot { get; set; }
    public decimal? RevenueTypes4Chg { get; set; }
    public decimal? RevenueTypes5Tot { get; set; }
    public decimal? RevenueTypes5Chg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepProdRmsCatRows>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("REP_PROD_RMS_CAT_ROWS");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BbCreditStatusYn)
                .HasColumnName("BB_CREDIT_STATUS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BbNigthsChg)
                .HasColumnName("BB_NIGTHS_CHG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BbNigthsTot)
                .HasColumnName("BB_NIGTHS_TOT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BbRevenueChg)
                .HasColumnName("BB_REVENUE_CHG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BbRevenueTot)
                .HasColumnName("BB_REVENUE_TOT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BbStatus)
                .HasColumnName("BB_STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BbStatusChgDate)
                .HasColumnName("BB_STATUS_CHG_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.EvCreditStatusYn)
                .HasColumnName("EV_CREDIT_STATUS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EvStatus)
                .HasColumnName("EV_STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EvStatusChgDate)
                .HasColumnName("EV_STATUS_CHG_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueTypes1Chg)
                .HasColumnName("REVENUE_TYPES_1_CHG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueTypes1Tot)
                .HasColumnName("REVENUE_TYPES_1_TOT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueTypes2Chg)
                .HasColumnName("REVENUE_TYPES_2_CHG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueTypes2Tot)
                .HasColumnName("REVENUE_TYPES_2_TOT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueTypes3Chg)
                .HasColumnName("REVENUE_TYPES_3_CHG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueTypes3Tot)
                .HasColumnName("REVENUE_TYPES_3_TOT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueTypes4Chg)
                .HasColumnName("REVENUE_TYPES_4_CHG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueTypes4Tot)
                .HasColumnName("REVENUE_TYPES_4_TOT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueTypes5Chg)
                .HasColumnName("REVENUE_TYPES_5_CHG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueTypes5Tot)
                .HasColumnName("REVENUE_TYPES_5_TOT")
                .HasColumnType("NUMBER");
        });
	}
}
