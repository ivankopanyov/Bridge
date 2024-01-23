namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LeadNotification1
{
    public string Resort { get; set; }
    public string NotificationGroup { get; set; }
    public string NotificationCode { get; set; }
    public decimal LeadId { get; set; }
    public string DataYn { get; set; }
    public string EmailYn { get; set; }
    public DateTime? NotificationDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LeadNotification1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LEAD_NOTIFICATION");

            entity.Property(e => e.DataYn)
                .HasColumnName("DATA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailYn)
                .HasColumnName("EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadId)
                .HasColumnName("LEAD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NotificationCode)
                .IsRequired()
                .HasColumnName("NOTIFICATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NotificationDate)
                .HasColumnName("NOTIFICATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NotificationGroup)
                .IsRequired()
                .HasColumnName("NOTIFICATION_GROUP")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
