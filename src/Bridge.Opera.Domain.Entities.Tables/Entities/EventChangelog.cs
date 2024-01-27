namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventChangelog
{
    public EventChangelog()
    {
        EventChangelogDetails = new HashSet<EventChangelogDetails>();
    }

    public decimal ChangeId { get; set; }
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public decimal EventId { get; set; }
    public string EvName { get; set; }
    public decimal? MenuId { get; set; }
    public string ResourceType { get; set; }
    public decimal? ResourceId { get; set; }
    public string ResourceName { get; set; }
    public string Action { get; set; }
    public decimal? ByUser { get; set; }
    public DateTime? ByDate { get; set; }

    public virtual ICollection<EventChangelogDetails> EventChangelogDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventChangelog>(entity =>
        {
            entity.HasKey(e => e.ChangeId)
                .HasName("EVLOG_PK");

            entity.ToTable("EVENT$CHANGELOG");

            entity.HasIndex(e => new { e.Resort, e.BookId, e.EventId })
                .HasName("EVLOG_RESBOOKEV_IDX");

            entity.Property(e => e.ChangeId)
                .HasColumnName("CHANGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ByDate)
                .HasColumnName("BY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ByUser)
                .HasColumnName("BY_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EvName)
                .HasColumnName("EV_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenuId)
                .HasColumnName("MENU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResourceId)
                .HasColumnName("RESOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResourceName)
                .HasColumnName("RESOURCE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResourceType)
                .HasColumnName("RESOURCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(EventChangelogDetails)))
				entity.Ignore(e => e.EventChangelogDetails);
		});
	}
}
