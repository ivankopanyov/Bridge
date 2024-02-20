namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PromoCouponBatchStatus
{
    public string? Resort { get; set; }
    public string? PromotionCode { get; set; }
    public string? BatchCode { get; set; }
    public string? CouponStatus { get; set; }
    public decimal? NoOfCoupons { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PromoCouponBatchStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PROMO_COUPON_BATCH_STATUS");

            entity.Property(e => e.BatchCode)
                .IsRequired()
                .HasColumnName("BATCH_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CouponStatus)
                .HasColumnName("COUPON_STATUS")
                .IsUnicode(false);

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
