namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsQuoteHeaderYcVw
{
    public decimal? RequestId { get; set; }
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? SummaryType { get; set; }
    public string? YieldCategory { get; set; }
    public decimal? RoomsReq { get; set; }
    public decimal? TotalRooms { get; set; }
    public string? RoomsNCost { get; set; }
    public string? ForeEmpty { get; set; }
    public string? ForeYieldable { get; set; }
    public string? ForeNonyieldable { get; set; }
    public string? OtbYieldable { get; set; }
    public string? OtbNonyieldable { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsQuoteHeaderYcVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_QUOTE_HEADER_YC_VW");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForeEmpty)
                .HasColumnName("FORE_EMPTY")
                .IsUnicode(false);

            entity.Property(e => e.ForeNonyieldable)
                .HasColumnName("FORE_NONYIELDABLE")
                .IsUnicode(false);

            entity.Property(e => e.ForeYieldable)
                .HasColumnName("FORE_YIELDABLE")
                .IsUnicode(false);

            entity.Property(e => e.OtbNonyieldable)
                .HasColumnName("OTB_NONYIELDABLE")
                .IsUnicode(false);

            entity.Property(e => e.OtbYieldable)
                .HasColumnName("OTB_YIELDABLE")
                .IsUnicode(false);

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomsNCost)
                .HasColumnName("ROOMS_N_COST")
                .IsUnicode(false);

            entity.Property(e => e.RoomsReq)
                .HasColumnName("ROOMS_REQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SummaryType)
                .HasColumnName("SUMMARY_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
