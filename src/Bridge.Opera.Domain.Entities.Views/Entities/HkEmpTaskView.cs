namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HkEmpTaskView
{
    public decimal? ReportId { get; set; }
    public decimal TaskSeqNo { get; set; }
    public decimal? CntRep { get; set; }
    public DateTime TaskDate { get; set; }
    public string TaskCode { get; set; }
    public decimal TaskSheetNo { get; set; }
    public DateTime? TaskCompletedDate { get; set; }
    public decimal? TaskCredits { get; set; }
    public string TaskInstructions { get; set; }
    public string AutoGenerateInd { get; set; }
    public string AutoGenerateFilters { get; set; }
    public string Description { get; set; }
    public string Frequency { get; set; }
    public string UnitOfFrequency { get; set; }
    public string EmpId { get; set; }
    public string EmpName { get; set; }
    public string EmpInstructions { get; set; }
    public string Resort { get; set; }
    public string Room { get; set; }
    public decimal? Credits { get; set; }
    public string RoomInstructions { get; set; }
    public string RoomStatus { get; set; }
    public string Class { get; set; }
    public decimal? ReservationStatus { get; set; }
    public string FoStatus { get; set; }
    public string Type { get; set; }
    public string RoomCategory { get; set; }
    public string Turndown { get; set; }
    public string SimpleTaskYn { get; set; }
    public string ServiceTime { get; set; }
    public string AssignType { get; set; }
    public string AssignReason { get; set; }
    public string AssignStatus { get; set; }
    public decimal? TravelingCredits { get; set; }
    public string TaskSheetType { get; set; }
    public decimal? HkBreakoutJobId { get; set; }
    public string TaskSheetNoDisplay { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HkEmpTaskView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HK_EMP_TASK_VIEW");

            entity.Property(e => e.AssignReason)
                .HasColumnName("ASSIGN_REASON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AssignStatus)
                .HasColumnName("ASSIGN_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AssignType)
                .HasColumnName("ASSIGN_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AutoGenerateFilters)
                .HasColumnName("AUTO_GENERATE_FILTERS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AutoGenerateInd)
                .HasColumnName("AUTO_GENERATE_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Class)
                .HasColumnName("CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CntRep)
                .HasColumnName("CNT_REP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Credits)
                .HasColumnName("CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EmpId)
                .HasColumnName("EMP_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmpInstructions)
                .HasColumnName("EMP_INSTRUCTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EmpName)
                .HasColumnName("EMP_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FoStatus)
                .HasColumnName("FO_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasColumnType("CHAR(2000)");

            entity.Property(e => e.HkBreakoutJobId)
                .HasColumnName("HK_BREAKOUT_JOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationStatus)
                .HasColumnName("RESERVATION_STATUS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomInstructions)
                .HasColumnName("ROOM_INSTRUCTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomStatus)
                .HasColumnName("ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ServiceTime)
                .HasColumnName("SERVICE_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

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

            entity.Property(e => e.TaskSheetNoDisplay)
                .HasColumnName("TASK_SHEET_NO_DISPLAY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TaskSheetType)
                .HasColumnName("TASK_SHEET_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TravelingCredits)
                .HasColumnName("TRAVELING_CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Turndown)
                .HasColumnName("TURNDOWN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UnitOfFrequency)
                .HasColumnName("UNIT_OF_FREQUENCY")
                .HasColumnType("CHAR(2000)");
        });
	}
}
