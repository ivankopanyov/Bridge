namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PromoRates
{
    public string? PromoCode { get; set; }
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? RateUseDesc { get; set; }

    public virtual Promotions Promotions { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PromoRates>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.PromoCode, e.RateCode })
                .HasName("PROMO_RATES_PK");

            entity.ToTable("PROMO_RATES");

            entity.HasIndex(e => new { e.Resort, e.RateCode, e.PromoCode })
                .HasName("PROMO_RATES_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PromoCode)
                .HasColumnName("PROMO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateUseDesc)
                .HasColumnName("RATE_USE_DESC")
                .HasMaxLength(10)
                .IsUnicode(false);

			if (!types.Contains(typeof(Promotions)))
				entity.Ignore(e => e.Promotions);
			else
	            entity.HasOne(d => d.Promotions)
	                .WithMany(p => p.PromoRates)
	                .HasPrincipalKey(p => new { p.Resort, p.PromoCode })
	                .HasForeignKey(d => new { d.Resort, d.PromoCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("PROMO_RATES_FK");
        });
	}
}
