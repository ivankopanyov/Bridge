namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConRegrets
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? NumOfRooms { get; set; }
    public decimal? NumOfNights { get; set; }
    public decimal? RoomRate { get; set; }
    public string RoomType { get; set; }
    public string MarketCode { get; set; }
    public string RateCode { get; set; }
    public string RateCategory { get; set; }
    public string TurnawayCode { get; set; }
    public string CurrencyCode { get; set; }
    public string DayTypeCode { get; set; }
    public string BlockCode { get; set; }
    public string ExtRefNum { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? BusinessDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConRegrets>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_REGRETS");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DayTypeCode)
                .HasColumnName("DAY_TYPE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtRefNum)
                .HasColumnName("EXT_REF_NUM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NumOfNights)
                .HasColumnName("NUM_OF_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumOfRooms)
                .HasColumnName("NUM_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomRate)
                .HasColumnName("ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TurnawayCode)
                .HasColumnName("TURNAWAY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
