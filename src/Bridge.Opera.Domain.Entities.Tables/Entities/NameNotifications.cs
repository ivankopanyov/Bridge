namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameNotifications
{
    public NameNotifications()
    {
        NameNotificationResorts = new HashSet<NameNotificationResorts>();
    }

    public decimal NotificationId { get; set; }
    public decimal NameId { get; set; }
    public string NoteCode { get; set; }
    public string NoteTitle { get; set; }
    public string NoteText { get; set; }
    public string AllResortsYn { get; set; }
    public string AllDepartmentsYn { get; set; }
    public string InternalYn { get; set; }
    public string ConfidentialYn { get; set; }
    public string NotificationAreas { get; set; }
    public DateTime? ResolvedOn { get; set; }
    public decimal? ResolvedBy { get; set; }
    public decimal? UniversalNotificationId { get; set; }
    public string SharedYn { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual Name Name { get; set; }
    public virtual ICollection<NameNotificationResorts> NameNotificationResorts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameNotifications>(entity =>
        {
            entity.HasKey(e => e.NotificationId)
                .HasName("NAME_NOTIFICATIONS_PK");

            entity.ToTable("NAME$_NOTIFICATIONS");

            entity.HasIndex(e => e.UniversalNotificationId)
                .HasName("NAME_NOTIFICATIONS_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.NameId, e.NoteCode })
                .HasName("NAME_NOTIFICATIONS_IDX1");

            entity.Property(e => e.NotificationId)
                .HasColumnName("NOTIFICATION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllDepartmentsYn)
                .HasColumnName("ALL_DEPARTMENTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AllResortsYn)
                .HasColumnName("ALL_RESORTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConfidentialYn)
                .HasColumnName("CONFIDENTIAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoteCode)
                .IsRequired()
                .HasColumnName("NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoteText)
                .IsRequired()
                .HasColumnName("NOTE_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.NoteTitle)
                .IsRequired()
                .HasColumnName("NOTE_TITLE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NotificationAreas)
                .IsRequired()
                .HasColumnName("NOTIFICATION_AREAS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ResolvedBy)
                .HasColumnName("RESOLVED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResolvedOn)
                .HasColumnName("RESOLVED_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.SharedYn)
                .HasColumnName("SHARED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UniversalNotificationId)
                .HasColumnName("UNIVERSAL_NOTIFICATION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.NameNotifications)
	                .HasForeignKey(d => d.NameId)
	                .HasConstraintName("NAME_NOTIFICATIONS_NAME_FK");
        
			if (!types.Contains(typeof(NameNotificationResorts)))
				entity.Ignore(e => e.NameNotificationResorts);
		});
	}
}
