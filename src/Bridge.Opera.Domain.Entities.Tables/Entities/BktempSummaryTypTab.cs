namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BktempSummaryTypTab
{
    public decimal? Keynumber { get; set; }
    public string? SummaryType { get; set; }
    public string? Chain { get; set; }
    public string? Resort { get; set; }
    public DateTime? RecordDate { get; set; }
    public decimal? PmsToSell { get; set; }
    public decimal? PmsSold { get; set; }
    public decimal? CisSold { get; set; }
    public decimal? RequestId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BktempSummaryTypTab>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BKTEMP_SUMMARY_TYP_TAB");

            entity.HasIndex(e => e.RequestId)
                .HasName("SUMM_TAB_REQ_ID");

            entity.Property(e => e.Chain)
                .HasColumnName("CHAIN")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CisSold)
                .HasColumnName("CIS_SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Keynumber)
                .HasColumnName("KEYNUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsSold)
                .HasColumnName("PMS_SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsToSell)
                .HasColumnName("PMS_TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordDate)
                .HasColumnName("RECORD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SummaryType)
                .HasColumnName("SUMMARY_TYPE")
                .HasMaxLength(8)
                .IsUnicode(false);
        });
	}
}
