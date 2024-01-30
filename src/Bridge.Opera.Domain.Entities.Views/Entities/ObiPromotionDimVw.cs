namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiPromotionDimVw
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? PromoCode { get; set; }
    public string? PromoDesc { get; set; }
    public string? Mpcode { get; set; }
    public string? MpcodeDesc { get; set; }
    public string? ResortId { get; set; }
    public string? PromoCodeKey { get; set; }
    public string? MpcodeKey { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiPromotionDimVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PROMOTION_DIM_VW");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.Mpcode)
                .HasColumnName("MPCODE")
                .IsUnicode(false);

            entity.Property(e => e.MpcodeDesc)
                .HasColumnName("MPCODE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MpcodeKey)
                .HasColumnName("MPCODE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.PromoCode)
                .HasColumnName("PROMO_CODE")
                .IsUnicode(false);

            entity.Property(e => e.PromoCodeKey)
                .HasColumnName("PROMO_CODE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.PromoDesc)
                .HasColumnName("PROMO_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);
        });
	}
}
