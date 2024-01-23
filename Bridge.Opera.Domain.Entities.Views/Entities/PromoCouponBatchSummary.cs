namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PromoCouponBatchSummary
{
    public string Resort { get; set; }
    public string PromotionCode { get; set; }
    public string BatchCode { get; set; }
    public decimal? MinCouponId { get; set; }
    public decimal? MaxCouponId { get; set; }
    public decimal? NoOfCoupons { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PromoCouponBatchSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PROMO_COUPON_BATCH_SUMMARY");

            entity.Property(e => e.BatchCode)
                .IsRequired()
                .HasColumnName("BATCH_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MaxCouponId)
                .HasColumnName("MAX_COUPON_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinCouponId)
                .HasColumnName("MIN_COUPON_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfCoupons)
                .HasColumnName("NO_OF_COUPONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PromotionCode)
                .IsRequired()
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
