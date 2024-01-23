namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HkDailyTaskView
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
    public string EmpId { get; set; }
    public decimal? RoomCount { get; set; }
    public string EmpSection { get; set; }
    public string SimpleTaskYn { get; set; }
    public decimal? TravelingCredits { get; set; }
    public string TaskSheetType { get; set; }
    public decimal? HkBreakoutJobId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HkDailyTaskView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HK_DAILY_TASK_VIEW");

            entity.Property(e => e.AutoGenerateFilters)
                .HasColumnName("AUTO_GENERATE_FILTERS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AutoGenerateInd)
                .HasColumnName("AUTO_GENERATE_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmpId)
                .HasColumnName("EMP_ID")
                .HasMaxLength(600)
                .IsUnicode(false);

            entity.Property(e => e.EmpSection)
                .HasColumnName("EMP_SECTION")
                .HasMaxLength(600)
                .IsUnicode(false);

            entity.Property(e => e.HkBreakoutJobId)
                .HasColumnName("HK_BREAKOUT_JOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCount)
                .HasColumnName("ROOM_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SimpleTaskYn)
                .HasColumnName("SIMPLE_TASK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasMaxLength(20)
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

            entity.Property(e => e.TaskSheetType)
                .HasColumnName("TASK_SHEET_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TravelingCredits)
                .HasColumnName("TRAVELING_CREDITS")
                .HasColumnType("NUMBER");
        });
	}
}
