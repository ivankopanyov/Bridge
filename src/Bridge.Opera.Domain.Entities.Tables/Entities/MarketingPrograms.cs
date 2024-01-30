namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MarketingPrograms
{
    public MarketingPrograms()
    {
        Awards = new HashSet<Awards>();
        Promotions = new HashSet<Promotions>();
    }

    public string? Resort { get; set; }
    public string? Mpcode { get; set; }
    public string? MpPlan { get; set; }
    public string? MpName { get; set; }
    public string? MpType { get; set; }
    public string? MpForAirlineYn { get; set; }
    public string? RevenueBasedYn { get; set; }
    public string? LocalCurrencyYn { get; set; }
    public string? ProgramCurrencyCode { get; set; }
    public string? ExchangeRateTypeCde { get; set; }
    public byte? MinimumMembershipLength { get; set; }
    public string? MpIdEmul { get; set; }

    public virtual ICollection<Awards> Awards { get; set; }
    public virtual ICollection<Promotions> Promotions { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MarketingPrograms>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Mpcode })
                .HasName("MARKETING_PROGRAMS_PK");

            entity.ToTable("MARKETING_PROGRAMS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Mpcode)
                .HasColumnName("MPCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRateTypeCde)
                .HasColumnName("EXCHANGE_RATE_TYPE_CDE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.LocalCurrencyYn)
                .HasColumnName("LOCAL_CURRENCY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MinimumMembershipLength)
                .HasColumnName("MINIMUM_MEMBERSHIP_LENGTH")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.MpForAirlineYn)
                .HasColumnName("MP_FOR_AIRLINE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MpIdEmul)
                .HasColumnName("MP_ID_EMUL")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.MpName)
                .HasColumnName("MP_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MpPlan)
                .HasColumnName("MP_PLAN")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MpType)
                .HasColumnName("MP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProgramCurrencyCode)
                .HasColumnName("PROGRAM_CURRENCY_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.RevenueBasedYn)
                .HasColumnName("REVENUE_BASED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(Awards)))
				entity.Ignore(e => e.Awards);

			if (!types.Contains(typeof(Promotions)))
				entity.Ignore(e => e.Promotions);
		});
	}
}
