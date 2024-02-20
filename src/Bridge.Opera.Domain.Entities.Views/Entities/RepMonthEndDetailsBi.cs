namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepMonthEndDetailsBi
{
    public decimal? ReportId { get; set; }
    public string? RecordType { get; set; }
    public decimal? SectionOrder { get; set; }
    public decimal? OrderBy { get; set; }
    public string? GroupBy { get; set; }
    public decimal? GroupById { get; set; }
    public string? NewStatusYn { get; set; }
    public string? Status { get; set; }
    public decimal? StatusOrder { get; set; }
    public decimal? BookId { get; set; }
    public string? BookDesc { get; set; }
    public DateTime? BookArrival { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? FbChange { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? OtherChange { get; set; }
    public decimal? Nights { get; set; }
    public decimal? NightsChange { get; set; }
    public decimal? AdrRevenue { get; set; }
    public decimal? AdrChange { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? RoomChange { get; set; }
    public decimal? Covers { get; set; }
    public decimal? AvgCheck { get; set; }
    public string? TotalYn { get; set; }
    public string? Attributes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepMonthEndDetailsBi>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_MONTH_END_DETAILS_BI");

            entity.Property(e => e.AdrChange)
                .HasColumnName("ADR_CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdrRevenue)
                .HasColumnName("ADR_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attributes)
                .HasColumnName("ATTRIBUTES")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AvgCheck)
                .HasColumnName("AVG_CHECK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookArrival)
                .HasColumnName("BOOK_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BookDesc)
                .HasColumnName("BOOK_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Covers)
                .HasColumnName("COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbChange)
                .HasColumnName("FB_CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupBy)
                .HasColumnName("GROUP_BY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GroupById)
                .HasColumnName("GROUP_BY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewStatusYn)
                .HasColumnName("NEW_STATUS_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NightsChange)
                .HasColumnName("NIGHTS_CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherChange)
                .HasColumnName("OTHER_CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomChange)
                .HasColumnName("ROOM_CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SectionOrder)
                .HasColumnName("SECTION_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StatusOrder)
                .HasColumnName("STATUS_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalYn)
                .HasColumnName("TOTAL_YN")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
