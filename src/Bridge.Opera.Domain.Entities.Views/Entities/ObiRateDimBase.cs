namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRateDimBase
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? RateDesc { get; set; }
    public string? RateCategory { get; set; }
    public string? RateCategoryDesc { get; set; }
    public string? RateClass { get; set; }
    public string? RateClassDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string? YieldableYn { get; set; }
    public string? NegotiatedYn { get; set; }
    public string? ComplimentaryYn { get; set; }
    public string? HouseUseYn { get; set; }
    public string? GdsAllowedYn { get; set; }
    public string? LoyaltyProgramYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRateDimBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_RATE_DIM_BASE");

            entity.Property(e => e.ComplimentaryYn)
                .HasColumnName("COMPLIMENTARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GdsAllowedYn)
                .HasColumnName("GDS_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HouseUseYn)
                .HasColumnName("HOUSE_USE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyProgramYn)
                .HasColumnName("LOYALTY_PROGRAM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NegotiatedYn)
                .HasColumnName("NEGOTIATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .IsRequired()
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCategoryDesc)
                .HasColumnName("RATE_CATEGORY_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RateClass)
                .IsRequired()
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateClassDesc)
                .HasColumnName("RATE_CLASS_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateDesc)
                .HasColumnName("RATE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YieldableYn)
                .HasColumnName("YIELDABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
