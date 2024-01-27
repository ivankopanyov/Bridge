namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Taskitems
{
    public Taskitems()
    {
        TaskitemsRooms = new HashSet<TaskitemsRooms>();
        WorkOrders = new HashSet<WorkOrders>();
    }

    public decimal? EstTime { get; set; }
    public DateTime? LastGeneratedDate { get; set; }
    public string DeptId { get; set; }
    public string TypeCode { get; set; }
    public DateTime? FirstDueDate { get; set; }
    public string Frequency { get; set; }
    public DateTime? LastMaintDate { get; set; }
    public decimal? MaintainedBy { get; set; }
    public DateTime? NextMaintDate { get; set; }
    public string InHouseYn { get; set; }
    public decimal TaskitemNumber { get; set; }
    public string Notes { get; set; }
    public decimal? PreAssignedTo { get; set; }
    public string Resort { get; set; }
    public decimal TaskCode { get; set; }
    public string PlantItemCode { get; set; }
    public string EstUotCode { get; set; }
    public string FolderName { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Purpose { get; set; }
    public decimal? Duration { get; set; }
    public string DurationTimeCode { get; set; }
    public string PrivateYn { get; set; }

    public virtual PlantItems PlantItems { get; set; }
    public virtual TaskitemsFolder TaskitemsFolder { get; set; }
    public virtual Tasks Tasks { get; set; }
    public virtual UnitOfTime UnitOfTime { get; set; }
    public virtual ICollection<TaskitemsRooms> TaskitemsRooms { get; set; }
    public virtual ICollection<WorkOrders> WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Taskitems>(entity =>
        {
            entity.HasKey(e => new { e.TaskitemNumber, e.Resort })
                .HasName("TASKITEM_PK");

            entity.ToTable("TASKITEMS");

            entity.HasIndex(e => e.TaskitemNumber)
                .HasName("TASKITEMNO_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.EstUotCode, e.Resort })
                .HasName("TASKITEM_UOT_FK_I");

            entity.HasIndex(e => new { e.Resort, e.FolderName })
                .HasName("TASKITEM_TF_FK_I");

            entity.HasIndex(e => new { e.Resort, e.PlantItemCode })
                .HasName("TASKITEM_PI_FK_I");

            entity.HasIndex(e => new { e.Resort, e.TaskCode })
                .HasName("TASKITEM_TL_FK_I");

            entity.Property(e => e.TaskitemNumber)
                .HasColumnName("TASKITEM_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Duration)
                .HasColumnName("DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DurationTimeCode)
                .HasColumnName("DURATION_TIME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EstTime)
                .HasColumnName("EST_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstUotCode)
                .HasColumnName("EST_UOT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FirstDueDate)
                .HasColumnName("FIRST_DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FolderName)
                .HasColumnName("FOLDER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InHouseYn)
                .IsRequired()
                .HasColumnName("IN_HOUSE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.LastGeneratedDate)
                .HasColumnName("LAST_GENERATED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastMaintDate)
                .HasColumnName("LAST_MAINT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MaintainedBy)
                .HasColumnName("MAINTAINED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NextMaintDate)
                .HasColumnName("NEXT_MAINT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PlantItemCode)
                .HasColumnName("PLANT_ITEM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PreAssignedTo)
                .HasColumnName("PRE_ASSIGNED_TO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrivateYn)
                .HasColumnName("PRIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Purpose)
                .HasColumnName("PURPOSE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TypeCode)
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(UnitOfTime)))
				entity.Ignore(e => e.UnitOfTime);
			else
	            entity.HasOne(d => d.UnitOfTime)
	                .WithMany(p => p.Taskitems)
	                .HasForeignKey(d => new { d.EstUotCode, d.Resort })
	                .HasConstraintName("TASKITEM_UOT_FK");

			if (!types.Contains(typeof(TaskitemsFolder)))
				entity.Ignore(e => e.TaskitemsFolder);
			else
	            entity.HasOne(d => d.TaskitemsFolder)
	                .WithMany(p => p.Taskitems)
	                .HasForeignKey(d => new { d.Resort, d.FolderName })
	                .HasConstraintName("TASKITEM_TF_FK");

			if (!types.Contains(typeof(PlantItems)))
				entity.Ignore(e => e.PlantItems);
			else
	            entity.HasOne(d => d.PlantItems)
	                .WithMany(p => p.Taskitems)
	                .HasForeignKey(d => new { d.Resort, d.PlantItemCode })
	                .HasConstraintName("TASKITEM_PI_FK");

			if (!types.Contains(typeof(Tasks)))
				entity.Ignore(e => e.Tasks);
			else
	            entity.HasOne(d => d.Tasks)
	                .WithMany(p => p.Taskitems)
	                .HasForeignKey(d => new { d.Resort, d.TaskCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("TASKITEM_TL_FK");
        
			if (!types.Contains(typeof(TaskitemsRooms)))
				entity.Ignore(e => e.TaskitemsRooms);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
		});
	}
}
