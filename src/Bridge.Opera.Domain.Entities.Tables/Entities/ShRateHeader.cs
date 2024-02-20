namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ShRateHeader
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? StayDays { get; set; }
    public string? GroupYn { get; set; }
    public string? RivMarketSegment { get; set; }
    public string? IdRequirements { get; set; }
    public int? ShMingrprms { get; set; }
    public int? ShMaxgrprms { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ShRateHeader>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCode })
                .HasName("SH_RATE_HEADER_PK");

            entity.ToTable("SH_RATE_HEADER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GroupYn)
                .HasColumnName("GROUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IdRequirements)
                .HasColumnName("ID_REQUIREMENTS")
                .HasMaxLength(65)
                .IsUnicode(false);

            entity.Property(e => e.RivMarketSegment)
                .HasColumnName("RIV_MARKET_SEGMENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShMaxgrprms)
                .HasColumnName("SH_MAXGRPRMS")
                .HasColumnType("NUMBER(7)");

            entity.Property(e => e.ShMingrprms)
                .HasColumnName("SH_MINGRPRMS")
                .HasColumnType("NUMBER(7)");

            entity.Property(e => e.StayDays)
                .HasColumnName("STAY_DAYS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
