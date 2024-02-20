namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ShRateHeaderLovInt
{
    public string? RateCode { get; set; }
    public string? StayDays { get; set; }
    public string? GroupYn { get; set; }
    public string? RivMarketSegment { get; set; }
    public string? IdRequirements { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ShRateHeaderLovInt>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SH_RATE_HEADER_LOV_INT");

            entity.Property(e => e.GroupYn)
                .HasColumnName("GROUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IdRequirements)
                .HasColumnName("ID_REQUIREMENTS")
                .HasMaxLength(65)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RivMarketSegment)
                .HasColumnName("RIV_MARKET_SEGMENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StayDays)
                .HasColumnName("STAY_DAYS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
