namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpHdetInsertView
{
    public decimal? ExportId { get; set; }
    public string ExportType { get; set; }
    public string RecordType { get; set; }
    public decimal? Rooms { get; set; }
    public decimal? RoomRevenue { get; set; }
    public DateTime? ResDate { get; set; }
    public string RoomCategoryLabel { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? ReservationDate { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string ResvStatus { get; set; }
    public string TentDefFlag { get; set; }
    public decimal? Nights { get; set; }
    public string RateCode { get; set; }
    public string PropertyCode { get; set; }
    public string CurrencyCode { get; set; }
    public string CurrencyDecimals { get; set; }
    public decimal? TotalBrecs { get; set; }
    public decimal? TotalCrecs { get; set; }
    public decimal? TotalNrecs { get; set; }
    public decimal? TotalWrecs { get; set; }
    public decimal? TotalGrecs { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpHdetInsertView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_HDET_INSERT_VIEW");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyDecimals)
                .HasColumnName("CURRENCY_DECIMALS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResDate)
                .HasColumnName("RES_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TentDefFlag)
                .HasColumnName("TENT_DEF_FLAG")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TotalBrecs)
                .HasColumnName("TOTAL_BRECS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCrecs)
                .HasColumnName("TOTAL_CRECS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGrecs)
                .HasColumnName("TOTAL_GRECS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNrecs)
                .HasColumnName("TOTAL_NRECS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalWrecs)
                .HasColumnName("TOTAL_WRECS")
                .HasColumnType("NUMBER");
        });
	}
}
