namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CateringChangelog
{
    public string Action { get; set; }
    public decimal BookId { get; set; }
    public DateTime? ByDate { get; set; }
    public string ByUser { get; set; }
    public decimal ChangeId { get; set; }
    public decimal EventId { get; set; }
    public string Resort { get; set; }
    public decimal? ResourceId { get; set; }
    public string ResourceName { get; set; }
    public string ResourceType { get; set; }
    public string EventName { get; set; }
    public decimal UserId { get; set; }
    public decimal? MenuId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CateringChangelog>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CATERING_CHANGELOG");

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
                .IsRequired()
                .HasColumnName("BY_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ChangeId)
                .HasColumnName("CHANGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventName)
                .HasColumnName("EVENT_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

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

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");
        });
	}
}
