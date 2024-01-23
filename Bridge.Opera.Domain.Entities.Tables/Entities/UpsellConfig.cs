namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UpsellConfig
{
    public string Resort { get; set; }
    public decimal? MaxLos { get; set; }
    public decimal? MaxUpsellOffers { get; set; }
    public string PhisicalInventoryYn { get; set; }
    public string BlocksAllowedYn { get; set; }
    public string DiscountAllowedYn { get; set; }
    public string MultiRateAllowedYn { get; set; }
    public string SharesAllowedYn { get; set; }
    public string RankingMode { get; set; }
    public string RoomStatus { get; set; }
    public string TrxCode { get; set; }
    public string FixedrateAllowedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UpsellConfig>(entity =>
        {
            entity.HasKey(e => e.Resort)
                .HasName("UPSELL_CONFIG_PK");

            entity.ToTable("UPSELL_CONFIG");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BlocksAllowedYn)
                .HasColumnName("BLOCKS_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DiscountAllowedYn)
                .HasColumnName("DISCOUNT_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FixedrateAllowedYn)
                .HasColumnName("FIXEDRATE_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MaxLos)
                .HasColumnName("MAX_LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxUpsellOffers)
                .HasColumnName("MAX_UPSELL_OFFERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultiRateAllowedYn)
                .HasColumnName("MULTI_RATE_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PhisicalInventoryYn)
                .HasColumnName("PHISICAL_INVENTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RankingMode)
                .HasColumnName("RANKING_MODE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoomStatus)
                .HasColumnName("ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SharesAllowedYn)
                .HasColumnName("SHARES_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
