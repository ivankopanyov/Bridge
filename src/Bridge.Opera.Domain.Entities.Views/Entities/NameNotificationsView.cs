namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameNotificationsView
{
    public string? NotificationType { get; set; }
    public decimal? NotificationId { get; set; }
    public decimal? NameId { get; set; }
    public string? NoteType { get; set; }
    public string? NoteCode { get; set; }
    public string? NoteTitle { get; set; }
    public string? NoteText { get; set; }
    public string? InternalYn { get; set; }
    public string? ConfidentialYn { get; set; }
    public string? AllResortsYn { get; set; }
    public string? Resorts { get; set; }
    public string? AllDepartmentsYn { get; set; }
    public string? Departments { get; set; }
    public string? NotificationAreas { get; set; }
    public DateTime? ResolvedOn { get; set; }
    public decimal? ResolvedBy { get; set; }
    public string? UniversalNoteId { get; set; }
    public string? ExternalNoteId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameNotificationsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_NOTIFICATIONS_VIEW");

            entity.Property(e => e.AllDepartmentsYn)
                .HasColumnName("ALL_DEPARTMENTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllResortsYn)
                .HasColumnName("ALL_RESORTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConfidentialYn)
                .HasColumnName("CONFIDENTIAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Departments)
                .HasColumnName("DEPARTMENTS")
                .IsUnicode(false);

            entity.Property(e => e.ExternalNoteId)
                .HasColumnName("EXTERNAL_NOTE_ID")
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
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoteCode)
                .HasColumnName("NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoteText)
                .HasColumnName("NOTE_TEXT")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoteTitle)
                .HasColumnName("NOTE_TITLE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoteType)
                .HasColumnName("NOTE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.NotificationAreas)
                .HasColumnName("NOTIFICATION_AREAS")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NotificationId)
                .HasColumnName("NOTIFICATION_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NotificationType)
                .HasColumnName("NOTIFICATION_TYPE")
                .HasMaxLength(12)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResolvedBy)
                .HasColumnName("RESOLVED_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResolvedOn)
                .HasColumnName("RESOLVED_ON")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resorts)
                .HasColumnName("RESORTS")
                .IsUnicode(false);

            entity.Property(e => e.UniversalNoteId)
                .HasColumnName("UNIVERSAL_NOTE_ID")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
