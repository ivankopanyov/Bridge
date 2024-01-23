namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortHkDailyTask
{
    public ResortHkDailyTask()
    {
        HkDailyTaskRoom = new HashSet<HkDailyTaskRoom>();
    }

    public decimal TaskSeqNo { get; set; }
    public DateTime TaskDate { get; set; }
    public string TaskCode { get; set; }
    public decimal TaskSheetNo { get; set; }
    public string Resort { get; set; }
    public DateTime? TaskCompletedDate { get; set; }
    public decimal? TaskCredits { get; set; }
    public string TaskInstructions { get; set; }
    public string AutoGenerateInd { get; set; }
    public string AutoGenerateFilters { get; set; }
    public string SimpleTaskYn { get; set; }
    public decimal? TravelingCredits { get; set; }
    public string TaskSheetType { get; set; }
    public decimal? HkBreakoutJobId { get; set; }

    public virtual ResortHkBreakout HkBreakoutJob { get; set; }
    public virtual ResortHkTasks ResortHkTasks { get; set; }
    public virtual ICollection<HkDailyTaskRoom> HkDailyTaskRoom { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortHkDailyTask>(entity =>
        {
            entity.HasKey(e => e.TaskSeqNo)
                .HasName("HK_TASKS_DAILY_PK");

            entity.ToTable("RESORT_HK_DAILY_TASK");

            entity.HasIndex(e => e.HkBreakoutJobId)
                .HasName("HK_TASKS_BREAKOUT_FKI");

            entity.HasIndex(e => new { e.Resort, e.TaskCode })
                .HasName("HK_TASKS_FKI");

            entity.HasIndex(e => new { e.TaskDate, e.TaskCode, e.TaskSheetNo, e.Resort })
                .HasName("HK_TASK_SHEET_IDX");

            entity.Property(e => e.TaskSeqNo)
                .HasColumnName("TASK_SEQ_NO")
                .HasColumnType("NUMBER(20)");

            entity.Property(e => e.AutoGenerateFilters)
                .HasColumnName("AUTO_GENERATE_FILTERS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AutoGenerateInd)
                .HasColumnName("AUTO_GENERATE_IND")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.HkBreakoutJobId)
                .HasColumnName("HK_BREAKOUT_JOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SimpleTaskYn)
                .HasColumnName("SIMPLE_TASK_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaskCompletedDate)
                .HasColumnName("TASK_COMPLETED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaskCredits)
                .HasColumnName("TASK_CREDITS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaskDate)
                .HasColumnName("TASK_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaskInstructions)
                .HasColumnName("TASK_INSTRUCTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaskSheetNo)
                .HasColumnName("TASK_SHEET_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaskSheetType)
                .HasColumnName("TASK_SHEET_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TravelingCredits)
                .HasColumnName("TRAVELING_CREDITS")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ResortHkBreakout)))
				entity.Ignore(e => e.HkBreakoutJob);
			else
	            entity.HasOne(d => d.HkBreakoutJob)
	                .WithMany(p => p.ResortHkDailyTask)
	                .HasForeignKey(d => d.HkBreakoutJobId)
	                .HasConstraintName("HK_TASKS_BREAKOUT_FK");

			if (!types.Contains(typeof(ResortHkTasks)))
				entity.Ignore(e => e.ResortHkTasks);
			else
	            entity.HasOne(d => d.ResortHkTasks)
	                .WithMany(p => p.ResortHkDailyTask)
	                .HasPrincipalKey(p => new { p.Resort, p.TaskCode })
	                .HasForeignKey(d => new { d.Resort, d.TaskCode })
	                .HasConstraintName("HK_TASKS_FK");
        
			if (!types.Contains(typeof(HkDailyTaskRoom)))
				entity.Ignore(e => e.HkDailyTaskRoom);
		});
	}
}
