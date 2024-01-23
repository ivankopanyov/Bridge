namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmProfileSegBatchesBe
{
    public decimal SegBatchId { get; set; }
    public decimal DataElementId { get; set; }
    public string BeHeaderPk { get; set; }
    public string Module { get; set; }
    public decimal ActionInstanceId { get; set; }
    public string DataElement { get; set; }
    public string OldValue { get; set; }
    public string NewValue { get; set; }
    public DateTime? ScopeFrom { get; set; }
    public DateTime? ScopeTo { get; set; }
    public decimal? ElementSeq { get; set; }
    public string ElementType { get; set; }
    public string ElementRole { get; set; }
    public string Resort { get; set; }
    public string ActionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmProfileSegBatchesBe>(entity =>
        {
            entity.HasKey(e => new { e.SegBatchId, e.DataElementId })
                .HasName("OCRM_PROF_SEG_BATCH_BE_PK");

            entity.ToTable("OCRM_PROFILE_SEG_BATCHES_BE");

            entity.HasIndex(e => new { e.SegBatchId, e.DataElement })
                .HasName("OCRM_PROF_SEG_BATCH_BE_IDX");

            entity.Property(e => e.SegBatchId)
                .HasColumnName("SEG_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataElementId)
                .HasColumnName("DATA_ELEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BeHeaderPk)
                .IsRequired()
                .HasColumnName("BE_HEADER_PK")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.DataElement)
                .IsRequired()
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ElementRole)
                .HasColumnName("ELEMENT_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ElementSeq)
                .HasColumnName("ELEMENT_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ElementType)
                .HasColumnName("ELEMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OldValue)
                .HasColumnName("OLD_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScopeFrom)
                .HasColumnName("SCOPE_FROM")
                .HasColumnType("DATE");

            entity.Property(e => e.ScopeTo)
                .HasColumnName("SCOPE_TO")
                .HasColumnType("DATE");
        });
	}
}
