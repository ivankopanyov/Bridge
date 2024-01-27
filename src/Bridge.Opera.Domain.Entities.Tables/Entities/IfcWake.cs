namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcWake
{
    public string WakeDest { get; set; }
    public string Command { get; set; }
    public string Result { get; set; }
    public string FailCause { get; set; }
    public string RoomNum { get; set; }
    public string LineNum { get; set; }
    public DateTime WakeDate { get; set; }
    public DateTime WakeTime { get; set; }
    public string WakeLang { get; set; }
    public DateTime? SetDate { get; set; }
    public DateTime? SetTime { get; set; }
    public string SetLogin { get; set; }
    public DateTime? ResDate { get; set; }
    public DateTime? ResTime { get; set; }
    public string ResLogin { get; set; }
    public decimal? WakeRetry { get; set; }
    public string WakeStart { get; set; }
    public string GroupCode { get; set; }
    public string Resort { get; set; }
    public string ExtnNum { get; set; }
    public string ExtnType { get; set; }
    public string SpecialInstructions { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? WakeupCallId { get; set; }
    public string FollowUpCallYn { get; set; }
    public decimal? ParentCallId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcWake>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_WAKE");

            entity.HasIndex(e => e.ParentCallId)
                .HasName("IFC_WAKE_PARENT_CALL_ID_IDX");

            entity.HasIndex(e => e.WakeupCallId)
                .HasName("IFC_WAKE_CALL_ID_UIDX")
                .IsUnique();

            entity.HasIndex(e => new { e.WakeDest, e.WakeDate, e.Result })
                .HasName("IFC_WAKE_DEST");

            entity.HasIndex(e => new { e.Resort, e.RoomNum, e.LineNum, e.ResvNameId, e.WakeDate, e.WakeTime, e.ExtnNum, e.ExtnType })
                .HasName("IFC_WAKE_UK")
                .IsUnique();

            entity.Property(e => e.Command)
                .HasColumnName("COMMAND")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.ExtnNum)
                .HasColumnName("EXTN_NUM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtnType)
                .HasColumnName("EXTN_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FailCause)
                .HasColumnName("FAIL_CAUSE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FollowUpCallYn)
                .HasColumnName("FOLLOW_UP_CALL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupCode)
                .HasColumnName("GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LineNum)
                .HasColumnName("LINE_NUM")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ParentCallId)
                .HasColumnName("PARENT_CALL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResDate)
                .HasColumnName("RES_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ResLogin)
                .HasColumnName("RES_LOGIN")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResTime)
                .HasColumnName("RES_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Result)
                .HasColumnName("RESULT")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNum)
                .IsRequired()
                .HasColumnName("ROOM_NUM")
                .HasMaxLength(8)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SetDate)
                .HasColumnName("SET_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SetLogin)
                .HasColumnName("SET_LOGIN")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SetTime)
                .HasColumnName("SET_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.SpecialInstructions)
                .HasColumnName("SPECIAL_INSTRUCTIONS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.WakeDate)
                .HasColumnName("WAKE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WakeDest)
                .HasColumnName("WAKE_DEST")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.WakeLang)
                .HasColumnName("WAKE_LANG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WakeRetry)
                .HasColumnName("WAKE_RETRY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WakeStart)
                .HasColumnName("WAKE_START")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.WakeTime)
                .HasColumnName("WAKE_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WakeupCallId)
                .HasColumnName("WAKEUP_CALL_ID")
                .HasColumnType("NUMBER");
        });
	}
}
