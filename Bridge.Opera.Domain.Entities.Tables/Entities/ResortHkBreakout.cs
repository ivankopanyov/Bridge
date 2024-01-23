namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortHkBreakout
{
    public ResortHkBreakout()
    {
        ResortHkDailyTask = new HashSet<ResortHkDailyTask>();
    }

    public decimal HkBreakoutJobId { get; set; }
    public string Resort { get; set; }
    public DateTime TaskDate { get; set; }
    public string AutoAssignmentYn { get; set; }
    public string TaskCodesList { get; set; }
    public decimal? NumOfAttendants { get; set; }
    public string RoomStatusList { get; set; }
    public string FoStatusList { get; set; }
    public string ExcludeOwnerRooms { get; set; }
    public string ExcludeOwnerFfOccupied { get; set; }
    public string RoomClassList { get; set; }
    public decimal? MaximumCredits { get; set; }
    public string ResvStatusList { get; set; }
    public string ExcludeCoAfter { get; set; }
    public string ExcludeCoBefore { get; set; }
    public string TaskInstruction { get; set; }
    public string AttendantInstruction { get; set; }
    public string RoomInstruction { get; set; }
    public string ExcludeVipList { get; set; }
    public string VipOnlyYn { get; set; }
    public string AssignmentOrder { get; set; }
    public string IsolatedRateCodes { get; set; }
    public string IsolatedRooms { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual ICollection<ResortHkDailyTask> ResortHkDailyTask { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortHkBreakout>(entity =>
        {
            entity.HasKey(e => e.HkBreakoutJobId)
                .HasName("RESORT_HK_BREAKOUT");

            entity.ToTable("RESORT_HK_BREAKOUT");

            entity.Property(e => e.HkBreakoutJobId)
                .HasColumnName("HK_BREAKOUT_JOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AssignmentOrder)
                .HasColumnName("ASSIGNMENT_ORDER")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.AttendantInstruction)
                .HasColumnName("ATTENDANT_INSTRUCTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AutoAssignmentYn)
                .IsRequired()
                .HasColumnName("AUTO_ASSIGNMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.ExcludeCoAfter)
                .HasColumnName("EXCLUDE_CO_AFTER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExcludeCoBefore)
                .HasColumnName("EXCLUDE_CO_BEFORE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExcludeOwnerFfOccupied)
                .HasColumnName("EXCLUDE_OWNER_FF_OCCUPIED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExcludeOwnerRooms)
                .HasColumnName("EXCLUDE_OWNER_ROOMS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExcludeVipList)
                .HasColumnName("EXCLUDE_VIP_LIST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FoStatusList)
                .HasColumnName("FO_STATUS_LIST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsolatedRateCodes)
                .HasColumnName("ISOLATED_RATE_CODES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IsolatedRooms)
                .HasColumnName("ISOLATED_ROOMS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MaximumCredits)
                .HasColumnName("MAXIMUM_CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumOfAttendants)
                .HasColumnName("NUM_OF_ATTENDANTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvStatusList)
                .HasColumnName("RESV_STATUS_LIST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomClassList)
                .HasColumnName("ROOM_CLASS_LIST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomInstruction)
                .HasColumnName("ROOM_INSTRUCTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomStatusList)
                .HasColumnName("ROOM_STATUS_LIST")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaskCodesList)
                .IsRequired()
                .HasColumnName("TASK_CODES_LIST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaskDate)
                .HasColumnName("TASK_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaskInstruction)
                .HasColumnName("TASK_INSTRUCTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VipOnlyYn)
                .HasColumnName("VIP_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(ResortHkDailyTask)))
				entity.Ignore(e => e.ResortHkDailyTask);
		});
	}
}
