namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MenuEvtype1
{
    public decimal MenuId { get; set; }
    public string EventType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MenuEvtype1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MENU_EVTYPE");

            entity.Property(e => e.EventType)
                .IsRequired()
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MenuId)
                .HasColumnName("MENU_ID")
                .HasColumnType("NUMBER");
        });
	}
}
