namespace Bridge.Opera.Domain.Entities.Tables;

public partial class YmRateSetAdjustments
{
    public string? Resort { get; set; }
    public decimal? RateSetId { get; set; }
    public string? AdjustmentCode { get; set; }
    public decimal? AdjustmentAmount { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual RateSet RateSet { get; set; }
    public virtual YmAdjustmentCodes YmAdjustmentCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<YmRateSetAdjustments>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateSetId, e.AdjustmentCode })
                .HasName("YM_RATE_ADJUSTMENTS_PK");

            entity.ToTable("YM_RATE_SET_ADJUSTMENTS");

            entity.HasIndex(e => e.RateSetId)
                .HasName("YM_RATE_SET_ADJ_RATESET_IDX");

            entity.HasIndex(e => new { e.Resort, e.AdjustmentCode })
                .HasName("YM_RATE_SET_ADJ_CODE_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateSetId)
                .HasColumnName("RATE_SET_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AdjustmentCode)
                .HasColumnName("ADJUSTMENT_CODE")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AdjustmentAmount)
                .HasColumnName("ADJUSTMENT_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(RateSet)))
				entity.Ignore(e => e.RateSet);
			else
	            entity.HasOne(d => d.RateSet)
	                .WithMany(p => p.YmRateSetAdjustments)
	                .HasForeignKey(d => d.RateSetId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("YM_RATE_ADJUST_RATE_SET_FK");

			if (!types.Contains(typeof(YmAdjustmentCodes)))
				entity.Ignore(e => e.YmAdjustmentCodes);
			else
	            entity.HasOne(d => d.YmAdjustmentCodes)
	                .WithMany(p => p.YmRateSetAdjustments)
	                .HasForeignKey(d => new { d.Resort, d.AdjustmentCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("YM_RATE_ADJ_YM_ADJ_FK");
        });
	}
}
