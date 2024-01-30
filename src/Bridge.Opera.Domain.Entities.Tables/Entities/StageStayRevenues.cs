namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageStayRevenues
{
    public decimal? StageStayRecordId { get; set; }
    public DateTime? TrxDate { get; set; }
    public string? RevenueType { get; set; }
    public decimal? RevenueAmount { get; set; }
    public string? ValidYn { get; set; }
    public decimal? StageStayRevDtlId { get; set; }

    public virtual StageStayRecords StageStayRecord { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageStayRevenues>(entity =>
        {
            entity.HasKey(e => new { e.StageStayRecordId, e.RevenueType, e.TrxDate })
                .HasName("STAGE_STAY_REVENUES_PK");

            entity.ToTable("STAGE_STAY_REVENUES");

            entity.Property(e => e.StageStayRecordId)
                .HasColumnName("STAGE_STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueType)
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RevenueAmount)
                .HasColumnName("REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StageStayRevDtlId)
                .HasColumnName("STAGE_STAY_REV_DTL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(StageStayRecords)))
				entity.Ignore(e => e.StageStayRecord);
			else
	            entity.HasOne(d => d.StageStayRecord)
	                .WithMany(p => p.StageStayRevenues)
	                .HasForeignKey(d => d.StageStayRecordId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("STAGE_STAY_REVENUES_FK");
        });
	}
}
