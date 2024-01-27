namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HkFacDailyTaskView
{
    public decimal TaskSeqNo { get; set; }
    public DateTime TaskDate { get; set; }
    public string TaskCode { get; set; }
    public decimal TaskSheetNo { get; set; }
    public DateTime? TaskCompletedDate { get; set; }
    public decimal? TaskCredits { get; set; }
    public string TaskInstructions { get; set; }
    public string AutoGenerateInd { get; set; }
    public string AutoGenerateFilters { get; set; }
    public string SimpleTaskYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HkFacDailyTaskView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HK_FAC_DAILY_TASK_VIEW");

            entity.Property(e => e.AutoGenerateFilters)
                .HasColumnName("AUTO_GENERATE_FILTERS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AutoGenerateInd)
                .HasColumnName("AUTO_GENERATE_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SimpleTaskYn)
                .HasColumnName("SIMPLE_TASK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .IsUnicode(false);

            entity.Property(e => e.TaskCompletedDate)
                .HasColumnName("TASK_COMPLETED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaskCredits)
                .HasColumnName("TASK_CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaskDate)
                .HasColumnName("TASK_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaskInstructions)
                .HasColumnName("TASK_INSTRUCTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaskSeqNo)
                .HasColumnName("TASK_SEQ_NO")
                .HasColumnType("NUMBER(20)");

            entity.Property(e => e.TaskSheetNo)
                .HasColumnName("TASK_SHEET_NO")
                .HasColumnType("NUMBER");
        });
	}
}
