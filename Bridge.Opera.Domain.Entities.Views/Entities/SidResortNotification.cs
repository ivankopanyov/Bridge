namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidResortNotification
{
    public string Resort { get; set; }
    public string NotificationGroup { get; set; }
    public string NotificationCode { get; set; }
    public string Description { get; set; }
    public string TimeComponentYn { get; set; }
    public decimal? HoursBeforeAlert { get; set; }
    public string BookingStatus { get; set; }
    public string DataYn { get; set; }
    public string AlertOnCreationYn { get; set; }
    public string ActivityType { get; set; }
    public string NotificationText { get; set; }
    public string NotifyLeadOwner { get; set; }
    public string DataRecipients { get; set; }
    public string EmailYn { get; set; }
    public string EmailSubject { get; set; }
    public string EmailBody { get; set; }
    public string NotifyLeadOwnerEmail { get; set; }
    public string NotifyCentralOwnerYn { get; set; }
    public string EmailRecipients { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidResortNotification>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_RESORT_NOTIFICATION");

            entity.Property(e => e.ActivityType)
                .HasColumnName("ACTIVITY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AlertOnCreationYn)
                .HasColumnName("ALERT_ON_CREATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BookingStatus)
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DataRecipients)
                .HasColumnName("DATA_RECIPIENTS")
                .IsUnicode(false);

            entity.Property(e => e.DataYn)
                .HasColumnName("DATA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.EmailBody)
                .HasColumnName("EMAIL_BODY")
                .IsUnicode(false);

            entity.Property(e => e.EmailRecipients)
                .HasColumnName("EMAIL_RECIPIENTS")
                .IsUnicode(false);

            entity.Property(e => e.EmailSubject)
                .HasColumnName("EMAIL_SUBJECT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EmailYn)
                .HasColumnName("EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HoursBeforeAlert)
                .HasColumnName("HOURS_BEFORE_ALERT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NotificationCode)
                .IsRequired()
                .HasColumnName("NOTIFICATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NotificationGroup)
                .IsRequired()
                .HasColumnName("NOTIFICATION_GROUP")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NotificationText)
                .HasColumnName("NOTIFICATION_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.NotifyCentralOwnerYn)
                .HasColumnName("NOTIFY_CENTRAL_OWNER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NotifyLeadOwner)
                .HasColumnName("NOTIFY_LEAD_OWNER")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.NotifyLeadOwnerEmail)
                .HasColumnName("NOTIFY_LEAD_OWNER_EMAIL")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TimeComponentYn)
                .HasColumnName("TIME_COMPONENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
