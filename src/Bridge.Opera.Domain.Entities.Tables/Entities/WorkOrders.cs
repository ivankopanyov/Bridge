namespace Bridge.Opera.Domain.Entities.Tables;

public partial class WorkOrders
{
    public WorkOrders()
    {
        ActivityLink = new HashSet<ActivityLink>();
        InverseParentWoNumberNavigation = new HashSet<WorkOrders>();
        LaborUsed = new HashSet<LaborUsed>();
        PartsUsed = new HashSet<PartsUsed>();
        RoomInspectionDetails = new HashSet<RoomInspectionDetails>();
        WorkOrdersResv = new HashSet<WorkOrdersResv>();
        WorkorderPager = new HashSet<WorkorderPager>();
    }

    public decimal? WoNumber { get; set; }
    public string? ActType { get; set; }
    public string? MasterSub { get; set; }
    public DateTime? CreatedDate { get; set; }
    public decimal? CreatedBy { get; set; }
    public string? ProblemDesc { get; set; }
    public string? Notes { get; set; }
    public decimal? AssignedBy { get; set; }
    public DateTime? AssignedOnDate { get; set; }
    public decimal? AssignedTo { get; set; }
    public decimal? TakenBy { get; set; }
    public DateTime? TakenDate { get; set; }
    public decimal? ReleasedBy { get; set; }
    public DateTime? ReleasedDate { get; set; }
    public decimal? CompletedBy { get; set; }
    public DateTime? CompletedDate { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime? ShowOn { get; set; }
    public decimal? TotalLaborCost { get; set; }
    public decimal? TotalPartsCost { get; set; }
    public string? UserExt { get; set; }
    public string? DeptOfAction { get; set; }
    public string? GuestRoomYn { get; set; }
    public string? PriorityChangedYn { get; set; }
    public decimal? EstTimeToComplete { get; set; }
    public string? Resort { get; set; }
    public string? CategoryCode { get; set; }
    public string? ReasonCode { get; set; }
    public string? LocationCode { get; set; }
    public string? PriorityCode { get; set; }
    public decimal? ParentWoNumber { get; set; }
    public string? StatusCode { get; set; }
    public decimal? TaskCode { get; set; }
    public decimal? TaskitemNumber { get; set; }
    public string? TypeCode { get; set; }
    public string? PlantItemCode { get; set; }
    public string? EstUotCode { get; set; }
    public decimal? DependingOnWoNumber { get; set; }
    public string? Room { get; set; }
    public string? GuestOriginatedYn { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? PrivateYn { get; set; }
    public string? FoRoomStatus { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? DownloadResort { get; set; }
    public DateTime? DownloadDate { get; set; }
    public decimal? DownloadSrep { get; set; }
    public DateTime? UploadDate { get; set; }
    public byte? LaptopChange { get; set; }
    public string? Tracecode { get; set; }
    public decimal? SurveyId { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? Attendees { get; set; }
    public string? ExternalSystemId { get; set; }
    public string? ExternalSystem { get; set; }
    public string? SendMethod { get; set; }
    public string? CompletedYn { get; set; }
    public string? ActClass { get; set; }
    public decimal? Author { get; set; }
    public byte[] Attachment { get; set; }
    public decimal? GeneratedByFreqId { get; set; }
    public byte[] BfileLocator { get; set; }
    public decimal? EstRmNights { get; set; }
    public decimal? EstRmRevenue { get; set; }
    public decimal? EstCatRevenue { get; set; }
    public decimal? EstOtherRevenue { get; set; }
    public decimal? RequestTemplateId { get; set; }
    public string? RequestTypeId { get; set; }
    public string? CampaignStatusCode { get; set; }
    public string? GeneratedByCampaign { get; set; }
    public string? Result { get; set; }
    public decimal? RequestTypeTemplatesId { get; set; }
    public string? NotifiedYn { get; set; }
    public decimal? DepositAmount { get; set; }
    public string? DepositOwner { get; set; }
    public decimal? ActivityAmount { get; set; }
    public string? GuestType { get; set; }
    public string? AttachmentLocation { get; set; }
    public string? InternalYn { get; set; }
    public string? DatabaseId { get; set; }
    public string? AttachmentOwner { get; set; }
    public decimal? MinutesBeforeAlert { get; set; }
    public string? GlobalYn { get; set; }
    public string? TimezoneConvertedYn { get; set; }
    public decimal? OrigWoNumber { get; set; }
    public DateTime? ProposalSentDate { get; set; }
    public string? ProposalViewToken { get; set; }

    public virtual Locations Locations { get; set; }
    public virtual WorkOrders ParentWoNumberNavigation { get; set; }
    public virtual PlantItems PlantItems { get; set; }
    public virtual Priorities Priorities { get; set; }
    public virtual ResortActivityTypes Re { get; set; }
    public virtual Reasons ReNavigation { get; set; }
    public virtual RequestTypeTemplates RequestTypeTemplates { get; set; }
    public virtual StatusCode StatusCodeNavigation { get; set; }
    public virtual TaskTypes TaskTypes { get; set; }
    public virtual Taskitems Taskitems { get; set; }
    public virtual Tasks Tasks { get; set; }
    public virtual UnitOfTime UnitOfTime { get; set; }
    public virtual WorkCategories WorkCategories { get; set; }
    public virtual ICollection<ActivityLink> ActivityLink { get; set; }
    public virtual ICollection<WorkOrders> InverseParentWoNumberNavigation { get; set; }
    public virtual ICollection<LaborUsed> LaborUsed { get; set; }
    public virtual ICollection<PartsUsed> PartsUsed { get; set; }
    public virtual ICollection<RoomInspectionDetails> RoomInspectionDetails { get; set; }
    public virtual ICollection<WorkOrdersResv> WorkOrdersResv { get; set; }
    public virtual ICollection<WorkorderPager> WorkorderPager { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<WorkOrders>(entity =>
        {
            entity.HasKey(e => new { e.WoNumber, e.Resort })
                .HasName("WO_PK");

            entity.ToTable("WORK_ORDERS");

            entity.HasIndex(e => e.ParentWoNumber)
                .HasName("WO_WO_CHILD_OF_FK_I");

            entity.HasIndex(e => e.RequestTypeTemplatesId)
                .HasName("WO_RTT_FK_I");

            entity.HasIndex(e => e.Resort)
                .HasName("RESORT_START_DATE_NUK")
                .HasFilter("\"START_DATE\"");

            entity.HasIndex(e => e.WoNumber)
                .HasName("WO_NUMBER_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.CompletedYn, e.TypeCode })
                .HasName("WO_COMPLETED_YN_I");

            entity.HasIndex(e => new { e.EstUotCode, e.Resort })
                .HasName("WO_UOT_FK_I");

            entity.HasIndex(e => new { e.RequestTypeId, e.Resort })
                .HasName("WO_RAT_FK_I");

            entity.HasIndex(e => new { e.Resort, e.CategoryCode })
                .HasName("WO_WC_FK_I");

            entity.HasIndex(e => new { e.Resort, e.LocationCode })
                .HasName("WO_LOC1_FK_I");

            entity.HasIndex(e => new { e.Resort, e.PlantItemCode })
                .HasName("WO_PI_FK_I");

            entity.HasIndex(e => new { e.Resort, e.PriorityCode })
                .HasName("WO_PRI_FK_I");

            entity.HasIndex(e => new { e.Resort, e.ReasonCode })
                .HasName("WO_REASON_FK_I");

            entity.HasIndex(e => new { e.Resort, e.StatusCode })
                .HasName("WO_SC_FK_I");

            entity.HasIndex(e => new { e.Resort, e.SurveyId })
                .HasName("WO_SURVEY_IDX");

            entity.HasIndex(e => new { e.Resort, e.TaskCode })
                .HasName("WO_TL_FK_I");

            entity.HasIndex(e => new { e.Resort, e.TypeCode })
                .HasName("WO_TASK_TYPES_FK_I");

            entity.HasIndex(e => new { e.TaskitemNumber, e.Resort })
                .HasName("WO_TASKITEM_FK_I");

            entity.HasIndex(e => new { e.AssignedTo, e.StartDate, e.EndDate })
                .HasName("WO_ASSIGNED_DATES_IDX");

            entity.HasIndex(e => new { e.Resort, e.TypeCode, e.CompletedDate })
                .HasName("WO_TYPECODE_COMP_DT_IDX");

            entity.HasIndex(e => new { e.Resort, e.AssignedTo, e.StartDate, e.EndDate })
                .HasName("WO_RESORT_SREP_I");

            entity.Property(e => e.WoNumber)
                .HasColumnName("WO_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActClass)
                .HasColumnName("ACT_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActType)
                .HasColumnName("ACT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActivityAmount)
                .HasColumnName("ACTIVITY_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AssignedBy)
                .HasColumnName("ASSIGNED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AssignedOnDate)
                .HasColumnName("ASSIGNED_ON_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AssignedTo)
                .HasColumnName("ASSIGNED_TO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Attachment)
                .HasColumnName("ATTACHMENT")
                .HasColumnType("BLOB");

            entity.Property(e => e.AttachmentLocation)
                .HasColumnName("ATTACHMENT_LOCATION")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AttachmentOwner)
                .HasColumnName("ATTACHMENT_OWNER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Author)
                .HasColumnName("AUTHOR")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BfileLocator)
                .HasColumnName("BFILE_LOCATOR")
                .HasColumnType("BFILE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CampaignStatusCode)
                .HasColumnName("CAMPAIGN_STATUS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CategoryCode)
                .HasColumnName("CATEGORY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompletedBy)
                .HasColumnName("COMPLETED_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CompletedDate)
                .HasColumnName("COMPLETED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CompletedYn)
                .HasColumnName("COMPLETED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.CreatedBy)
                .HasColumnName("CREATED_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CREATED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DatabaseId)
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DependingOnWoNumber)
                .HasColumnName("DEPENDING_ON_WO_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositAmount)
                .HasColumnName("DEPOSIT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositOwner)
                .HasColumnName("DEPOSIT_OWNER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DeptOfAction)
                .HasColumnName("DEPT_OF_ACTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DownloadDate)
                .HasColumnName("DOWNLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DownloadResort)
                .HasColumnName("DOWNLOAD_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DownloadSrep)
                .HasColumnName("DOWNLOAD_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DueDate)
                .HasColumnName("DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EstCatRevenue)
                .HasColumnName("EST_CAT_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstOtherRevenue)
                .HasColumnName("EST_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstRmNights)
                .HasColumnName("EST_RM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstRmRevenue)
                .HasColumnName("EST_RM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstTimeToComplete)
                .HasColumnName("EST_TIME_TO_COMPLETE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstUotCode)
                .HasColumnName("EST_UOT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExternalSystem)
                .HasColumnName("EXTERNAL_SYSTEM")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExternalSystemId)
                .HasColumnName("EXTERNAL_SYSTEM_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FoRoomStatus)
                .HasColumnName("FO_ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GeneratedByCampaign)
                .HasColumnName("GENERATED_BY_CAMPAIGN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GeneratedByFreqId)
                .HasColumnName("GENERATED_BY_FREQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GlobalYn)
                .HasColumnName("GLOBAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GuestOriginatedYn)
                .HasColumnName("GUEST_ORIGINATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.GuestRoomYn)
                .HasColumnName("GUEST_ROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.GuestType)
                .HasColumnName("GUEST_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.LocationCode)
                .HasColumnName("LOCATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MasterSub)
                .HasColumnName("MASTER_SUB")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MinutesBeforeAlert)
                .HasColumnName("MINUTES_BEFORE_ALERT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NotifiedYn)
                .HasColumnName("NOTIFIED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrigWoNumber)
                .HasColumnName("ORIG_WO_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentWoNumber)
                .HasColumnName("PARENT_WO_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PlantItemCode)
                .HasColumnName("PLANT_ITEM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PriorityChangedYn)
                .HasColumnName("PRIORITY_CHANGED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PriorityCode)
                .HasColumnName("PRIORITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrivateYn)
                .HasColumnName("PRIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ProblemDesc)
                .HasColumnName("PROBLEM_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ProposalSentDate)
                .HasColumnName("PROPOSAL_SENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProposalViewToken)
                .HasColumnName("PROPOSAL_VIEW_TOKEN")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReleasedBy)
                .HasColumnName("RELEASED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReleasedDate)
                .HasColumnName("RELEASED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestTemplateId)
                .HasColumnName("REQUEST_TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestTypeId)
                .HasColumnName("REQUEST_TYPE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RequestTypeTemplatesId)
                .HasColumnName("REQUEST_TYPE_TEMPLATES_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Result)
                .HasColumnName("RESULT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SendMethod)
                .HasColumnName("SEND_METHOD")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ShowOn)
                .HasColumnName("SHOW_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StatusCode)
                .HasColumnName("STATUS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SurveyId)
                .HasColumnName("SURVEY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TakenBy)
                .HasColumnName("TAKEN_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TakenDate)
                .HasColumnName("TAKEN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaskitemNumber)
                .HasColumnName("TASKITEM_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TimezoneConvertedYn)
                .HasColumnName("TIMEZONE_CONVERTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TotalLaborCost)
                .HasColumnName("TOTAL_LABOR_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPartsCost)
                .HasColumnName("TOTAL_PARTS_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tracecode)
                .HasColumnName("TRACECODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TypeCode)
                .IsRequired()
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UploadDate)
                .HasColumnName("UPLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UserExt)
                .HasColumnName("USER_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.ParentWoNumberNavigation);
			else
	            entity.HasOne(d => d.ParentWoNumberNavigation)
	                .WithMany(p => p.InverseParentWoNumberNavigation)
	                .HasPrincipalKey(p => p.WoNumber)
	                .HasForeignKey(d => d.ParentWoNumber)
	                .HasConstraintName("WO_WO_CHILD_OF_FK");

			if (!types.Contains(typeof(RequestTypeTemplates)))
				entity.Ignore(e => e.RequestTypeTemplates);
			else
	            entity.HasOne(d => d.RequestTypeTemplates)
	                .WithMany(p => p.WorkOrders)
	                .HasForeignKey(d => d.RequestTypeTemplatesId)
	                .HasConstraintName("WO_RTT_FK");

			if (!types.Contains(typeof(UnitOfTime)))
				entity.Ignore(e => e.UnitOfTime);
			else
	            entity.HasOne(d => d.UnitOfTime)
	                .WithMany(p => p.WorkOrders)
	                .HasForeignKey(d => new { d.EstUotCode, d.Resort })
	                .HasConstraintName("WO_UOT_FK");

			if (!types.Contains(typeof(ResortActivityTypes)))
				entity.Ignore(e => e.Re);
			else
	            entity.HasOne(d => d.Re)
	                .WithMany(p => p.WorkOrders)
	                .HasForeignKey(d => new { d.RequestTypeId, d.Resort })
	                .HasConstraintName("WO_RAT_FK");

			if (!types.Contains(typeof(WorkCategories)))
				entity.Ignore(e => e.WorkCategories);
			else
	            entity.HasOne(d => d.WorkCategories)
	                .WithMany(p => p.WorkOrders)
	                .HasForeignKey(d => new { d.Resort, d.CategoryCode })
	                .HasConstraintName("WO_WC_FK");

			if (!types.Contains(typeof(Locations)))
				entity.Ignore(e => e.Locations);
			else
	            entity.HasOne(d => d.Locations)
	                .WithMany(p => p.WorkOrders)
	                .HasForeignKey(d => new { d.Resort, d.LocationCode })
	                .HasConstraintName("WO_LOC1_FK");

			if (!types.Contains(typeof(PlantItems)))
				entity.Ignore(e => e.PlantItems);
			else
	            entity.HasOne(d => d.PlantItems)
	                .WithMany(p => p.WorkOrders)
	                .HasForeignKey(d => new { d.Resort, d.PlantItemCode })
	                .HasConstraintName("WO_PI_FK");

			if (!types.Contains(typeof(Priorities)))
				entity.Ignore(e => e.Priorities);
			else
	            entity.HasOne(d => d.Priorities)
	                .WithMany(p => p.WorkOrders)
	                .HasForeignKey(d => new { d.Resort, d.PriorityCode })
	                .HasConstraintName("WO_PRI_FK");

			if (!types.Contains(typeof(Reasons)))
				entity.Ignore(e => e.ReNavigation);
			else
	            entity.HasOne(d => d.ReNavigation)
	                .WithMany(p => p.WorkOrders)
	                .HasForeignKey(d => new { d.Resort, d.ReasonCode })
	                .HasConstraintName("WO_REASON_FK");

			if (!types.Contains(typeof(StatusCode)))
				entity.Ignore(e => e.StatusCodeNavigation);
			else
	            entity.HasOne(d => d.StatusCodeNavigation)
	                .WithMany(p => p.WorkOrders)
	                .HasForeignKey(d => new { d.Resort, d.StatusCode })
	                .HasConstraintName("WO_SC_FK");

			if (!types.Contains(typeof(Tasks)))
				entity.Ignore(e => e.Tasks);
			else
	            entity.HasOne(d => d.Tasks)
	                .WithMany(p => p.WorkOrders)
	                .HasForeignKey(d => new { d.Resort, d.TaskCode })
	                .HasConstraintName("WO_TL_FK");

			if (!types.Contains(typeof(Taskitems)))
				entity.Ignore(e => e.Taskitems);
			else
	            entity.HasOne(d => d.Taskitems)
	                .WithMany(p => p.WorkOrders)
	                .HasForeignKey(d => new { d.TaskitemNumber, d.Resort })
	                .HasConstraintName("WO_TASKITEM_FK");

			if (!types.Contains(typeof(TaskTypes)))
				entity.Ignore(e => e.TaskTypes);
			else
	            entity.HasOne(d => d.TaskTypes)
	                .WithMany(p => p.WorkOrders)
	                .HasForeignKey(d => new { d.TypeCode, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("WO_TASK_TYPES_FK");
        
			if (!types.Contains(typeof(ActivityLink)))
				entity.Ignore(e => e.ActivityLink);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.InverseParentWoNumberNavigation);

			if (!types.Contains(typeof(LaborUsed)))
				entity.Ignore(e => e.LaborUsed);

			if (!types.Contains(typeof(PartsUsed)))
				entity.Ignore(e => e.PartsUsed);

			if (!types.Contains(typeof(RoomInspectionDetails)))
				entity.Ignore(e => e.RoomInspectionDetails);

			if (!types.Contains(typeof(WorkOrdersResv)))
				entity.Ignore(e => e.WorkOrdersResv);

			if (!types.Contains(typeof(WorkorderPager)))
				entity.Ignore(e => e.WorkorderPager);
		});
	}
}
