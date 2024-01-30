namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipTypeExchRates
{
    public decimal? ExchRateId { get; set; }
    public string? ChainCode { get; set; }
    public string? PrimaryMembershipType { get; set; }
    public string? FfMembershipType { get; set; }
    public decimal? AwPtsExchRateSell { get; set; }
    public decimal? MinAwTxPts { get; set; }
    public decimal? AwPointsTxBaseBlock { get; set; }
    public string? AwPtsTxFractionFlg { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? BillingGroup { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTypeExchRates>(entity =>
        {
            entity.HasKey(e => e.ExchRateId)
                .HasName("MTE_PK");

            entity.ToTable("MEMBERSHIP_TYPE_EXCH_RATES");

            entity.HasIndex(e => new { e.ChainCode, e.PrimaryMembershipType, e.FfMembershipType })
                .HasName("MTE_UK")
                .IsUnique();

            entity.Property(e => e.ExchRateId)
                .HasColumnName("EXCH_RATE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwPointsTxBaseBlock)
                .HasColumnName("AW_POINTS_TX_BASE_BLOCK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwPtsExchRateSell)
                .HasColumnName("AW_PTS_EXCH_RATE_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwPtsTxFractionFlg)
                .HasColumnName("AW_PTS_TX_FRACTION_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BillingGroup)
                .HasColumnName("BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FfMembershipType)
                .IsRequired()
                .HasColumnName("FF_MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinAwTxPts)
                .HasColumnName("MIN_AW_TX_PTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryMembershipType)
                .IsRequired()
                .HasColumnName("PRIMARY_MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
