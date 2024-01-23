namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageRecordErrors
{
    public decimal StageRecordId { get; set; }
    public string StageTable { get; set; }
    public string ErrorField { get; set; }
    public string ErrorDesc { get; set; }
    public string ErrorValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageRecordErrors>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_RECORD_ERRORS");

            entity.HasIndex(e => new { e.StageRecordId, e.StageTable, e.ErrorField })
                .HasName("STAGE_RECORD_ERRORS_IND1");

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ErrorField)
                .IsRequired()
                .HasColumnName("ERROR_FIELD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ErrorValue)
                .HasColumnName("ERROR_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.StageRecordId)
                .HasColumnName("STAGE_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StageTable)
                .IsRequired()
                .HasColumnName("STAGE_TABLE")
                .HasMaxLength(50)
                .IsUnicode(false);
        });
	}
}
