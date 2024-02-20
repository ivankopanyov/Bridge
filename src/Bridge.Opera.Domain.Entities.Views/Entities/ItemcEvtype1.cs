namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ItemcEvtype1
{
    public decimal? ItemclassId { get; set; }
    public string? EventType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ItemcEvtype1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ITEMC_EVTYPE");

            entity.Property(e => e.EventType)
                .IsRequired()
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ItemclassId)
                .HasColumnName("ITEMCLASS_ID")
                .HasColumnType("NUMBER");
        });
	}
}
