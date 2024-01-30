namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EvMenuRevSummary
{
    public decimal? BookId { get; set; }
    public decimal? EventId { get; set; }
    public decimal? EventMenuId { get; set; }
    public decimal? Revenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EvMenuRevSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EV_MENU_REV_SUMMARY");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventMenuId)
                .HasColumnName("EVENT_MENU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}
