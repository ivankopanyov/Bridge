namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OneTimePromoCoupons
{
    public string? BatchCode { get; set; }
    public decimal? CouponId { get; set; }
    public string? CouponCode { get; set; }
    public string? ChainCode { get; set; }
    public string? Resort { get; set; }
    public string? PromotionCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? Status { get; set; }
    public decimal? UsedInResvNameId { get; set; }
    public string? UsedInResvResort { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? ExportDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OneTimePromoCoupons>(entity =>
        {
            entity.HasKey(e => new { e.CouponId, e.BatchCode })
                .HasName("ONE_TIME_PROMO_COUPON_PK");

            entity.ToTable("ONE_TIME_PROMO_COUPONS");

            entity.HasIndex(e => e.BatchCode)
                .HasName("ONE_TIME_PROMO_COUPON_IDX3");

            entity.HasIndex(e => e.CouponCode)
                .HasName("ONE_TIME_PROMO_COUPON_IDX1")
                .IsUnique();

            entity.HasIndex(e => new { e.UsedInResvNameId, e.UsedInResvResort })
                .HasName("ONE_TIME_PROMO_COUPON_IDX4");

            entity.HasIndex(e => new { e.PromotionCode, e.Resort, e.BatchCode })
                .HasName("ONE_TIME_PROMO_COUPON_IDX2");

            entity.Property(e => e.CouponId)
                .HasColumnName("COUPON_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BatchCode)
                .HasColumnName("BATCH_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CouponCode)
                .IsRequired()
                .HasColumnName("COUPON_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportDate)
                .HasColumnName("EXPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UsedInResvNameId)
                .HasColumnName("USED_IN_RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UsedInResvResort)
                .HasColumnName("USED_IN_RESV_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
