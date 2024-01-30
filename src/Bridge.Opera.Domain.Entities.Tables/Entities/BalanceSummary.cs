namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BalanceSummary
{
    public string? Resort { get; set; }
    public string? Ltype { get; set; }
    public DateTime? TrxDate { get; set; }
    public string? TrxCode { get; set; }
    public decimal? FtLedDiff { get; set; }
    public decimal? TbLedDiff { get; set; }
    public decimal? FtLedDr { get; set; }
    public decimal? FtLedCr { get; set; }
    public decimal? TbLedDr { get; set; }
    public decimal? TbLedCr { get; set; }
    public decimal? TotalDiff { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BalanceSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BALANCE_SUMMARY");

            entity.Property(e => e.FtLedCr)
                .HasColumnName("FT_LED_CR")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FtLedDiff)
                .HasColumnName("FT_LED_DIFF")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FtLedDr)
                .HasColumnName("FT_LED_DR")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ltype)
                .HasColumnName("LTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TbLedCr)
                .HasColumnName("TB_LED_CR")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TbLedDiff)
                .HasColumnName("TB_LED_DIFF")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TbLedDr)
                .HasColumnName("TB_LED_DR")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalDiff)
                .HasColumnName("TOTAL_DIFF")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
