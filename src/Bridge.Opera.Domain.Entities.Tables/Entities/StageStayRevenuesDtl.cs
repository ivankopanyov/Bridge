namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageStayRevenuesDtl
{
    public decimal? StageStayRecordId { get; set; }
    public decimal? StageStayRevDtlId { get; set; }
    public string? FolioView { get; set; }
    public decimal? RevenueAmount { get; set; }

    public virtual StageStayRecords StageStayRecord { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageStayRevenuesDtl>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_STAY_REVENUES_DTL");

            entity.HasIndex(e => new { e.StageStayRecordId, e.StageStayRevDtlId })
                .HasName("STAGE_STAY_REV_D_IND1");

            entity.Property(e => e.FolioView)
                .IsRequired()
                .HasColumnName("FOLIO_VIEW")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RevenueAmount)
                .HasColumnName("REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StageStayRecordId)
                .HasColumnName("STAGE_STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StageStayRevDtlId)
                .HasColumnName("STAGE_STAY_REV_DTL_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(StageStayRecords)))
				entity.Ignore(e => e.StageStayRecord);
			else
	            entity.HasOne(d => d.StageStayRecord)
	                .WithMany()
	                .HasForeignKey(d => d.StageStayRecordId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("STAGE_STAY_REVENUES_D_FK");
        });
	}
}
