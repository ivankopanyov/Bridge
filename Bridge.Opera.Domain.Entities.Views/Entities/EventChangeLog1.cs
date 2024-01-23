namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventChangeLog1
{
    public string Resort { get; set; }
    public decimal? BookId { get; set; }
    public decimal? EventId { get; set; }
    public DateTime? EventDate { get; set; }
    public DateTime? ChangeDate { get; set; }
    public string RevenueType { get; set; }
    public decimal? RevenueChange { get; set; }
    public string CurrentStatus { get; set; }
    public string PriorStatus { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? ChangeId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventChangeLog1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_CHANGE_LOG");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeDate)
                .HasColumnName("CHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChangeId)
                .HasColumnName("CHANGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentStatus)
                .HasColumnName("CURRENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EventDate)
                .HasColumnName("EVENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriorStatus)
                .HasColumnName("PRIOR_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueChange)
                .HasColumnName("REVENUE_CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueType)
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
