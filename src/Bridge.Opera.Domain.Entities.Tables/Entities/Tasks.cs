namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Tasks
{
    public Tasks()
    {
        RoomInspectionDetails = new HashSet<RoomInspectionDetails>();
        TaskTemplateDetails = new HashSet<TaskTemplateDetails>();
        TaskTranslation = new HashSet<TaskTranslation>();
        Taskitems = new HashSet<Taskitems>();
        WorkOrders = new HashSet<WorkOrders>();
    }

    public string Resort { get; set; }
    public string PmsReasonCode { get; set; }
    public decimal? ResponseTime { get; set; }
    public string ResponseTimeCode { get; set; }
    public string StatusAtResponse { get; set; }
    public string RmStatusAtCreation { get; set; }
    public string RmStatusAtCompletion { get; set; }
    public string RmStatusIfOccupied { get; set; }
    public string AlertPmsUserYn { get; set; }
    public decimal TaskCode { get; set; }
    public string Description { get; set; }
    public decimal? EstTime { get; set; }
    public string Notes { get; set; }
    public string PriorityCode { get; set; }
    public string CategoryCode { get; set; }
    public string TypeCode { get; set; }
    public string EstUotCode { get; set; }
    public string LanguageCode { get; set; }
    public string Frequency { get; set; }
    public string ActiveYn { get; set; }
    public string NotifyYn { get; set; }

    public virtual Priorities Priorities { get; set; }
    public virtual UnitOfTime Res { get; set; }
    public virtual StatusCode StatusCode { get; set; }
    public virtual TaskTypes TaskTypes { get; set; }
    public virtual UnitOfTime UnitOfTime { get; set; }
    public virtual WorkCategories WorkCategories { get; set; }
    public virtual ICollection<RoomInspectionDetails> RoomInspectionDetails { get; set; }
    public virtual ICollection<TaskTemplateDetails> TaskTemplateDetails { get; set; }
    public virtual ICollection<TaskTranslation> TaskTranslation { get; set; }
    public virtual ICollection<Taskitems> Taskitems { get; set; }
    public virtual ICollection<WorkOrders> WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tasks>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TaskCode })
                .HasName("TL_PK");

            entity.ToTable("TASKS");

            entity.HasIndex(e => new { e.EstUotCode, e.Resort })
                .HasName("TL_UOT_FK_I");

            entity.HasIndex(e => new { e.Resort, e.CategoryCode })
                .HasName("TL_WC_FK_I");

            entity.HasIndex(e => new { e.Resort, e.PriorityCode })
                .HasName("TL_PRI_FK_I");

            entity.HasIndex(e => new { e.Resort, e.StatusAtResponse })
                .HasName("TL_SC_FK_I");

            entity.HasIndex(e => new { e.TypeCode, e.Resort })
                .HasName("TL_TASK_TYPES_FK_I");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.AlertPmsUserYn)
                .HasColumnName("ALERT_PMS_USER_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.CategoryCode)
                .IsRequired()
                .HasColumnName("CATEGORY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EstTime)
                .HasColumnName("EST_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstUotCode)
                .HasColumnName("EST_UOT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NotifyYn)
                .HasColumnName("NOTIFY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PmsReasonCode)
                .HasColumnName("PMS_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PriorityCode)
                .IsRequired()
                .HasColumnName("PRIORITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResponseTime)
                .HasColumnName("RESPONSE_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResponseTimeCode)
                .HasColumnName("RESPONSE_TIME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmStatusAtCompletion)
                .HasColumnName("RM_STATUS_AT_COMPLETION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmStatusAtCreation)
                .HasColumnName("RM_STATUS_AT_CREATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmStatusIfOccupied)
                .HasColumnName("RM_STATUS_IF_OCCUPIED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatusAtResponse)
                .HasColumnName("STATUS_AT_RESPONSE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypeCode)
                .IsRequired()
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(UnitOfTime)))
				entity.Ignore(e => e.UnitOfTime);
			else
	            entity.HasOne(d => d.UnitOfTime)
	                .WithMany(p => p.TasksUnitOfTime)
	                .HasForeignKey(d => new { d.EstUotCode, d.Resort })
	                .HasConstraintName("TL_UOT_FK");

			if (!types.Contains(typeof(WorkCategories)))
				entity.Ignore(e => e.WorkCategories);
			else
	            entity.HasOne(d => d.WorkCategories)
	                .WithMany(p => p.Tasks)
	                .HasForeignKey(d => new { d.Resort, d.CategoryCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("TL_WC_FK");

			if (!types.Contains(typeof(Priorities)))
				entity.Ignore(e => e.Priorities);
			else
	            entity.HasOne(d => d.Priorities)
	                .WithMany(p => p.Tasks)
	                .HasForeignKey(d => new { d.Resort, d.PriorityCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("TL_PRI_FK");

			if (!types.Contains(typeof(StatusCode)))
				entity.Ignore(e => e.StatusCode);
			else
	            entity.HasOne(d => d.StatusCode)
	                .WithMany(p => p.Tasks)
	                .HasForeignKey(d => new { d.Resort, d.StatusAtResponse })
	                .HasConstraintName("TL_SC_FK");

			if (!types.Contains(typeof(UnitOfTime)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.TasksRes)
	                .HasForeignKey(d => new { d.ResponseTimeCode, d.Resort })
	                .HasConstraintName("TL_UOT_FK2");

			if (!types.Contains(typeof(TaskTypes)))
				entity.Ignore(e => e.TaskTypes);
			else
	            entity.HasOne(d => d.TaskTypes)
	                .WithMany(p => p.Tasks)
	                .HasForeignKey(d => new { d.TypeCode, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("TL_TASK_TYPES_FK");
        
			if (!types.Contains(typeof(RoomInspectionDetails)))
				entity.Ignore(e => e.RoomInspectionDetails);

			if (!types.Contains(typeof(TaskTemplateDetails)))
				entity.Ignore(e => e.TaskTemplateDetails);

			if (!types.Contains(typeof(TaskTranslation)))
				entity.Ignore(e => e.TaskTranslation);

			if (!types.Contains(typeof(Taskitems)))
				entity.Ignore(e => e.Taskitems);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
		});
	}
}
