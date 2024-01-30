namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UpsellOffers
{
    public decimal? UpsellOfferId { get; set; }
    public decimal? UpsellAvlReqId { get; set; }
    public DateTime? UpsellOfferDate { get; set; }
    public string? ToRateCode { get; set; }
    public string? FromRoomCategory { get; set; }
    public string? ToRoomCategory { get; set; }
    public string? ToRoomCategoryLabel { get; set; }
    public decimal? FirstNightAmt { get; set; }
    public decimal? TotalStayAmt { get; set; }
    public decimal? FirstNightUpsellAmt { get; set; }
    public decimal? TotalUpsellMoneyAmt { get; set; }
    public decimal? TotalRankingValue { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? UpsellRuleId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpsellOfferGroupId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? FirstNightUpsellCharge { get; set; }
    public decimal? TotalUpsellCharge { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UpsellOffers>(entity =>
        {
            entity.HasKey(e => e.UpsellOfferId)
                .HasName("UPSELL_OFFER_PK");

            entity.ToTable("UPSELL_OFFERS");

            entity.HasIndex(e => e.UpsellOfferDate)
                .HasName("UPSELL_OFFER_IDX2");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("UPSELL_OFFER_IDX1");

            entity.Property(e => e.UpsellOfferId)
                .HasColumnName("UPSELL_OFFER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstNightAmt)
                .HasColumnName("FIRST_NIGHT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstNightUpsellAmt)
                .HasColumnName("FIRST_NIGHT_UPSELL_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstNightUpsellCharge)
                .HasColumnName("FIRST_NIGHT_UPSELL_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromRoomCategory)
                .HasColumnName("FROM_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToRateCode)
                .HasColumnName("TO_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToRoomCategory)
                .HasColumnName("TO_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToRoomCategoryLabel)
                .HasColumnName("TO_ROOM_CATEGORY_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalRankingValue)
                .HasColumnName("TOTAL_RANKING_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalStayAmt)
                .HasColumnName("TOTAL_STAY_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalUpsellCharge)
                .HasColumnName("TOTAL_UPSELL_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalUpsellMoneyAmt)
                .HasColumnName("TOTAL_UPSELL_MONEY_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpsellAvlReqId)
                .HasColumnName("UPSELL_AVL_REQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpsellOfferDate)
                .HasColumnName("UPSELL_OFFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpsellOfferGroupId)
                .HasColumnName("UPSELL_OFFER_GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpsellRuleId)
                .HasColumnName("UPSELL_RULE_ID")
                .HasColumnType("NUMBER");
        });
	}
}
