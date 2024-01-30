namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ForeignCurrencyLimits
{
    public string? CurrencyCode { get; set; }
    public string? LocalYn { get; set; }
    public string? ChainCode { get; set; }
    public decimal? DailyLimit { get; set; }
    public decimal? MonthlyLimit { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ForeignCurrency C { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ForeignCurrencyLimits>(entity =>
        {
            entity.HasKey(e => new { e.CurrencyCode, e.LocalYn })
                .HasName("FOREIGN_CURRENCY_LIMITS_PK");

            entity.ToTable("FOREIGN_CURRENCY_LIMITS");

            entity.HasIndex(e => new { e.ChainCode, e.CurrencyCode })
                .HasName("FCURR_FCURRLIM_FKI");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LocalYn)
                .HasColumnName("LOCAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DailyLimit)
                .HasColumnName("DAILY_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthlyLimit)
                .HasColumnName("MONTHLY_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ForeignCurrency)))
				entity.Ignore(e => e.C);
			else
	            entity.HasOne(d => d.C)
	                .WithMany(p => p.ForeignCurrencyLimits)
	                .HasForeignKey(d => new { d.ChainCode, d.CurrencyCode })
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("FCURR_FCURRLIM_FK");
        });
	}
}
