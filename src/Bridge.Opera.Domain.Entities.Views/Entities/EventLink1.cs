namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventLink1
{
    public decimal? LinkId { get; set; }
    public decimal? EventId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventLink1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_LINK");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkId)
                .HasColumnName("LINK_ID")
                .HasColumnType("NUMBER");
        });
	}
}
