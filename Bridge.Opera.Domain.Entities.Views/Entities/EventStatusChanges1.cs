namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventStatusChanges1
{
    public decimal BookId { get; set; }
    public string CurrentStatus { get; set; }
    public decimal EventId { get; set; }
    public decimal EvChangeId { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public string PriorStatus { get; set; }
    public string Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventStatusChanges1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_STATUS_CHANGES");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrentStatus)
                .HasColumnName("CURRENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EvChangeId)
                .HasColumnName("EV_CHANGE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriorStatus)
                .HasColumnName("PRIOR_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
