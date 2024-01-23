namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmProfileSegBatches
{
    public decimal SegBatchId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Status { get; set; }
    public decimal SegId { get; set; }
    public decimal? RecordCount { get; set; }
    public string JobNameId { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? ParamListId { get; set; }
    public decimal? TaskInstId { get; set; }
    public string EspBatchCode { get; set; }

    public virtual OcrmProfileSegHdr Seg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmProfileSegBatches>(entity =>
        {
            entity.HasKey(e => e.SegBatchId)
                .HasName("OPNS_PK");

            entity.ToTable("OCRM_PROFILE_SEG_BATCHES");

            entity.HasIndex(e => new { e.SegId, e.Status })
                .HasName("OCRM_SEG_BATCH_IND01");

            entity.Property(e => e.SegBatchId)
                .HasColumnName("SEG_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EspBatchCode)
                .HasColumnName("ESP_BATCH_CODE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobNameId)
                .HasColumnName("JOB_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ParamListId)
                .HasColumnName("PARAM_LIST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordCount)
                .HasColumnName("RECORD_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SegId)
                .HasColumnName("SEG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaskInstId)
                .HasColumnName("TASK_INST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(OcrmProfileSegHdr)))
				entity.Ignore(e => e.Seg);
			else
	            entity.HasOne(d => d.Seg)
	                .WithMany(p => p.OcrmProfileSegBatches)
	                .HasForeignKey(d => d.SegId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("OCRM_PROF_SEG_BAT_FK01");
        });
	}
}
