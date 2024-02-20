namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AwardRateCodes
{
    public decimal? AwardSeqId { get; set; }
    public string? Resort { get; set; }
    public string? AwardCode { get; set; }
    public string? RateCode { get; set; }

    public virtual Awards AwardSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AwardRateCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AWARD_RATE_CODES");

            entity.HasIndex(e => e.AwardSeqId)
                .HasName("AWARD_RATES_SEQ_IDX");

            entity.HasIndex(e => new { e.Resort, e.RateCode })
                .HasName("AWARD_RATE_IDX");

            entity.HasIndex(e => new { e.Resort, e.AwardCode, e.RateCode })
                .HasName("AWARD_RATECODES_UK")
                .IsUnique();

            entity.Property(e => e.AwardCode)
                .IsRequired()
                .HasColumnName("AWARD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardSeqId)
                .HasColumnName("AWARD_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(Awards)))
				entity.Ignore(e => e.AwardSeq);
			else
	            entity.HasOne(d => d.AwardSeq)
	                .WithMany()
	                .HasForeignKey(d => d.AwardSeqId)
	                .HasConstraintName("AWARD_SEQ_FK");
        });
	}
}
