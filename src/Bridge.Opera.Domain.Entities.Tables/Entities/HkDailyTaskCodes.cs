namespace Bridge.Opera.Domain.Entities.Tables;

public partial class HkDailyTaskCodes
{
    public decimal? TaskSeqNo { get; set; }
    public string? TaskCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HkDailyTaskCodes>(entity =>
        {
            entity.HasKey(e => new { e.TaskSeqNo, e.TaskCode })
                .HasName("HK_DTC_PK");

            entity.ToTable("HK_DAILY_TASK_CODES");

            entity.Property(e => e.TaskSeqNo)
                .HasColumnName("TASK_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
