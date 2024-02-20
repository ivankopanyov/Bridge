namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventChangesSearch
{
    public decimal? Attendees { get; set; }
    public decimal? BookId { get; set; }
    public string? Currency { get; set; }
    public decimal? EventChangeId { get; set; }
    public DateTime? EventDate { get; set; }
    public decimal? EventId { get; set; }
    public decimal? EventRevenue { get; set; }
    public string? EventStatus { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? Resort { get; set; }
    public string? RevenueType { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? CatSrepId { get; set; }
    public string? CatSrep { get; set; }
    public decimal? RmsSrepId { get; set; }
    public string? RmsSrep { get; set; }
    public decimal? MainSrepId { get; set; }
    public string? MainSrep { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventChangesSearch>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_CHANGES_SEARCH");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatSrep)
                .HasColumnName("CAT_SREP")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CatSrepId)
                .HasColumnName("CAT_SREP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EventChangeId)
                .HasColumnName("EVENT_CHANGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventDate)
                .HasColumnName("EVENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventRevenue)
                .HasColumnName("EVENT_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventStatus)
                .HasColumnName("EVENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MainSrep)
                .HasColumnName("MAIN_SREP")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.MainSrepId)
                .HasColumnName("MAIN_SREP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType)
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(23)
                .IsUnicode(false);

            entity.Property(e => e.RmsSrep)
                .HasColumnName("RMS_SREP")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RmsSrepId)
                .HasColumnName("RMS_SREP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
