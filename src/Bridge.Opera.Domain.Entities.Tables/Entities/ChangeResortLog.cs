namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ChangeResortLog
{
    public string? TableName { get; set; }
    public string? ConstraintName { get; set; }
    public string? TriggerName { get; set; }
    public string? ColumnName { get; set; }
    public string? IntendedAction { get; set; }
    public string? ActionResult { get; set; }
    public string? ErrorCode { get; set; }
    public string? ErrorMessage { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? SequenceNumber { get; set; }
    public string? FromResort { get; set; }
    public string? ToResort { get; set; }
    public string? SuccessYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ChangeResortLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CHANGE_RESORT_LOG");

            entity.Property(e => e.ActionResult)
                .HasColumnName("ACTION_RESULT")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ColumnName)
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ConstraintName)
                .HasColumnName("CONSTRAINT_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ErrorCode)
                .HasColumnName("ERROR_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasColumnName("ERROR_MESSAGE")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.FromResort)
                .HasColumnName("FROM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IntendedAction)
                .HasColumnName("INTENDED_ACTION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SequenceNumber)
                .HasColumnName("SEQUENCE_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SuccessYn)
                .HasColumnName("SUCCESS_YN")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ToResort)
                .HasColumnName("TO_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TriggerName)
                .HasColumnName("TRIGGER_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);
        });
	}
}
