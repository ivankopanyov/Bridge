namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpScactivityView
{
    public decimal? ActId { get; set; }
    public string? Resort { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Purpose { get; set; }
    public string? AssignedBy { get; set; }
    public DateTime? AssignedOnDate { get; set; }
    public string? AssignedTo { get; set; }
    public decimal? CompletedBy { get; set; }
    public DateTime? CompletedDate { get; set; }
    public DateTime? DueDate { get; set; }
    public string? UserExt { get; set; }
    public string? DeptOfAction { get; set; }
    public decimal? Duration { get; set; }
    public string? DurationTimeCode { get; set; }
    public string? DurationTimeDesc { get; set; }
    public string? CategoryCode { get; set; }
    public string? ReasonCode { get; set; }
    public string? LocationCode { get; set; }
    public string? PriorityCode { get; set; }
    public decimal? ParentActId { get; set; }
    public string? StatusCode { get; set; }
    public decimal? TaskCode { get; set; }
    public decimal? TaskitemNumber { get; set; }
    public string? ActType { get; set; }
    public decimal? DependingOnActId { get; set; }
    public string? MasterSub { get; set; }
    public string? Room { get; set; }
    public string? Notes { get; set; }
    public string? CreatedByUser { get; set; }
    public string? TakenByUser { get; set; }
    public string? AssignedByUser { get; set; }
    public string? AssignedToUser { get; set; }
    public string? ReleasedByUser { get; set; }
    public string? CompletedByUser { get; set; }
    public string? PrivateYn { get; set; }
    public decimal? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? ProblemDesc { get; set; }
    public decimal? EstTimeToComplete { get; set; }
    public string? Tracecode { get; set; }
    public decimal? AccId { get; set; }
    public string? AccName { get; set; }
    public decimal? ConId { get; set; }
    public string? ConName { get; set; }
    public decimal? BusblockId { get; set; }
    public string? BusblockName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpScactivityView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SCACTIVITY_VIEW");

            entity.Property(e => e.AccId)
                .HasColumnName("ACC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccName)
                .HasColumnName("ACC_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ActId)
                .HasColumnName("ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActType)
                .HasColumnName("ACT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AssignedBy)
                .HasColumnName("ASSIGNED_BY")
                .IsUnicode(false);

            entity.Property(e => e.AssignedByUser)
                .HasColumnName("ASSIGNED_BY_USER")
                .IsUnicode(false);

            entity.Property(e => e.AssignedOnDate)
                .HasColumnName("ASSIGNED_ON_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AssignedTo)
                .HasColumnName("ASSIGNED_TO")
                .IsUnicode(false);

            entity.Property(e => e.AssignedToUser)
                .HasColumnName("ASSIGNED_TO_USER")
                .IsUnicode(false);

            entity.Property(e => e.BusblockId)
                .HasColumnName("BUSBLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusblockName)
                .HasColumnName("BUSBLOCK_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CategoryCode)
                .HasColumnName("CATEGORY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompletedBy)
                .HasColumnName("COMPLETED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompletedByUser)
                .HasColumnName("COMPLETED_BY_USER")
                .IsUnicode(false);

            entity.Property(e => e.CompletedDate)
                .HasColumnName("COMPLETED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ConId)
                .HasColumnName("CON_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConName)
                .HasColumnName("CON_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CreatedBy)
                .HasColumnName("CREATED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreatedByUser)
                .HasColumnName("CREATED_BY_USER")
                .IsUnicode(false);

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CREATED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DependingOnActId)
                .HasColumnName("DEPENDING_ON_ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeptOfAction)
                .HasColumnName("DEPT_OF_ACTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DueDate)
                .HasColumnName("DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Duration)
                .HasColumnName("DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DurationTimeCode)
                .HasColumnName("DURATION_TIME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DurationTimeDesc)
                .HasColumnName("DURATION_TIME_DESC")
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EstTimeToComplete)
                .HasColumnName("EST_TIME_TO_COMPLETE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocationCode)
                .HasColumnName("LOCATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MasterSub)
                .HasColumnName("MASTER_SUB")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .IsUnicode(false);

            entity.Property(e => e.ParentActId)
                .HasColumnName("PARENT_ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriorityCode)
                .HasColumnName("PRIORITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrivateYn)
                .HasColumnName("PRIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProblemDesc)
                .HasColumnName("PROBLEM_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Purpose)
                .HasColumnName("PURPOSE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReleasedByUser)
                .HasColumnName("RELEASED_BY_USER")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StatusCode)
                .HasColumnName("STATUS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TakenByUser)
                .HasColumnName("TAKEN_BY_USER")
                .IsUnicode(false);

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaskitemNumber)
                .HasColumnName("TASKITEM_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tracecode)
                .HasColumnName("TRACECODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserExt)
                .HasColumnName("USER_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
