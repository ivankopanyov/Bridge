namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateDailyRanking
{
    public decimal RateDailyRankingId { get; set; }
    public string Resort { get; set; }
    public string RateCode { get; set; }
    public DateTime BookingBeginDate { get; set; }
    public DateTime BookingEndDate { get; set; }
    public decimal? RankValue { get; set; }
    public decimal? RankAdjustmentFactor { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual RateHeader R { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateDailyRanking>(entity =>
        {
            entity.ToTable("RATE_DAILY_RANKING");

            entity.HasIndex(e => new { e.Resort, e.RateCode })
                .HasName("RDR_RH_FKI");

            entity.HasIndex(e => new { e.Resort, e.RateCode, e.BookingBeginDate, e.BookingEndDate })
                .HasName("RATE_DAILY_RANKING_UK")
                .IsUnique();

            entity.Property(e => e.RateDailyRankingId)
                .HasColumnName("RATE_DAILY_RANKING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingBeginDate)
                .HasColumnName("BOOKING_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingEndDate)
                .HasColumnName("BOOKING_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RankAdjustmentFactor)
                .HasColumnName("RANK_ADJUSTMENT_FACTOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RankValue)
                .HasColumnName("RANK_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(RateHeader)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.RateDailyRanking)
	                .HasForeignKey(d => new { d.Resort, d.RateCode })
	                .HasConstraintName("RDR_RH_FK");
        });
	}
}
