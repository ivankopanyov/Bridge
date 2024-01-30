namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepCateringProduction
{
    public decimal? ReportId { get; set; }
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public decimal? EventId { get; set; }
    public string? EventStatus { get; set; }
    public string? RevenueType { get; set; }
    public string? EventType { get; set; }
    public decimal? Revenue { get; set; }
    public decimal? Attendees { get; set; }
    public string? AddAttendeesPerRgEvYn { get; set; }
    public string? AddAttendeesPerEventYn { get; set; }
    public decimal? LyrRevenue { get; set; }
    public decimal? LyrAttendees { get; set; }
    public string? RevType { get; set; }
    public string? RevenueTypeDescription { get; set; }
    public decimal? RevTypeSort { get; set; }
    public string? RevGroup { get; set; }
    public string? RevenueGroupDescription { get; set; }
    public decimal? RevGroupSort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepCateringProduction>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_CATERING_PRODUCTION");

            entity.Property(e => e.AddAttendeesPerEventYn)
                .HasColumnName("ADD_ATTENDEES_PER_EVENT_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.AddAttendeesPerRgEvYn)
                .HasColumnName("ADD_ATTENDEES_PER_RG_EV_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventStatus)
                .HasColumnName("EVENT_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EventType)
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LyrAttendees)
                .HasColumnName("LYR_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyrRevenue)
                .HasColumnName("LYR_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RevGroup)
                .IsRequired()
                .HasColumnName("REV_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevGroupSort)
                .HasColumnName("REV_GROUP_SORT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevType)
                .IsRequired()
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevTypeSort)
                .HasColumnName("REV_TYPE_SORT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueGroupDescription)
                .HasColumnName("REVENUE_GROUP_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType)
                .IsRequired()
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueTypeDescription)
                .HasColumnName("REVENUE_TYPE_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
