namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PromotionPayType
{
    public string? Resort { get; set; }
    public string? PromoCode { get; set; }
    public string? CardType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PromotionPayType>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.PromoCode, e.CardType })
                .HasName("PPE_PK");

            entity.ToTable("PROMOTION_PAY_TYPE");

            entity.HasIndex(e => new { e.CardType, e.Resort })
                .HasName("PROMOTION_PAY_TYPE_IDX1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromoCode)
                .HasColumnName("PROMO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CardType)
                .HasColumnName("CARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
