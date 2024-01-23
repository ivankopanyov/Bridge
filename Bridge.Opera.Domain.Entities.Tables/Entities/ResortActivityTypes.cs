namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortActivityTypes
{
    public ResortActivityTypes()
    {
        ActTrace = new HashSet<ActTrace>();
        NameGoal = new HashSet<NameGoal>();
        RequestTypeTemplates = new HashSet<RequestTypeTemplates>();
        WorkOrders = new HashSet<WorkOrders>();
    }

    public string Resort { get; set; }
    public string ActivityType { get; set; }
    public string Description { get; set; }
    public string CentralYn { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? SurveyTemplateId { get; set; }
    public string SendMethod { get; set; }
    public string Url { get; set; }
    public string TypeCode { get; set; }
    public decimal? RequestId { get; set; }
    public decimal? AttachTemplateId { get; set; }
    public string ActivityClass { get; set; }
    public string AlertOnCreationYn { get; set; }
    public decimal? MinutesBeforeAlert { get; set; }
    public string InternalYn { get; set; }
    public string WebProposalYn { get; set; }
    public string AutoIcalYn { get; set; }

    public virtual ICollection<ActTrace> ActTrace { get; set; }
    public virtual ICollection<NameGoal> NameGoal { get; set; }
    public virtual ICollection<RequestTypeTemplates> RequestTypeTemplates { get; set; }
    public virtual ICollection<WorkOrders> WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortActivityTypes>(entity =>
        {
            entity.HasKey(e => new { e.ActivityType, e.Resort })
                .HasName("RAT_PK");

            entity.ToTable("RESORT$ACTIVITY_TYPES");

            entity.Property(e => e.ActivityType)
                .HasColumnName("ACTIVITY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActivityClass)
                .HasColumnName("ACTIVITY_CLASS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AlertOnCreationYn)
                .HasColumnName("ALERT_ON_CREATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AttachTemplateId)
                .HasColumnName("ATTACH_TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoIcalYn)
                .HasColumnName("AUTO_ICAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CentralYn)
                .HasColumnName("CENTRAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MinutesBeforeAlert)
                .HasColumnName("MINUTES_BEFORE_ALERT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SendMethod)
                .HasColumnName("SEND_METHOD")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SurveyTemplateId)
                .HasColumnName("SURVEY_TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TypeCode)
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Url)
                .HasColumnName("URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.WebProposalYn)
                .HasColumnName("WEB_PROPOSAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(ActTrace)))
				entity.Ignore(e => e.ActTrace);

			if (!types.Contains(typeof(NameGoal)))
				entity.Ignore(e => e.NameGoal);

			if (!types.Contains(typeof(RequestTypeTemplates)))
				entity.Ignore(e => e.RequestTypeTemplates);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
		});
	}
}
