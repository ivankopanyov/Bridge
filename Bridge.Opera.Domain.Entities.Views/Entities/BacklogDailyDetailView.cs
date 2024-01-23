namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BacklogDailyDetailView
{
    public decimal? ExportId { get; set; }
    public string Resort { get; set; }
    public DateTime? StayDate { get; set; }
    public string Status { get; set; }
    public DateTime? ExportDate { get; set; }
    public string MarketCode { get; set; }
    public decimal? Roomnights { get; set; }
    public decimal? NetRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BacklogDailyDetailView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BACKLOG_DAILY_DETAIL_VIEW");

            entity.Property(e => e.ExportDate)
                .HasColumnName("EXPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NetRevenue)
                .HasColumnName("NET_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Roomnights)
                .HasColumnName("ROOMNIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");
        });
	}
}
