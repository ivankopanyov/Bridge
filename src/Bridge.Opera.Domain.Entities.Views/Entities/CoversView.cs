namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CoversView
{
    public string TrxCode { get; set; }
    public string TrxDesc { get; set; }
    public DateTime? TrxDate { get; set; }
    public string Resort { get; set; }
    public decimal? RevenueToday { get; set; }
    public decimal? ManualCoversToday { get; set; }
    public decimal? FinTrxCoversToday { get; set; }
    public decimal? TotalCoversMtd { get; set; }
    public decimal? TotalCoversYtd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CoversView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("COVERS_VIEW");

            entity.Property(e => e.FinTrxCoversToday)
                .HasColumnName("FIN_TRX_COVERS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ManualCoversToday)
                .HasColumnName("MANUAL_COVERS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueToday)
                .HasColumnName("REVENUE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCoversMtd)
                .HasColumnName("TOTAL_COVERS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCoversYtd)
                .HasColumnName("TOTAL_COVERS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
