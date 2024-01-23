namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageStayErrors
{
    public decimal StageStayRecordId { get; set; }
    public string ErrorField { get; set; }
    public string ErrorDesc { get; set; }
    public string ErrorValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageStayErrors>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_STAY_ERRORS");

            entity.HasIndex(e => new { e.StageStayRecordId, e.ErrorField })
                .HasName("STAGE_STAY_RECORDS_IND1");

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

            entity.Property(e => e.StageStayRecordId)
                .HasColumnName("STAGE_STAY_RECORD_ID")
                .HasColumnType("NUMBER");
        });
	}
}
