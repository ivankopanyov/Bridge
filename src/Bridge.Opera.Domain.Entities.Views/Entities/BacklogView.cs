namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BacklogView
{
    public decimal? ExportId { get; set; }
    public string? Resort { get; set; }
    public string? Month { get; set; }
    public string? Year { get; set; }
    public string? Status { get; set; }
    public string? MarketCode { get; set; }
    public decimal? Roomnights { get; set; }
    public decimal? NetRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BacklogView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BACKLOG_VIEW");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Month)
                .HasColumnName("MONTH")
                .HasMaxLength(27)
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

            entity.Property(e => e.Year)
                .HasColumnName("YEAR")
                .HasMaxLength(4)
                .IsUnicode(false);
        });
	}
}
